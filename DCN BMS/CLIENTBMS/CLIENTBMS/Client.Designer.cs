
namespace CLIENTBMS
{
    partial class Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.lblIP = new System.Windows.Forms.Label();
            this.lblCIP = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.rtxtReceiver = new System.Windows.Forms.RichTextBox();
            this.rtxtClient = new System.Windows.Forms.RichTextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblReceiverChat = new System.Windows.Forms.Label();
            this.lblClientChat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.BackColor = System.Drawing.Color.Black;
            this.lblIP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIP.ForeColor = System.Drawing.Color.White;
            this.lblIP.Location = new System.Drawing.Point(444, 120);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(16, 22);
            this.lblIP.TabIndex = 34;
            this.lblIP.Text = ".";
            // 
            // lblCIP
            // 
            this.lblCIP.AutoSize = true;
            this.lblCIP.BackColor = System.Drawing.Color.Black;
            this.lblCIP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCIP.ForeColor = System.Drawing.Color.White;
            this.lblCIP.Location = new System.Drawing.Point(226, 120);
            this.lblCIP.Name = "lblCIP";
            this.lblCIP.Size = new System.Drawing.Size(170, 22);
            this.lblCIP.TabIndex = 33;
            this.lblCIP.Text = "Client IP and Port";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Black;
            this.btnSend.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(523, 448);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(98, 62);
            this.btnSend.TabIndex = 32;
            this.btnSend.Text = "Send ";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(144, 448);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(316, 62);
            this.txtMessage.TabIndex = 31;
            // 
            // rtxtReceiver
            // 
            this.rtxtReceiver.Location = new System.Drawing.Point(416, 221);
            this.rtxtReceiver.Name = "rtxtReceiver";
            this.rtxtReceiver.Size = new System.Drawing.Size(183, 198);
            this.rtxtReceiver.TabIndex = 30;
            this.rtxtReceiver.Text = "";
            // 
            // rtxtClient
            // 
            this.rtxtClient.Location = new System.Drawing.Point(179, 221);
            this.rtxtClient.Name = "rtxtClient";
            this.rtxtClient.Size = new System.Drawing.Size(183, 199);
            this.rtxtClient.TabIndex = 29;
            this.rtxtClient.Text = "";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Black;
            this.btnStart.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(179, 65);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(85, 33);
            this.btnStart.TabIndex = 28;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblReceiverChat
            // 
            this.lblReceiverChat.AutoSize = true;
            this.lblReceiverChat.BackColor = System.Drawing.Color.Black;
            this.lblReceiverChat.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiverChat.ForeColor = System.Drawing.Color.White;
            this.lblReceiverChat.Location = new System.Drawing.Point(444, 172);
            this.lblReceiverChat.Name = "lblReceiverChat";
            this.lblReceiverChat.Size = new System.Drawing.Size(139, 22);
            this.lblReceiverChat.TabIndex = 27;
            this.lblReceiverChat.Text = "Receiver Chat";
            // 
            // lblClientChat
            // 
            this.lblClientChat.AutoSize = true;
            this.lblClientChat.BackColor = System.Drawing.Color.Black;
            this.lblClientChat.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientChat.ForeColor = System.Drawing.Color.White;
            this.lblClientChat.Location = new System.Drawing.Point(205, 172);
            this.lblClientChat.Name = "lblClientChat";
            this.lblClientChat.Size = new System.Drawing.Size(111, 22);
            this.lblClientChat.TabIndex = 26;
            this.lblClientChat.Text = "Client Chat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(343, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 62);
            this.label1.TabIndex = 25;
            this.label1.Text = "Client";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(779, 553);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.lblCIP);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.rtxtReceiver);
            this.Controls.Add(this.rtxtClient);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblReceiverChat);
            this.Controls.Add(this.lblClientChat);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblCIP;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.RichTextBox rtxtReceiver;
        private System.Windows.Forms.RichTextBox rtxtClient;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblReceiverChat;
        private System.Windows.Forms.Label lblClientChat;
        private System.Windows.Forms.Label label1;
    }
}

