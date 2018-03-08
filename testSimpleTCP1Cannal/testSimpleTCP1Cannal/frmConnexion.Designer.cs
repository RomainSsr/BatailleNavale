namespace testSimpleTCP1Cannal
{
    partial class frmConnexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbServer = new System.Windows.Forms.GroupBox();
            this.lblServerState = new System.Windows.Forms.Label();
            this.btStartSever = new System.Windows.Forms.Button();
            this.lblServerPort = new System.Windows.Forms.Label();
            this.lblIPServer = new System.Windows.Forms.Label();
            this.tbxServerPort = new System.Windows.Forms.TextBox();
            this.tbxServerIP = new System.Windows.Forms.TextBox();
            this.gbClient = new System.Windows.Forms.GroupBox();
            this.cbxAvaiableServers = new System.Windows.Forms.ComboBox();
            this.lblClientState = new System.Windows.Forms.Label();
            this.btnConnectClient = new System.Windows.Forms.Button();
            this.lblClientPort = new System.Windows.Forms.Label();
            this.lblIPClient = new System.Windows.Forms.Label();
            this.tbxClientIP = new System.Windows.Forms.TextBox();
            this.tmrBroadcast = new System.Windows.Forms.Timer(this.components);
            this.gbServer.SuspendLayout();
            this.gbClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbServer
            // 
            this.gbServer.Controls.Add(this.lblServerState);
            this.gbServer.Controls.Add(this.btStartSever);
            this.gbServer.Controls.Add(this.lblServerPort);
            this.gbServer.Controls.Add(this.lblIPServer);
            this.gbServer.Controls.Add(this.tbxServerPort);
            this.gbServer.Controls.Add(this.tbxServerIP);
            this.gbServer.Location = new System.Drawing.Point(12, 12);
            this.gbServer.Name = "gbServer";
            this.gbServer.Size = new System.Drawing.Size(227, 157);
            this.gbServer.TabIndex = 0;
            this.gbServer.TabStop = false;
            this.gbServer.Text = "Serveur";
            // 
            // lblServerState
            // 
            this.lblServerState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerState.Location = new System.Drawing.Point(10, 132);
            this.lblServerState.Name = "lblServerState";
            this.lblServerState.Size = new System.Drawing.Size(209, 23);
            this.lblServerState.TabIndex = 5;
            this.lblServerState.Text = "Serveur non demmaré";
            this.lblServerState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btStartSever
            // 
            this.btStartSever.Location = new System.Drawing.Point(6, 102);
            this.btStartSever.Name = "btStartSever";
            this.btStartSever.Size = new System.Drawing.Size(213, 23);
            this.btStartSever.TabIndex = 4;
            this.btStartSever.Text = "Demmarer le serveur";
            this.btStartSever.UseVisualStyleBackColor = true;
            this.btStartSever.Click += new System.EventHandler(this.btStartSever_Click);
            // 
            // lblServerPort
            // 
            this.lblServerPort.AutoSize = true;
            this.lblServerPort.Location = new System.Drawing.Point(6, 67);
            this.lblServerPort.Name = "lblServerPort";
            this.lblServerPort.Size = new System.Drawing.Size(66, 13);
            this.lblServerPort.TabIndex = 3;
            this.lblServerPort.Text = "Port Serveur";
            // 
            // lblIPServer
            // 
            this.lblIPServer.AutoSize = true;
            this.lblIPServer.Location = new System.Drawing.Point(7, 20);
            this.lblIPServer.Name = "lblIPServer";
            this.lblIPServer.Size = new System.Drawing.Size(57, 13);
            this.lblIPServer.TabIndex = 2;
            this.lblIPServer.Text = "IP Serveur";
            // 
            // tbxServerPort
            // 
            this.tbxServerPort.Location = new System.Drawing.Point(76, 64);
            this.tbxServerPort.Name = "tbxServerPort";
            this.tbxServerPort.Size = new System.Drawing.Size(143, 20);
            this.tbxServerPort.TabIndex = 1;
            this.tbxServerPort.Text = "8090";
            // 
            // tbxServerIP
            // 
            this.tbxServerIP.Location = new System.Drawing.Point(76, 19);
            this.tbxServerIP.Name = "tbxServerIP";
            this.tbxServerIP.Size = new System.Drawing.Size(143, 20);
            this.tbxServerIP.TabIndex = 0;
            // 
            // gbClient
            // 
            this.gbClient.Controls.Add(this.cbxAvaiableServers);
            this.gbClient.Controls.Add(this.lblClientState);
            this.gbClient.Controls.Add(this.btnConnectClient);
            this.gbClient.Controls.Add(this.lblClientPort);
            this.gbClient.Controls.Add(this.lblIPClient);
            this.gbClient.Controls.Add(this.tbxClientIP);
            this.gbClient.Location = new System.Drawing.Point(249, 12);
            this.gbClient.Name = "gbClient";
            this.gbClient.Size = new System.Drawing.Size(320, 157);
            this.gbClient.TabIndex = 6;
            this.gbClient.TabStop = false;
            this.gbClient.Text = "Client";
            // 
            // cbxAvaiableServers
            // 
            this.cbxAvaiableServers.FormattingEnabled = true;
            this.cbxAvaiableServers.Location = new System.Drawing.Point(162, 67);
            this.cbxAvaiableServers.Name = "cbxAvaiableServers";
            this.cbxAvaiableServers.Size = new System.Drawing.Size(151, 21);
            this.cbxAvaiableServers.TabIndex = 6;
            // 
            // lblClientState
            // 
            this.lblClientState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientState.Location = new System.Drawing.Point(3, 131);
            this.lblClientState.Name = "lblClientState";
            this.lblClientState.Size = new System.Drawing.Size(315, 23);
            this.lblClientState.TabIndex = 5;
            this.lblClientState.Text = "Client non connecté";
            this.lblClientState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConnectClient
            // 
            this.btnConnectClient.Location = new System.Drawing.Point(6, 102);
            this.btnConnectClient.Name = "btnConnectClient";
            this.btnConnectClient.Size = new System.Drawing.Size(307, 23);
            this.btnConnectClient.TabIndex = 4;
            this.btnConnectClient.Text = "Se connecter";
            this.btnConnectClient.UseVisualStyleBackColor = true;
            // 
            // lblClientPort
            // 
            this.lblClientPort.AutoSize = true;
            this.lblClientPort.Location = new System.Drawing.Point(7, 67);
            this.lblClientPort.Name = "lblClientPort";
            this.lblClientPort.Size = new System.Drawing.Size(104, 13);
            this.lblClientPort.TabIndex = 3;
            this.lblClientPort.Text = "Serveurs disponibles";
            // 
            // lblIPClient
            // 
            this.lblIPClient.AutoSize = true;
            this.lblIPClient.Location = new System.Drawing.Point(7, 20);
            this.lblIPClient.Name = "lblIPClient";
            this.lblIPClient.Size = new System.Drawing.Size(46, 13);
            this.lblIPClient.TabIndex = 2;
            this.lblIPClient.Text = "IP Client";
            // 
            // tbxClientIP
            // 
            this.tbxClientIP.Location = new System.Drawing.Point(162, 19);
            this.tbxClientIP.Name = "tbxClientIP";
            this.tbxClientIP.Size = new System.Drawing.Size(151, 20);
            this.tbxClientIP.TabIndex = 0;
            // 
            // tmrBroadcast
            // 
            this.tmrBroadcast.Enabled = true;
            this.tmrBroadcast.Tick += new System.EventHandler(this.tmrBroadcast_Tick);
            // 
            // frmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 209);
            this.Controls.Add(this.gbClient);
            this.Controls.Add(this.gbServer);
            this.Name = "frmConnexion";
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.frmConnexion_Load);
            this.gbServer.ResumeLayout(false);
            this.gbServer.PerformLayout();
            this.gbClient.ResumeLayout(false);
            this.gbClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbServer;
        private System.Windows.Forms.Label lblServerState;
        private System.Windows.Forms.Button btStartSever;
        private System.Windows.Forms.Label lblServerPort;
        private System.Windows.Forms.Label lblIPServer;
        private System.Windows.Forms.TextBox tbxServerPort;
        private System.Windows.Forms.TextBox tbxServerIP;
        private System.Windows.Forms.GroupBox gbClient;
        private System.Windows.Forms.Label lblClientState;
        private System.Windows.Forms.Button btnConnectClient;
        private System.Windows.Forms.Label lblClientPort;
        private System.Windows.Forms.Label lblIPClient;
        private System.Windows.Forms.TextBox tbxClientIP;
        private System.Windows.Forms.ComboBox cbxAvaiableServers;
        private System.Windows.Forms.Timer tmrBroadcast;
    }
}

