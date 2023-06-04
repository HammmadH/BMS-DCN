
namespace Bank_Management_System
{
    partial class SERVER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SERVER));
            this.btnfiletran = new System.Windows.Forms.Button();
            this.btnMail = new System.Windows.Forms.Button();
            this.btnSendToAll = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.rtxtReceiver = new System.Windows.Forms.RichTextBox();
            this.rtxtServer = new System.Windows.Forms.RichTextBox();
            this.btnSendTo = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblReceiverChat = new System.Windows.Forms.Label();
            this.lblServerChat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnfiletran
            // 
            this.btnfiletran.BackColor = System.Drawing.Color.Black;
            this.btnfiletran.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfiletran.ForeColor = System.Drawing.Color.White;
            this.btnfiletran.Location = new System.Drawing.Point(319, 157);
            this.btnfiletran.Name = "btnfiletran";
            this.btnfiletran.Size = new System.Drawing.Size(181, 33);
            this.btnfiletran.TabIndex = 25;
            this.btnfiletran.Text = "File Transfer";
            this.btnfiletran.UseVisualStyleBackColor = false;
            // 
            // btnMail
            // 
            this.btnMail.BackColor = System.Drawing.Color.Black;
            this.btnMail.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMail.ForeColor = System.Drawing.Color.White;
            this.btnMail.Location = new System.Drawing.Point(541, 46);
            this.btnMail.Name = "btnMail";
            this.btnMail.Size = new System.Drawing.Size(85, 33);
            this.btnMail.TabIndex = 24;
            this.btnMail.Text = "Mail";
            this.btnMail.UseVisualStyleBackColor = false;
            this.btnMail.Click += new System.EventHandler(this.btnMail_Click);
            // 
            // btnSendToAll
            // 
            this.btnSendToAll.BackColor = System.Drawing.Color.Black;
            this.btnSendToAll.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendToAll.ForeColor = System.Drawing.Color.White;
            this.btnSendToAll.Location = new System.Drawing.Point(528, 480);
            this.btnSendToAll.Name = "btnSendToAll";
            this.btnSendToAll.Size = new System.Drawing.Size(98, 62);
            this.btnSendToAll.TabIndex = 23;
            this.btnSendToAll.Text = "Send To All";
            this.btnSendToAll.UseVisualStyleBackColor = false;
            this.btnSendToAll.Click += new System.EventHandler(this.btnSendToAll_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(206, 480);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(316, 62);
            this.txtMessage.TabIndex = 22;
            // 
            // rtxtReceiver
            // 
            this.rtxtReceiver.Location = new System.Drawing.Point(443, 257);
            this.rtxtReceiver.Name = "rtxtReceiver";
            this.rtxtReceiver.Size = new System.Drawing.Size(183, 198);
            this.rtxtReceiver.TabIndex = 21;
            this.rtxtReceiver.Text = "";
            // 
            // rtxtServer
            // 
            this.rtxtServer.Location = new System.Drawing.Point(206, 257);
            this.rtxtServer.Name = "rtxtServer";
            this.rtxtServer.Size = new System.Drawing.Size(183, 199);
            this.rtxtServer.TabIndex = 20;
            this.rtxtServer.Text = "";
            // 
            // btnSendTo
            // 
            this.btnSendTo.BackColor = System.Drawing.Color.Black;
            this.btnSendTo.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendTo.ForeColor = System.Drawing.Color.White;
            this.btnSendTo.Location = new System.Drawing.Point(274, 102);
            this.btnSendTo.Name = "btnSendTo";
            this.btnSendTo.Size = new System.Drawing.Size(115, 33);
            this.btnSendTo.TabIndex = 19;
            this.btnSendTo.Text = "Send To:";
            this.btnSendTo.UseVisualStyleBackColor = false;
            this.btnSendTo.Click += new System.EventHandler(this.btnSendTo_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Black;
            this.btnStart.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(206, 46);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(85, 33);
            this.btnStart.TabIndex = 18;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(415, 110);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // lblReceiverChat
            // 
            this.lblReceiverChat.AutoSize = true;
            this.lblReceiverChat.BackColor = System.Drawing.Color.Black;
            this.lblReceiverChat.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiverChat.ForeColor = System.Drawing.Color.White;
            this.lblReceiverChat.Location = new System.Drawing.Point(471, 210);
            this.lblReceiverChat.Name = "lblReceiverChat";
            this.lblReceiverChat.Size = new System.Drawing.Size(139, 22);
            this.lblReceiverChat.TabIndex = 16;
            this.lblReceiverChat.Text = "Receiver Chat";
            // 
            // lblServerChat
            // 
            this.lblServerChat.AutoSize = true;
            this.lblServerChat.BackColor = System.Drawing.Color.Black;
            this.lblServerChat.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerChat.ForeColor = System.Drawing.Color.White;
            this.lblServerChat.Location = new System.Drawing.Point(232, 210);
            this.lblServerChat.Name = "lblServerChat";
            this.lblServerChat.Size = new System.Drawing.Size(119, 22);
            this.lblServerChat.TabIndex = 15;
            this.lblServerChat.Text = "Server Chat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(335, -5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 62);
            this.label1.TabIndex = 14;
            this.label1.Text = "Server";
            // 
            // SERVER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(832, 564);
            this.Controls.Add(this.btnfiletran);
            this.Controls.Add(this.btnMail);
            this.Controls.Add(this.btnSendToAll);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.rtxtReceiver);
            this.Controls.Add(this.rtxtServer);
            this.Controls.Add(this.btnSendTo);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblReceiverChat);
            this.Controls.Add(this.lblServerChat);
            this.Controls.Add(this.label1);
            this.Name = "SERVER";
            this.Text = "SERVER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnfiletran;
        private System.Windows.Forms.Button btnMail;
        private System.Windows.Forms.Button btnSendToAll;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.RichTextBox rtxtReceiver;
        private System.Windows.Forms.RichTextBox rtxtServer;
        private System.Windows.Forms.Button btnSendTo;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblReceiverChat;
        private System.Windows.Forms.Label lblServerChat;
        private System.Windows.Forms.Label label1;
    }
}