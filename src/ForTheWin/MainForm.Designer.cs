namespace ForTheWin
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.installButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.serverHostBox = new System.Windows.Forms.TextBox();
            this.logFileFormatBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.installStatus = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.header = new ForTheWin.HeaderBar();
            this.label4 = new System.Windows.Forms.Label();
            this.failedRequestsLogDir = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // installButton
            // 
            this.installButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.installButton.FlatAppearance.BorderSize = 0;
            this.installButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.installButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installButton.Image = ((System.Drawing.Image)(resources.GetObject("installButton.Image")));
            this.installButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.installButton.Location = new System.Drawing.Point(248, 250);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(91, 53);
            this.installButton.TabIndex = 1;
            this.installButton.Text = "Install";
            this.installButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.installButton.UseVisualStyleBackColor = true;
            this.installButton.Click += new System.EventHandler(this.installButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "This utility will install Snare, Epilog and IISTracing collectors pointing to a L" +
    "ognit instance.";
            // 
            // serverHostBox
            // 
            this.serverHostBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverHostBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serverHostBox.Location = new System.Drawing.Point(19, 114);
            this.serverHostBox.Name = "serverHostBox";
            this.serverHostBox.Size = new System.Drawing.Size(417, 20);
            this.serverHostBox.TabIndex = 4;
            this.serverHostBox.Text = "localhost:5140";
            // 
            // logFileFormatBox
            // 
            this.logFileFormatBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logFileFormatBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logFileFormatBox.Location = new System.Drawing.Point(19, 165);
            this.logFileFormatBox.Name = "logFileFormatBox";
            this.logFileFormatBox.Size = new System.Drawing.Size(417, 20);
            this.logFileFormatBox.TabIndex = 5;
            this.logFileFormatBox.Text = "C:\\inetpub\\logs\\LogFiles\\W3SVC1\\u_ex%.log";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lognit syslog host and port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "IIS log file (use % for YYMMDD):";
            // 
            // installStatus
            // 
            this.installStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.installStatus.AutoSize = true;
            this.installStatus.BackColor = System.Drawing.Color.DimGray;
            this.installStatus.Location = new System.Drawing.Point(19, 244);
            this.installStatus.Name = "installStatus";
            this.installStatus.Size = new System.Drawing.Size(417, 0);
            this.installStatus.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.failedRequestsLogDir);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.logFileFormatBox);
            this.panel1.Controls.Add(this.installStatus);
            this.panel1.Controls.Add(this.installButton);
            this.panel1.Controls.Add(this.header);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.serverHostBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 316);
            this.panel1.TabIndex = 9;

            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.closeButton.Location = new System.Drawing.Point(345, 250);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(91, 53);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "Close";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.Silver;
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(451, 52);
            this.header.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "IIS Failed Requests Tracing directory:";
            // 
            // failedRequestsLogDir
            // 
            this.failedRequestsLogDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.failedRequestsLogDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.failedRequestsLogDir.Location = new System.Drawing.Point(19, 218);
            this.failedRequestsLogDir.Name = "failedRequestsLogDir";
            this.failedRequestsLogDir.Size = new System.Drawing.Size(417, 20);
            this.failedRequestsLogDir.TabIndex = 11;
            this.failedRequestsLogDir.Text = "C:\\inetpub\\logs\\FailedReqLogFiles\\W3SVC1";
            // 
            // MainForm
            // 
            this.AcceptButton = this.installButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(453, 316);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lognit for the Win";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button installButton;
        private System.Windows.Forms.Label label1;
        private HeaderBar header;
        private System.Windows.Forms.TextBox serverHostBox;
        private System.Windows.Forms.TextBox logFileFormatBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel installStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox failedRequestsLogDir;
    }
}