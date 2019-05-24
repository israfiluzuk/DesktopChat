using MySql.Data.MySqlClient;
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
    public partial class frmChat : Form
    {
        mySql nesne = new mySql(); MySqlDataReader dr;
        public frmChat()
        {
            InitializeComponent();

            nesne.cmd = new MySqlCommand();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int SonMesajId { get; set; }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            nesne.baglanti.Open();
            nesne.cmd = new MySqlCommand("Insert into chat(yazi,yazan) Values ('" + richTxtmesaj.Text + "','" + lblUserName.Text + "') ", nesne.baglanti);
            nesne.cmd.ExecuteNonQuery();
            nesne.baglanti.Close();
            richTxtmesaj.Clear();
        }

        private void btnGonder_Click_1(object sender, EventArgs e)
        {

            richTxtmesaj.Text = "";


        }

        private void timer_Tick(object sender, EventArgs e)
        {
            nesne.baglanti.Open();
            nesne.cmd.Connection = nesne.baglanti;
            nesne.cmd.CommandText = "SELECT * from chat Where chat_Id > " + SonMesajId;

            dr = nesne.cmd.ExecuteReader();

            int sonId = 0;
            while ((dr.Read()))
            {
                sonId = Convert.ToInt32(dr["chat_Id"].ToString());
                rtxtchat.Text += Environment.NewLine + dr["yazan"].ToString() + ':' + dr["yazi"].ToString() + Environment.NewLine;
                
                TextBoxSonuGoster();
            }

            if (dr.HasRows) SonMesajId = sonId;

            nesne.baglanti.Close();

        }

        private void richTxtmesaj_KeyDown(object sender, KeyEventArgs ex)
        {
            if (ex.KeyCode == Keys.Enter)
            {
                nesne.baglanti.Open();
                nesne.cmd = new MySqlCommand("Insert into chat(yazi,yazan) Values ('" + richTxtmesaj.Text + "','" + lblUserName.Text + "') ", nesne.baglanti);
                nesne.cmd.ExecuteNonQuery();
                nesne.baglanti.Close();
                richTxtmesaj.Clear();
            }
        }

        private void btnTemizle_Click_1(object sender, EventArgs e)
        {
            richTxtmesaj.Text = "";
        }

        private void rtxtchat_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmChat_Load(object sender, EventArgs e)
        {
            TumMesajlariGetir();
            timer1.Start();
        }

        public void TumMesajlariGetir()
        {
            nesne.baglanti.Open();
            nesne.cmd.Connection = nesne.baglanti;
            nesne.cmd.CommandText = "SELECT * from chat";

            dr = nesne.cmd.ExecuteReader();

            int sonId = 0;
            string username;
            int txt_lenght;

            while ((dr.Read()))
            {
                sonId = Convert.ToInt32(dr["chat_Id"].ToString());
                rtxtchat.Text += Environment.NewLine + dr["yazan"].ToString() + ':' + dr["yazi"].ToString() + Environment.NewLine;
                txt_lenght = rtxtchat.TextLength;
                username = (dr["yazan"].ToString());
                //if (username == "admin")
                //{

                //    rtxtchat.Select(0, 1);
                //    rtxtchat.SelectionBackColor = Color.Yellow;
                //}
                //else if(username== "moderator")
                //{
                //    rtxtchat.Select(0, txt_lenght);
                //    rtxtchat.SelectionBackColor = Color.Red;
                //}
                //else
                //{
                //    rtxtchat.Select(0, txt_lenght);
                //    rtxtchat.SelectionBackColor = Color.Gray;
                //}
                TextBoxSonuGoster();
            }

            if (dr.HasRows) SonMesajId = sonId;

            nesne.baglanti.Close();
        }

        private void TextBoxSonuGoster()
        {
            rtxtchat.SelectionStart = rtxtchat.TextLength;
            rtxtchat.ScrollToCaret();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rtxtchat_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void richTxtmesaj_TextChanged(object sender, EventArgs e)
        {

        }

        public Point downPoint = Point.Empty;
        private void frmChat_MouseMove(object sender, MouseEventArgs e)
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

        private void frmChat_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            downPoint = new Point(e.X, e.Y);
        }

        private void frmChat_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            downPoint = Point.Empty;
        }


    }
}
