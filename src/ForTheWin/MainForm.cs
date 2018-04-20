using ForTheWin.Steps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ForTheWin
{
    public partial class MainForm : Form
    {
        public MainForm(DefaultConfig config)
        {
            InitializeComponent();
            header.BindHandleTo(this);
            this.serverHostBox.Text = config.LognitHost;
            this.logFileFormatBox.Text = config.IISLogPath;
        }

        private void installButton_Click(object sender, EventArgs e)
        {
            var logFileFormat = logFileFormatBox.Text;
            var serverHost = serverHostBox.Text;
            var failedTracingDir = failedRequestsLogDir.Text;

            var statuses = new[]{ 
                new StepStatus(new CheckIISLogsPath(logFileFormat)),
                new StepStatus(new CheckIISFailedTracingPath(failedTracingDir)),
                new StepStatus(new CheckServerAccessible(serverHost)),
                new StepStatus(new InstallApp("Snare", Installers.Snare, "/verysilent")),
                new StepStatus(new ConfigureSnare(serverHost)),
                new StepStatus(new InstallApp("Epilog", Installers.Epilog, "/verysilent")),
                new StepStatus(new ConfigureEpilog(serverHost, logFileFormat)),
                new StepStatus(new InstallApp("IISTracing2Syslog", Installers.IISTracing2Syslog, Environment.GetEnvironmentVariable("ProgramFiles") + @"\IISTracing2Syslog\IISTracing2Syslog.exe" , "--install")),
                new StepStatus(new ConfigureIISTracing2Syslog(serverHost, failedTracingDir)),
            };

            for (int i = 0; i < statuses.Length - 1; i++)
                statuses[i].Complete += statuses[i + 1].Start;

            foreach (StepStatus status in statuses)
                PrepareStatus(status);
            installStatus.Controls.Clear();
            installStatus.Controls.AddRange(statuses);

            statuses[0].Start();
            installButton.Text = "Retry";
        }

        private void PrepareStatus(StepStatus status)
        {
            status.Width = this.installStatus.Width;
            status.Dock = DockStyle.Top;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
