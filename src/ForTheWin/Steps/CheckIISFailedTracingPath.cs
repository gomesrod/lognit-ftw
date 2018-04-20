using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ForTheWin.Steps
{
    public class CheckIISFailedTracingPath : IStep
    {
        readonly string path;
        
        public CheckIISFailedTracingPath(string path)
        {
            this.path = path;
        }

        public void Execute()
        {
            var directory = new DirectoryInfo(path);

            if (!directory.Exists)
                throw new StepException(string.Format("Could not find directory '{0}'. Usually indicates that the configuration is incorrect. If you dont use IIS Failed Requests Tracing, ignore this and later disable the agent service", directory));
        }

        public string Title
        {
            get { return "Checking IIS Failed Requests Tracing directory"; }
        }
    }
}
