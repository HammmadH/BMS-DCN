
namespace Bank_Management_System
{
    partial class Gmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gmail));
            this.txtAttach = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.RtxtMail = new System.Windows.Forms.RichTextBox();
            this.txtSub = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.lblAttach = new System.Windows.Forms.Label();
            this.lblMailMess = new System.Windows.Forms.Label();
            this.lblMailSub = new System.Windows.Forms.Label();
            this.lblMailTo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAttach
            // 
            this.txtAttach.Location = new System.Drawing.Point(257, 341);
            this.txtAttach.Name = "txtAttach";
            this.txtAttach.Size = new System.Drawing.Size(171, 20);
            this.txtAttach.TabIndex = 29;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Black;
            this.btnSend.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(454, 391);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(76, 33);
            this.btnSend.TabIndex = 28;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(353, 391);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 33);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // RtxtMail
            // 
            this.RtxtMail.Location = new System.Drawing.Point(225, 223);
            this.RtxtMail.Name = "RtxtMail";
            this.RtxtMail.Size = new System.Drawing.Size(249, 96);
            this.RtxtMail.TabIndex = 26;
            this.RtxtMail.Text = "";
            // 
            // txtSub
            // 
            this.txtSub.Location = new System.Drawing.Point(225, 180);
            this.txtSub.Name = "txtSub";
            this.txtSub.Size = new System.Drawing.Size(249, 20);
            this.txtSub.TabIndex = 25;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(225, 127);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(249, 20);
            this.txtTo.TabIndex = 24;
            // 
            // lblAttach
            // 
            this.lblAttach.AutoSize = true;
            this.lblAttach.BackColor = System.Drawing.Color.Black;
            this.lblAttach.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttach.ForeColor = System.Drawing.Color.White;
            this.lblAttach.Location = new System.Drawing.Point(62, 335);
            this.lblAttach.Name = "lblAttach";
            this.lblAttach.Size = new System.Drawing.Size(176, 24);
            this.lblAttach.TabIndex = 23;
            this.lblAttach.Text = "Click and Attach";
            this.lblAttach.Click += new System.EventHandler(this.lblAttach_Click);
            // 
            // lblMailMess
            // 
            this.lblMailMess.AutoSize = true;
            this.lblMailMess.BackColor = System.Drawing.Color.Black;
            this.lblMailMess.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMailMess.ForeColor = System.Drawing.Color.White;
            this.lblMailMess.Location = new System.Drawing.Point(132, 217);
            this.lblMailMess.Name = "lblMailMess";
            this.lblMailMess.Size = new System.Drawing.Size(58, 24);
            this.lblMailMess.TabIndex = 22;
            this.lblMailMess.Text = "Mail:";
            // 
            // lblMailSub
            // 
            this.lblMailSub.AutoSize = true;
            this.lblMailSub.BackColor = System.Drawing.Color.Black;
            this.lblMailSub.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMailSub.ForeColor = System.Drawing.Color.White;
            this.lblMailSub.Location = new System.Drawing.Point(121, 174);
            this.lblMailSub.Name = "lblMailSub";
            this.lblMailSub.Size = new System.Drawing.Size(94, 24);
            this.lblMailSub.TabIndex = 21;
            this.lblMailSub.Text = "Subject:";
            // 
            // lblMailTo
            // 
            this.lblMailTo.AutoSize = true;
            this.lblMailTo.BackColor = System.Drawing.Color.Black;
            this.lblMailTo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMailTo.ForeColor = System.Drawing.Color.White;
            this.lblMailTo.Location = new System.Drawing.Point(147, 121);
            this.lblMailTo.Name = "lblMailTo";
            this.lblMailTo.Size = new System.Drawing.Size(43, 24);
            this.lblMailTo.TabIndex = 20;
            this.lblMailTo.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 38);
            this.label1.TabIndex = 30;
            this.label1.Text = "GMAIL";
            // 
            // Gmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(650, 541);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAttach);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.RtxtMail);
            this.Controls.Add(this.txtSub);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.lblAttach);
            this.Controls.Add(this.lblMailMess);
            this.Controls.Add(this.lblMailSub);
            this.Controls.Add(this.lblMailTo);
            this.Name = "Gmail";
            this.Text = "Gmail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAttach;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RichTextBox RtxtMail;
        private System.Windows.Forms.TextBox txtSub;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label lblAttach;
        private System.Windows.Forms.Label lblMailMess;
        private System.Windows.Forms.Label lblMailSub;
        private System.Windows.Forms.Label lblMailTo;
        private System.Windows.Forms.Label label1;
    }
}