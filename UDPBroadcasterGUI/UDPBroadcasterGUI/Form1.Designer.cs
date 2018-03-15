namespace UDPBroadcasterGUI
{
    partial class Form1
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
            this.tbxTextToSend = new System.Windows.Forms.TextBox();
            this.lblTextToSend = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblNotification = new System.Windows.Forms.Label();
            this.lsbNotification = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tbxTextToSend
            // 
            this.tbxTextToSend.Location = new System.Drawing.Point(12, 35);
            this.tbxTextToSend.Name = "tbxTextToSend";
            this.tbxTextToSend.Size = new System.Drawing.Size(120, 20);
            this.tbxTextToSend.TabIndex = 0;
            // 
            // lblTextToSend
            // 
            this.lblTextToSend.AutoSize = true;
            this.lblTextToSend.Location = new System.Drawing.Point(13, 13);
            this.lblTextToSend.Name = "lblTextToSend";
            this.lblTextToSend.Size = new System.Drawing.Size(84, 13);
            this.lblTextToSend.TabIndex = 1;
            this.lblTextToSend.Text = "Texte à envoyer";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(139, 32);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Envoyer";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblNotification
            // 
            this.lblNotification.AutoSize = true;
            this.lblNotification.Location = new System.Drawing.Point(9, 68);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(65, 13);
            this.lblNotification.TabIndex = 3;
            this.lblNotification.Text = "Notifications";
            // 
            // lsbNotification
            // 
            this.lsbNotification.FormattingEnabled = true;
            this.lsbNotification.Location = new System.Drawing.Point(12, 94);
            this.lsbNotification.Name = "lsbNotification";
            this.lsbNotification.Size = new System.Drawing.Size(120, 147);
            this.lsbNotification.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 280);
            this.Controls.Add(this.lsbNotification);
            this.Controls.Add(this.lblNotification);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblTextToSend);
            this.Controls.Add(this.tbxTextToSend);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxTextToSend;
        private System.Windows.Forms.Label lblTextToSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblNotification;
        private System.Windows.Forms.ListBox lsbNotification;
        private System.Windows.Forms.Timer timer1;
    }
}

