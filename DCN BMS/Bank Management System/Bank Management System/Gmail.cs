using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace Bank_Management_System
{
    public partial class Gmail : Form
    {
        public Gmail()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpserver = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("haammaadhsn@gmail.com");
                mail.To.Add(txtTo.Text);
                mail.Subject = txtSub.Text;
                mail.Body = RtxtMail.Text;
                //Attachement
                System.Net.Mail.Attachment attachment;
                attachment = new System.Net.Mail.Attachment(txtAttach.Text);
                mail.Attachments.Add(attachment);
                smtpserver.Port = 587;
                smtpserver.Credentials = new
                System.Net.NetworkCredential("haammaadhsn@gmail.com", "dpoyqhzvuzwiniat");
                smtpserver.EnableSsl = true;
                smtpserver.Send(mail);
                MessageBox.Show("Mail Succesfully Send!!");
                txtTo.Clear();
                txtSub.Clear();
                RtxtMail.Clear();
                txtAttach.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void lblAttach_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All Files|*.*";
            ofd.Title = "Select a File";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtAttach.Text = ofd.FileName; //file path
                txtAttach.Tag = ofd.SafeFileName; //file name only.
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            SERVER se = new SERVER();
            this.Hide();
            se.Show();
        }
    }
}
