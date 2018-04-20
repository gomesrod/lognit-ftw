using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace ForTheWin.Steps
{
    public class ConfigureApp : IStep
    {
        readonly string serviceName, baseKey, hostAndPort;
        
        public ConfigureApp(string serviceName, string baseKey, string hostAndPort)
        {
            this.serviceName = serviceName;
            this.baseKey = baseKey;
            this.hostAndPort = hostAndPort;
        }

        public string Title
        {
            get { return string.Format("Configuring {0}", serviceName); }
        }

        public virtual void Execute()
        {
            var parts = hostAndPort.Split(':');
            SetString("Network", "Destination", parts[0]);
            SetDword("Network", "DestPort", int.Parse(parts[1]));
            SetDword("Network", "Syslog", 1);

            SetDword("Remote", "Restrict", 1);
            SetDword("Remote", "Allow", 1);
            SetDword("Remote", "AccessKey", 0);


            var controller = new ServiceController(serviceName);

            try
            {
                controller.Stop();
            }
            catch (InvalidOperationException)
            {
                // Ignoring.
                // This can be thrown if the service was not started or if it does not exist.
                // In the first case it is already in the desired state.
                // In the second case it can be detected on Start.
            }

            try
            {
                controller.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromSeconds(10));
            }
            catch { }

            controller.Start();
            controller.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromSeconds(10));
        }

        protected void SetString(string path, string key, string value)
        {
            Registry.SetValue(baseKey + @"\" + path, key, value, RegistryValueKind.String);
        }

        protected void SetDword(string path, string key, long value)
        {
            Registry.SetValue(baseKey + @"\" + path, key, value, RegistryValueKind.DWord);
        }

    }
}
