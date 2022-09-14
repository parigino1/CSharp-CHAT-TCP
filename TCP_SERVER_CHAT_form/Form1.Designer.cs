
namespace TCP_SERVER_CHAT_form {
    partial class Form1 {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStartServer = new System.Windows.Forms.Button();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.lbClient = new System.Windows.Forms.ListBox();
            this.cbIP = new System.Windows.Forms.ComboBox();
            this.p1 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl1 = new System.Windows.Forms.Label();
            this.p1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartServer
            // 
            this.btnStartServer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStartServer.BackgroundImage")));
            this.btnStartServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStartServer.FlatAppearance.BorderSize = 0;
            this.btnStartServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartServer.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartServer.ForeColor = System.Drawing.Color.White;
            this.btnStartServer.Location = new System.Drawing.Point(11, 101);
            this.btnStartServer.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(154, 178);
            this.btnStartServer.TabIndex = 0;
            this.btnStartServer.Text = "Avvia Server";
            this.btnStartServer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // lbLog
            // 
            this.lbLog.BackColor = System.Drawing.Color.Gray;
            this.lbLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLog.FormattingEnabled = true;
            this.lbLog.ItemHeight = 15;
            this.lbLog.Location = new System.Drawing.Point(186, 29);
            this.lbLog.Margin = new System.Windows.Forms.Padding(2);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(434, 240);
            this.lbLog.TabIndex = 1;
            // 
            // lbClient
            // 
            this.lbClient.BackColor = System.Drawing.Color.Gray;
            this.lbClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClient.FormattingEnabled = true;
            this.lbClient.ItemHeight = 15;
            this.lbClient.Location = new System.Drawing.Point(630, 29);
            this.lbClient.Margin = new System.Windows.Forms.Padding(2);
            this.lbClient.Name = "lbClient";
            this.lbClient.Size = new System.Drawing.Size(211, 240);
            this.lbClient.TabIndex = 2;
            // 
            // cbIP
            // 
            this.cbIP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbIP.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIP.FormattingEnabled = true;
            this.cbIP.Location = new System.Drawing.Point(11, 72);
            this.cbIP.Name = "cbIP";
            this.cbIP.Size = new System.Drawing.Size(154, 24);
            this.cbIP.TabIndex = 3;
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p1.Controls.Add(this.panel1);
            this.p1.Controls.Add(this.cbIP);
            this.p1.Controls.Add(this.btnStartServer);
            this.p1.Location = new System.Drawing.Point(0, 1);
            this.p1.Margin = new System.Windows.Forms.Padding(2);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(177, 290);
            this.p1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 65);
            this.panel1.TabIndex = 8;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(35, 19);
            this.lbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(100, 26);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "SERVER";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(852, 291);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.lbClient);
            this.Controls.Add(this.lbLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.p1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartServer;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.ListBox lbClient;
        private System.Windows.Forms.ComboBox cbIP;
        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl1;
    }
}

