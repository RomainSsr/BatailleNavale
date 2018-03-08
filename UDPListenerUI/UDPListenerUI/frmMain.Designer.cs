namespace UDPListenerUI
{
    partial class frmMain
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
            this.lblListenerStatus = new System.Windows.Forms.Label();
            this.lsbServerDispo = new System.Windows.Forms.ListBox();
            this.btnStartListener = new System.Windows.Forms.Button();
            this.tmrNetworkDicovery = new System.Windows.Forms.Timer(this.components);
            this.btnStopListener = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEmpty = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblListenerStatus
            // 
            this.lblListenerStatus.AutoSize = true;
            this.lblListenerStatus.Location = new System.Drawing.Point(9, 8);
            this.lblListenerStatus.Name = "lblListenerStatus";
            this.lblListenerStatus.Size = new System.Drawing.Size(95, 13);
            this.lblListenerStatus.TabIndex = 0;
            this.lblListenerStatus.Text = "Listener Désactivé";
            // 
            // lsbServerDispo
            // 
            this.lsbServerDispo.FormattingEnabled = true;
            this.lsbServerDispo.Location = new System.Drawing.Point(12, 33);
            this.lsbServerDispo.Name = "lsbServerDispo";
            this.lsbServerDispo.Size = new System.Drawing.Size(249, 173);
            this.lsbServerDispo.TabIndex = 1;
            // 
            // btnStartListener
            // 
            this.btnStartListener.Location = new System.Drawing.Point(105, 3);
            this.btnStartListener.Name = "btnStartListener";
            this.btnStartListener.Size = new System.Drawing.Size(75, 23);
            this.btnStartListener.TabIndex = 2;
            this.btnStartListener.Text = "Start";
            this.btnStartListener.UseVisualStyleBackColor = true;
            this.btnStartListener.Click += new System.EventHandler(this.btnStartListener_Click);
            // 
            // tmrNetworkDicovery
            // 
            this.tmrNetworkDicovery.Tick += new System.EventHandler(this.tmrNetworkDicovery_Tick);
            // 
            // btnStopListener
            // 
            this.btnStopListener.Location = new System.Drawing.Point(186, 3);
            this.btnStopListener.Name = "btnStopListener";
            this.btnStopListener.Size = new System.Drawing.Size(75, 23);
            this.btnStopListener.TabIndex = 3;
            this.btnStopListener.Text = "Stop";
            this.btnStopListener.UseVisualStyleBackColor = true;
            this.btnStopListener.Click += new System.EventHandler(this.btnStopListener_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // btnEmpty
            // 
            this.btnEmpty.Location = new System.Drawing.Point(186, 208);
            this.btnEmpty.Name = "btnEmpty";
            this.btnEmpty.Size = new System.Drawing.Size(75, 23);
            this.btnEmpty.TabIndex = 5;
            this.btnEmpty.Text = "Vider";
            this.btnEmpty.UseVisualStyleBackColor = true;
            this.btnEmpty.Click += new System.EventHandler(this.btnEmpty_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 240);
            this.Controls.Add(this.btnEmpty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStopListener);
            this.Controls.Add(this.btnStartListener);
            this.Controls.Add(this.lsbServerDispo);
            this.Controls.Add(this.lblListenerStatus);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListenerStatus;
        private System.Windows.Forms.ListBox lsbServerDispo;
        private System.Windows.Forms.Button btnStartListener;
        private System.Windows.Forms.Timer tmrNetworkDicovery;
        private System.Windows.Forms.Button btnStopListener;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEmpty;
    }
}

