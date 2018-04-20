using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace ForTheWin.Steps
{
    public class InstallApp : IStep
    {
        readonly string name;
        readonly byte[] executable;
        readonly string argument;
        readonly string copyTo;

        public InstallApp(string name, byte[] executable, string argument)
        {
            this.name = name;
            this.executable = executable;
            this.argument = argument;
            this.copyTo = null;
        }

        public InstallApp(string name, byte[] executable, string copyTo, string argument)
        {
            this.name = name;
            this.executable = executable;
            this.copyTo = copyTo;
            this.argument = argument;
        }

        public string Title
        {
            get { return string.Format("Installing {0}", name); }
        }

        public void Execute()
        {
            string filename;
            if (this.copyTo == null)
            {
                filename = Path.GetTempFileName();
            }
            else
            {
                filename = this.copyTo;
                var fileInfo = new FileInfo(filename);
                if (!fileInfo.Directory.Exists)
                {
                    fileInfo.Directory.Create();
                }
            }
            
            try
            {
                File.WriteAllBytes(filename, executable);

                var psi = new ProcessStartInfo(filename, argument)
                {
                    UseShellExecute = false
                };

                Process process = new Process();
                process.StartInfo = psi;
                process.Start();
                if (!process.WaitForExit(10000))
                    throw new StepException("Install process timed out: 10 seconds");

                if (process.ExitCode != 0)
                    throw new StepException("Install process failed with exit code: " + process.ExitCode);
            }
            finally
            {
                if (this.copyTo == null)
                    File.Delete(filename);
            }
        }
    }
}
