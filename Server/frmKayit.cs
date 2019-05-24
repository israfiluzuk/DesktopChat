using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using MySql.Data.MySqlClient;

namespace Server
{
    public partial class frmKayit : Form
    {
        
        
        public frmKayit()
        {
            InitializeComponent();
        }



        private void PicKayitCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        private void txtKayitSifre_Enter(object sender, EventArgs e)
        {
            if (txtKayitSifre.Text == "password")
            {
                txtKayitSifre.Text = "";
            }
        }

        private void txtKayitSifre_Leave(object sender, EventArgs e)
        {
            if (txtKayitSifre.Text == "")
            {
                txtKayitSifre.Text = "password";
            }
        }

        private void txtKayitMail_Enter(object sender, EventArgs e)
        {
            if (txtKayitMail.Text == "mail")
            {
                txtKayitMail.Text = "";
            }
        }



        private void txtKayitMail_Leave(object sender, EventArgs e)
        {
            if (txtKayitMail.Text == "")
            {
                txtKayitMail.Text = "mail";
            }
        }
        ErrorProvider provider = new ErrorProvider(); 

        private void shpKayitOl_Click(object sender, EventArgs e)
        {
            {
                //String turkceKarakter = "ü,ğ,ş,ı,ç,ö,Ü,Ğ,İ,Ş,Ç,Ö";
                //if (txtKayitKullaniciAdi.Text != "")
                //{

                //    if (txtKayitSifre.Text.Length >= 8)
                //    {
                //        MessageBox.Show("Şifre 8 karakterden uzun olmalı ! ", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    }

                //    if (txtKayitMail.Text != "")
                //    {
                //        MessageBox.Show("Tüm alanları doldurduğunuza emin olun ! ", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    }

                //}
                //else if (txtKayitSifre.Text != "")
                //{
                //    MessageBox.Show("Tüm alanlarıııı doldurduğunuza emin olun ! ", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}



                //else
                //{
                //    frmChat frmcc = new frmChat();
                //    frmcc.Show();
                //    this.Close();
                //}

                //else
                //{
                //    MessageBox.Show("Kullanıcı adı ya da şifre yanlış");
                //}

                //con.Close();
                //ErrorProvider errorkayit = new ErrorProvider();
                //if (txtKayitKullaniciAdi.Text == "")
                //{
                //    errKayit.SetError(txtKayitKullaniciAdi,"Bu Alan Boş Bırakılamaz");
                //}

                //else
                //{
                //    frmChat frmcc = new frmChat();
                //    frmcc.Show();
                //    this.Close();
                //}

                //--------------------------------------------------------------------------------------------------------------
                //_____________________________********KAYIT EKLEME*******____________________________
            }

           if (txtKayitUsername.Text == "" || txtKayitSifre.Text == "" || txtKayitMail.Text=="")
            {
                MessageBox.Show("Please Fill all text boxes", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    nesne.baglanti.Open();
                    
                nesne.cmd = new MySqlCommand("insert into chat_users (user_id,user_pas,user_mail) values ('" + txtKayitUsername.Text + "','" + txtKayitSifre.Text + "','" + txtKayitMail.Text + "')", nesne.baglanti);
                    object gelen = null;
                    gelen = nesne.cmd.ExecuteNonQuery(); 
                    if (gelen != null)
                        MessageBox.Show("Succesful", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Your Account could not create", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nesne.baglanti.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Error: " + err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void lblKayitGirisYap(object sender, EventArgs e)
        {
            frmGiris objGiris = new frmGiris();
            objGiris.Show();
            this.Hide();
        }
        mySql nesne = new mySql();

        private void txtKayitSifre_Validating(object sender, CancelEventArgs e)
        {

            if (txtKayitUsername.Text != "")
            {
                txtKayitUsername.Enabled = false;

                if (txtKayitUsername.Text == "")
                {
                    MessageBox.Show("username cannot be empty");

                }
                else
                {
                    return;
                }
            }
            nesne.baglanti.Close();

        }

        private void txtKayitMail_Validating(object sender, CancelEventArgs e)
        {
            if (txtKayitMail.Text != "")
            {
                txtKayitMail.Enabled = false;

                if (txtKayitMail.Text == "")
                {
                    MessageBox.Show("Mail cannot be empty");

                }
                else
                {
                    return;
                }
            }
            nesne.baglanti.Close();
        }

        private void frmKayit_Load(object sender, EventArgs e)
        {

        }
    }


    }

