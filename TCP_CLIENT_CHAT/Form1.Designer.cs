
namespace TCP_CLIENT_CHAT {
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
            this.btnConnetti = new System.Windows.Forms.Button();
            this.tbNameClient = new System.Windows.Forms.TextBox();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.p1 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl1 = new System.Windows.Forms.Label();
            this.pChat = new System.Windows.Forms.Panel();
            this.lbChat = new System.Windows.Forms.ListBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.p1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pChat.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnetti
            // 
            this.btnConnetti.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConnetti.BackgroundImage")));
            this.btnConnetti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConnetti.FlatAppearance.BorderSize = 0;
            this.btnConnetti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnetti.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnetti.ForeColor = System.Drawing.Color.White;
            this.btnConnetti.Location = new System.Drawing.Point(10, 151);
            this.btnConnetti.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConnetti.Name = "btnConnetti";
            this.btnConnetti.Size = new System.Drawing.Size(159, 121);
            this.btnConnetti.TabIndex = 2;
            this.btnConnetti.Text = "Connetti";
            this.btnConnetti.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConnetti.UseVisualStyleBackColor = true;
            this.btnConnetti.Click += new System.EventHandler(this.btnConnetti_Click);
            // 
            // tbNameClient
            // 
            this.tbNameClient.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNameClient.Location = new System.Drawing.Point(16, 118);
            this.tbNameClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNameClient.MaxLength = 16;
            this.tbNameClient.Name = "tbNameClient";
            this.tbNameClient.Size = new System.Drawing.Size(149, 24);
            this.tbNameClient.TabIndex = 1;
            this.tbNameClient.Text = "Nome Client";
            this.tbNameClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNameClient.Click += new System.EventHandler(this.tbNameClient_Click);
            // 
            // tbIP
            // 
            this.tbIP.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIP.Location = new System.Drawing.Point(16, 90);
            this.tbIP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(149, 24);
            this.tbIP.TabIndex = 0;
            this.tbIP.Text = "Indirizzo IP";
            this.tbIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbIP.Click += new System.EventHandler(this.tbIP_Click);
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p1.Controls.Add(this.panel1);
            this.p1.Controls.Add(this.tbIP);
            this.p1.Controls.Add(this.btnConnetti);
            this.p1.Controls.Add(this.tbNameClient);
            this.p1.Location = new System.Drawing.Point(-1, 0);
            this.p1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(177, 294);
            this.p1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 65);
            this.panel1.TabIndex = 8;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(41, 19);
            this.lbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(93, 26);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "CLIENT";
            // 
            // pChat
            // 
            this.pChat.Controls.Add(this.lbChat);
            this.pChat.Controls.Add(this.btnSendMessage);
            this.pChat.Controls.Add(this.tbMessage);
            this.pChat.Location = new System.Drawing.Point(182, 12);
            this.pChat.Name = "pChat";
            this.pChat.Size = new System.Drawing.Size(543, 273);
            this.pChat.TabIndex = 8;
            // 
            // lbChat
            // 
            this.lbChat.BackColor = System.Drawing.Color.Gray;
            this.lbChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChat.FormattingEnabled = true;
            this.lbChat.ItemHeight = 17;
            this.lbChat.Location = new System.Drawing.Point(3, 8);
            this.lbChat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbChat.Name = "lbChat";
            this.lbChat.Size = new System.Drawing.Size(530, 221);
            this.lbChat.TabIndex = 5;
            this.lbChat.TabStop = false;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSendMessage.BackgroundImage")));
            this.btnSendMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSendMessage.FlatAppearance.BorderSize = 0;
            this.btnSendMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendMessage.Location = new System.Drawing.Point(471, 239);
            this.btnSendMessage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(68, 26);
            this.btnSendMessage.TabIndex = 4;
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // tbMessage
            // 
            this.tbMessage.BackColor = System.Drawing.Color.White;
            this.tbMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMessage.Location = new System.Drawing.Point(3, 239);
            this.tbMessage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(471, 26);
            this.tbMessage.TabIndex = 6;
            this.tbMessage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(737, 291);
            this.Controls.Add(this.pChat);
            this.Controls.Add(this.p1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.p1.ResumeLayout(false);
            this.p1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pChat.ResumeLayout(false);
            this.pChat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnetti;
        private System.Windows.Forms.TextBox tbNameClient;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Panel pChat;
        private System.Windows.Forms.ListBox lbChat;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.TextBox tbMessage;
    }
}

