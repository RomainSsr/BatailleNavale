namespace batailleNavale
{
    partial class frmConnexion
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
            this.btnStart = new System.Windows.Forms.Button();
            this.tbxLocalPort = new System.Windows.Forms.TextBox();
            this.tbxLocalIp = new System.Windows.Forms.TextBox();
            this.lblIPHost = new System.Windows.Forms.Label();
            this.gbHost = new System.Windows.Forms.GroupBox();
            this.lblServerStatus = new System.Windows.Forms.Label();
            this.lblPortHost = new System.Windows.Forms.Label();
            this.gbClient = new System.Windows.Forms.GroupBox();
            this.lblPortClient = new System.Windows.Forms.Label();
            this.tbxClientIp = new System.Windows.Forms.TextBox();
            this.lblIPClient = new System.Windows.Forms.Label();
            this.tbxClientPort = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.gbHost.SuspendLayout();
            this.gbClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(62, 122);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 39;
            this.btnStart.Text = "Start Server";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbxLocalPort
            // 
            this.tbxLocalPort.Location = new System.Drawing.Point(62, 59);
            this.tbxLocalPort.Name = "tbxLocalPort";
            this.tbxLocalPort.Size = new System.Drawing.Size(100, 20);
            this.tbxLocalPort.TabIndex = 36;
            this.tbxLocalPort.Text = "8911";
            // 
            // tbxLocalIp
            // 
            this.tbxLocalIp.Location = new System.Drawing.Point(62, 19);
            this.tbxLocalIp.Name = "tbxLocalIp";
            this.tbxLocalIp.Size = new System.Drawing.Size(100, 20);
            this.tbxLocalIp.TabIndex = 33;
            this.tbxLocalIp.Text = "10.134.97.131";
            // 
            // lblIPHost
            // 
            this.lblIPHost.AutoSize = true;
            this.lblIPHost.Location = new System.Drawing.Point(39, 22);
            this.lblIPHost.Name = "lblIPHost";
            this.lblIPHost.Size = new System.Drawing.Size(17, 13);
            this.lblIPHost.TabIndex = 32;
            this.lblIPHost.Text = "IP";
            // 
            // gbHost
            // 
            this.gbHost.Controls.Add(this.lblServerStatus);
            this.gbHost.Controls.Add(this.lblPortHost);
            this.gbHost.Controls.Add(this.tbxLocalIp);
            this.gbHost.Controls.Add(this.lblIPHost);
            this.gbHost.Controls.Add(this.tbxLocalPort);
            this.gbHost.Controls.Add(this.btnStart);
            this.gbHost.Location = new System.Drawing.Point(12, 12);
            this.gbHost.Name = "gbHost";
            this.gbHost.Size = new System.Drawing.Size(200, 151);
            this.gbHost.TabIndex = 44;
            this.gbHost.TabStop = false;
            this.gbHost.Text = "Host";
            // 
            // lblServerStatus
            // 
            this.lblServerStatus.AutoSize = true;
            this.lblServerStatus.Location = new System.Drawing.Point(62, 96);
            this.lblServerStatus.Name = "lblServerStatus";
            this.lblServerStatus.Size = new System.Drawing.Size(104, 13);
            this.lblServerStatus.TabIndex = 42;
            this.lblServerStatus.Text = "Server unconnected";
            // 
            // lblPortHost
            // 
            this.lblPortHost.AutoSize = true;
            this.lblPortHost.Location = new System.Drawing.Point(30, 62);
            this.lblPortHost.Name = "lblPortHost";
            this.lblPortHost.Size = new System.Drawing.Size(26, 13);
            this.lblPortHost.TabIndex = 41;
            this.lblPortHost.Text = "Port";
            // 
            // gbClient
            // 
            this.gbClient.Controls.Add(this.lblPortClient);
            this.gbClient.Controls.Add(this.tbxClientIp);
            this.gbClient.Controls.Add(this.lblIPClient);
            this.gbClient.Controls.Add(this.tbxClientPort);
            this.gbClient.Controls.Add(this.btnConnect);
            this.gbClient.Location = new System.Drawing.Point(218, 12);
            this.gbClient.Name = "gbClient";
            this.gbClient.Size = new System.Drawing.Size(200, 151);
            this.gbClient.TabIndex = 45;
            this.gbClient.TabStop = false;
            this.gbClient.Text = "Client";
            // 
            // lblPortClient
            // 
            this.lblPortClient.AutoSize = true;
            this.lblPortClient.Location = new System.Drawing.Point(30, 62);
            this.lblPortClient.Name = "lblPortClient";
            this.lblPortClient.Size = new System.Drawing.Size(26, 13);
            this.lblPortClient.TabIndex = 41;
            this.lblPortClient.Text = "Port";
            // 
            // tbxClientIp
            // 
            this.tbxClientIp.Location = new System.Drawing.Point(62, 19);
            this.tbxClientIp.Name = "tbxClientIp";
            this.tbxClientIp.Size = new System.Drawing.Size(100, 20);
            this.tbxClientIp.TabIndex = 33;
            this.tbxClientIp.Text = "10.134.99.131";
            // 
            // lblIPClient
            // 
            this.lblIPClient.AutoSize = true;
            this.lblIPClient.Location = new System.Drawing.Point(39, 22);
            this.lblIPClient.Name = "lblIPClient";
            this.lblIPClient.Size = new System.Drawing.Size(17, 13);
            this.lblIPClient.TabIndex = 32;
            this.lblIPClient.Text = "IP";
            // 
            // tbxClientPort
            // 
            this.tbxClientPort.Location = new System.Drawing.Point(62, 59);
            this.tbxClientPort.Name = "tbxClientPort";
            this.tbxClientPort.Size = new System.Drawing.Size(100, 20);
            this.tbxClientPort.TabIndex = 36;
            this.tbxClientPort.Text = "8910";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(62, 122);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 40;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // frmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 189);
            this.Controls.Add(this.gbClient);
            this.Controls.Add(this.gbHost);
            this.Name = "frmConnexion";
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.Connexion_Load);
            this.gbHost.ResumeLayout(false);
            this.gbHost.PerformLayout();
            this.gbClient.ResumeLayout(false);
            this.gbClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbxLocalPort;
        private System.Windows.Forms.TextBox tbxLocalIp;
        private System.Windows.Forms.Label lblIPHost;
        private System.Windows.Forms.GroupBox gbHost;
        private System.Windows.Forms.Label lblPortHost;
        private System.Windows.Forms.GroupBox gbClient;
        private System.Windows.Forms.Label lblPortClient;
        private System.Windows.Forms.TextBox tbxClientIp;
        private System.Windows.Forms.Label lblIPClient;
        private System.Windows.Forms.TextBox tbxClientPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblServerStatus;
    }
}