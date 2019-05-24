using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Server
{
    public partial class frmSifreUnuttum : Form
    {
        public frmSifreUnuttum()
        {
            InitializeComponent();
        }

        private void txtMail_Enter(object sender, EventArgs e)
        {
            if (txtMail.Text == "mail adresinizi giriniz")
            {
                txtMail.Text = "";
            }
        }

        private void frmSifreUnuttum_Leave(object sender, EventArgs e)
        {
            if (txtMail.Text=="")
            {
                txtMail.Text = "mail adresinizi giriniz";
            }
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblGirisYap_Click(object sender, EventArgs e)
        {
            frmGiris nesneGiris = new frmGiris();
            nesneGiris.Show();
            this.Hide();
        }


    }
}
