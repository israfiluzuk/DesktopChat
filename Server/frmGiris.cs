using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Server
{
    public partial class frmGiris : Form
    {
        //public static string baglanti = "Server=localhost; Database=id1472966_chat; UID=id1472966_admin; Password='CX47tr453+';Encrypt=false;AllowUserVariables=True;UseCompression=True";





        public frmGiris()
        {

            InitializeComponent();
        }

        private void shpCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblKayitOl_Click(object sender, EventArgs e)
        {
            frmKayit kayitNesnesi = new frmKayit();
            kayitNesnesi.Show();
            this.Hide();
        }

        private void txtSifre_Enter(object sender, EventArgs e)
        {
            if (txtSifre.Text == "sifre")
            {
                txtSifre.Text = "";
            }
        }

        private void txtSifre_Leave(object sender, EventArgs e)
        {
            if (txtSifre.Text == "")
            {
                txtSifre.Text = "sifre";
            }
        }

        private void txtKullaniciAdi_Enter(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "username")
            {
                txtKullaniciAdi.Text = "";
            }
        }

        private void txtKullaniciAdi_Leave(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "")
            {
                txtKullaniciAdi.Text = "username";
            }
        }

        ErrorProvider errProvider = new ErrorProvider();

        mySql nesne = new mySql();
        int i;
        private void shpGiris_Click(object sender, EventArgs e)
        {

            if (!nesne.baglantiDurum()) return;
            nesne.cmd = new MySqlCommand("select * from chat_users where user_id='" + txtKullaniciAdi.Text + "' and user_pas='" + txtSifre.Text + "'", nesne.baglanti);
            nesne.cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            nesne.adapter = new MySqlDataAdapter(nesne.cmd);
            nesne.adapter.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if (i == 0)
            {

                MessageBox.Show("Username or Password is wrong please try again", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                this.Hide();
                frmChat openChat = new frmChat();
                openChat.lblUserName.Text = txtKullaniciAdi.Text;
                openChat.Show();
                this.Hide();
            }
            nesne.baglanti.Close();
        }

        public Point downPoint = Point.Empty;
        private void frmGiris_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            downPoint = new Point(e.X, e.Y);
        }

        private void frmGiris_MouseMove(object sender, MouseEventArgs e)
        {
            if (downPoint == Point.Empty)
            {
                return;
            }
            Point location = new Point(
                this.Left + e.X - downPoint.X,
                this.Top + e.Y - downPoint.Y);
            this.Location = location;
        }

        private void frmGiris_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            downPoint = Point.Empty;
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        //String turkceKarakter="ü,ğ,ş,ı,ç,ö,Ü,Ğ,İ,Ş,Ç,Ö";
        //if (txtKullaniciAdi.Text=="")
        //{
        //    errGiris.SetError(txtKullaniciAdi, "Bu Alan Boş Geçilemez!");
        //}
        //else if (txtKullaniciAdi.Text==turkceKarakter)
        //{
        //    errGiris.SetError(txtKullaniciAdi,"Lütfen Türkçe Karakter Kullanmayınız!");
        //}
        //String ad = txtKullaniciAdi.Text;
        //String sifre = txtSifre.Text;
        //con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=chat_users.accdb");
        //cmd = new OleDbCommand();
        //con.Open();
        //cmd.Connection = con;
        //cmd.CommandText = "SELECT * FROM tbl_chat_users where kullanici_adi='" + txtKullaniciAdi.Text + "' AND kullanici_sifre='" + txtSifre.Text + "'";
        //dr = cmd.ExecuteReader();
        //if (dr.Read())
        //{
        //    frmChat objectChat = new frmChat();
        //    objectChat.Show();
        //    this.Hide();
        //}
        //else
        //{
        //    MessageBox.Show("Kullanıcı adı veya şifre hatalı","Uyarı penceresi",MessageBoxButtons.OK,MessageBoxIcon.Error);
        //}


    }

}


