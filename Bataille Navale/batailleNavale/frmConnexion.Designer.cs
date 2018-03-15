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
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbxLocalPort = new System.Windows.Forms.TextBox();
            this.tbxLocalIp = new System.Windows.Forms.TextBox();
            this.lblIPHost = new System.Windows.Forms.Label();
            this.gbHost = new System.Windows.Forms.GroupBox();
            this.lblServerStatus = new System.Windows.Forms.Label();
            this.lblPortHost = new System.Windows.Forms.Label();
            this.gbClient = new System.Windows.Forms.GroupBox();
            this.lblClientInfo = new System.Windows.Forms.Label();
            this.btnStopListen = new System.Windows.Forms.Button();
            this.btnStartListen = new System.Windows.Forms.Button();
            this.lsbAvaiableServers = new System.Windows.Forms.ListBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tmrBroadcastIp = new System.Windows.Forms.Timer(this.components);
            this.lblError = new System.Windows.Forms.Label();
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
            this.tbxLocalPort.ReadOnly = true;
            this.tbxLocalPort.Size = new System.Drawing.Size(100, 20);
            this.tbxLocalPort.TabIndex = 36;
            // 
            // tbxLocalIp
            // 
            this.tbxLocalIp.Location = new System.Drawing.Point(62, 19);
            this.tbxLocalIp.Name = "tbxLocalIp";
            this.tbxLocalIp.ReadOnly = true;
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
            this.gbHost.Size = new System.Drawing.Size(200, 207);
            this.gbHost.TabIndex = 44;
            this.gbHost.TabStop = false;
            this.gbHost.Text = "Host";
            // 
            // lblServerStatus
            // 
            this.lblServerStatus.AutoSize = true;
            this.lblServerStatus.Location = new System.Drawing.Point(48, 96);
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
            this.gbClient.Controls.Add(this.lblClientInfo);
            this.gbClient.Controls.Add(this.btnStopListen);
            this.gbClient.Controls.Add(this.btnStartListen);
            this.gbClient.Controls.Add(this.lsbAvaiableServers);
            this.gbClient.Controls.Add(this.btnConnect);
            this.gbClient.Location = new System.Drawing.Point(218, 12);
            this.gbClient.Name = "gbClient";
            this.gbClient.Size = new System.Drawing.Size(200, 207);
            this.gbClient.TabIndex = 45;
            this.gbClient.TabStop = false;
            this.gbClient.Text = "Client";
            // 
            // lblClientInfo
            // 
            this.lblClientInfo.AutoSize = true;
            this.lblClientInfo.Location = new System.Drawing.Point(6, 185);
            this.lblClientInfo.Name = "lblClientInfo";
            this.lblClientInfo.Size = new System.Drawing.Size(25, 13);
            this.lblClientInfo.TabIndex = 47;
            this.lblClientInfo.Text = "Info";
            // 
            // btnStopListen
            // 
            this.btnStopListen.Location = new System.Drawing.Point(105, 21);
            this.btnStopListen.Name = "btnStopListen";
            this.btnStopListen.Size = new System.Drawing.Size(75, 23);
            this.btnStopListen.TabIndex = 43;
            this.btnStopListen.Text = "Stop";
            this.btnStopListen.UseVisualStyleBackColor = true;
            this.btnStopListen.Click += new System.EventHandler(this.btnStopListen_Click);
            // 
            // btnStartListen
            // 
            this.btnStartListen.Location = new System.Drawing.Point(26, 21);
            this.btnStartListen.Name = "btnStartListen";
            this.btnStartListen.Size = new System.Drawing.Size(75, 23);
            this.btnStartListen.TabIndex = 42;
            this.btnStartListen.Text = "Listen";
            this.btnStartListen.UseVisualStyleBackColor = true;
            this.btnStartListen.Click += new System.EventHandler(this.btnStartListen_Click);
            // 
            // lsbAvaiableServers
            // 
            this.lsbAvaiableServers.FormattingEnabled = true;
            this.lsbAvaiableServers.Location = new System.Drawing.Point(26, 50);
            this.lsbAvaiableServers.Name = "lsbAvaiableServers";
            this.lsbAvaiableServers.Size = new System.Drawing.Size(154, 95);
            this.lsbAvaiableServers.TabIndex = 41;
            this.lsbAvaiableServers.SelectedIndexChanged += new System.EventHandler(this.lsbAvaiableServers_SelectedIndexChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Enabled = false;
            this.btnConnect.Location = new System.Drawing.Point(26, 151);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(154, 23);
            this.btnConnect.TabIndex = 40;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tmrBroadcastIp
            // 
            this.tmrBroadcastIp.Interval = 500;
            this.tmrBroadcastIp.Tick += new System.EventHandler(this.tmrBroadcastIp_Tick);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(12, 232);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(35, 13);
            this.lblError.TabIndex = 46;
            this.lblError.Text = "label1";
            // 
            // frmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 254);
            this.Controls.Add(this.lblError);
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
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbxLocalPort;
        private System.Windows.Forms.TextBox tbxLocalIp;
        private System.Windows.Forms.Label lblIPHost;
        private System.Windows.Forms.GroupBox gbHost;
        private System.Windows.Forms.Label lblPortHost;
        private System.Windows.Forms.GroupBox gbClient;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblServerStatus;
        private System.Windows.Forms.Timer tmrBroadcastIp;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.ListBox lsbAvaiableServers;
        private System.Windows.Forms.Button btnStopListen;
        private System.Windows.Forms.Button btnStartListen;
        private System.Windows.Forms.Label lblClientInfo;
    }
}