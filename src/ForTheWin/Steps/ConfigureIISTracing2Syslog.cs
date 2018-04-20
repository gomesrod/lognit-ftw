using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForTheWin.Steps
{
    public class ConfigureIISTracing2Syslog : ConfigureApp
    {
        private readonly string tracingDir;

        public ConfigureIISTracing2Syslog(string serverAndPort, string tracingDir)
            : base(
            "IISTracing2Syslog",
            @"HKEY_LOCAL_MACHINE\SOFTWARE\Intelie\IISTracing2Syslog", 
            serverAndPort)
        {
            this.tracingDir = tracingDir;
        }

        public override void Execute()
        {
            base.Execute();

            SetString("Log", "Path", tracingDir);
        }
    }
}
