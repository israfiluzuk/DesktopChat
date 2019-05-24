namespace Server
{
    partial class frmGiris
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
            try
            {
                base.Dispose(disposing);
            }
            catch (System.Exception)
            {

                throw;
            }
            
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiris));
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.shpCikis = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shpGiris = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblKayitOl = new System.Windows.Forms.Label();
            this.errGiris = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errGiris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.shpCikis,
            this.shpGiris});
            this.shapeContainer1.Size = new System.Drawing.Size(1000, 800);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // shpCikis
            // 
            this.shpCikis.BorderColor = System.Drawing.Color.Transparent;
            this.shpCikis.CornerRadius = 63;
            this.shpCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shpCikis.Location = new System.Drawing.Point(944, -70);
            this.shpCikis.Name = "shpCikis";
            this.shpCikis.Size = new System.Drawing.Size(131, 127);
            this.shpCikis.Click += new System.EventHandler(this.shpCikis_Click);
            // 
            // shpGiris
            // 
            this.shpGiris.BorderColor = System.Drawing.SystemColors.Highlight;
            this.shpGiris.CornerRadius = 5;
            this.shpGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shpGiris.Location = new System.Drawing.Point(356, 421);
            this.shpGiris.Name = "shpGiris";
            this.shpGiris.Size = new System.Drawing.Size(270, 51);
            this.shpGiris.Click += new System.EventHandler(this.shpGiris_Click);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.Color.LightGray;
            this.txtKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(366, 311);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(250, 22);
            this.txtKullaniciAdi.TabIndex = 1;
            this.txtKullaniciAdi.Text = "username";
            this.txtKullaniciAdi.Enter += new System.EventHandler(this.txtKullaniciAdi_Enter);
            this.txtKullaniciAdi.Leave += new System.EventHandler(this.txtKullaniciAdi_Leave);
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.LightGray;
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSifre.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSifre.Location = new System.Drawing.Point(366, 371);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(250, 22);
            this.txtSifre.TabIndex = 2;
            this.txtSifre.Text = "sifre";
            this.txtSifre.TextChanged += new System.EventHandler(this.txtSifre_TextChanged);
            this.txtSifre.Enter += new System.EventHandler(this.txtSifre_Enter);
            this.txtSifre.Leave += new System.EventHandler(this.txtSifre_Leave);
            // 
            // lblKayitOl
            // 
            this.lblKayitOl.AutoSize = true;
            this.lblKayitOl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblKayitOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKayitOl.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblKayitOl.Location = new System.Drawing.Point(454, 509);
            this.lblKayitOl.Name = "lblKayitOl";
            this.lblKayitOl.Size = new System.Drawing.Size(76, 18);
            this.lblKayitOl.TabIndex = 4;
            this.lblKayitOl.Text = "SING UP";
            this.lblKayitOl.Click += new System.EventHandler(this.lblKayitOl_Click);
            // 
            // errGiris
            // 
            this.errGiris.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(942, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 57);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblKayitOl);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGiris";
            this.Load += new System.EventHandler(this.frmGiris_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmGiris_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmGiris_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmGiris_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.errGiris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape shpCikis;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape shpGiris;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblKayitOl;
        private System.Windows.Forms.ErrorProvider errGiris;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}