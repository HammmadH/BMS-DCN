using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Management_System
{
    public partial class BMS : Form
    {
        public BMS()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = "hammad";
            string pass = "ezan123";
            if(txtname.Text == name && txtpass.Text == pass)
            {
                MessageBox.Show("Successfully Login");
                SERVER ser = new SERVER();
                this.Hide();
                ser.Show();

            }
            else
            {
                MessageBox.Show("Fill Again!!!!");
            }
        }
    }
}
