namespace Server
{
    partial class frmKayit
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKayit));
            this.txtKayitSifre = new System.Windows.Forms.TextBox();
            this.txtKayitMail = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.shpKayitOl = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.picKayitCikis = new System.Windows.Forms.PictureBox();
            this.errKayit = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblKayitOl = new System.Windows.Forms.Label();
            this.txtKayitUsername = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picKayitCikis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errKayit)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKayitSifre
            // 
            this.txtKayitSifre.BackColor = System.Drawing.Color.LightGray;
            this.txtKayitSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKayitSifre.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKayitSifre.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtKayitSifre.Location = new System.Drawing.Point(370, 372);
            this.txtKayitSifre.Name = "txtKayitSifre";
            this.txtKayitSifre.PasswordChar = '*';
            this.txtKayitSifre.Size = new System.Drawing.Size(245, 22);
            this.txtKayitSifre.TabIndex = 1;
            this.txtKayitSifre.Text = "password";
            this.txtKayitSifre.Enter += new System.EventHandler(this.txtKayitSifre_Enter);
            this.txtKayitSifre.Leave += new System.EventHandler(this.txtKayitSifre_Leave);
            this.txtKayitSifre.Validating += new System.ComponentModel.CancelEventHandler(this.txtKayitSifre_Validating);
            // 
            // txtKayitMail
            // 
            this.txtKayitMail.BackColor = System.Drawing.Color.LightGray;
            this.txtKayitMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKayitMail.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKayitMail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtKayitMail.Location = new System.Drawing.Point(370, 433);
            this.txtKayitMail.Name = "txtKayitMail";
            this.txtKayitMail.Size = new System.Drawing.Size(245, 22);
            this.txtKayitMail.TabIndex = 2;
            this.txtKayitMail.Text = "mail";
            this.txtKayitMail.Enter += new System.EventHandler(this.txtKayitMail_Enter);
            this.txtKayitMail.Leave += new System.EventHandler(this.txtKayitMail_Leave);
            this.txtKayitMail.Validating += new System.ComponentModel.CancelEventHandler(this.txtKayitMail_Validating);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.shpKayitOl});
            this.shapeContainer1.Size = new System.Drawing.Size(1000, 800);
            this.shapeContainer1.TabIndex = 4;
            this.shapeContainer1.TabStop = false;
            // 
            // shpKayitOl
            // 
            this.shpKayitOl.BorderColor = System.Drawing.SystemColors.Highlight;
            this.shpKayitOl.CornerRadius = 5;
            this.shpKayitOl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shpKayitOl.Location = new System.Drawing.Point(356, 483);
            this.shpKayitOl.Name = "shpKayitOl";
            this.shpKayitOl.Size = new System.Drawing.Size(270, 49);
            this.shpKayitOl.Click += new System.EventHandler(this.shpKayitOl_Click);
            // 
            // picKayitCikis
            // 
            this.picKayitCikis.BackColor = System.Drawing.Color.Transparent;
            this.picKayitCikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picKayitCikis.BackgroundImage")));
            this.picKayitCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picKayitCikis.Location = new System.Drawing.Point(944, -1);
            this.picKayitCikis.Name = "picKayitCikis";
            this.picKayitCikis.Size = new System.Drawing.Size(57, 57);
            this.picKayitCikis.TabIndex = 4;
            this.picKayitCikis.TabStop = false;
            this.picKayitCikis.Click += new System.EventHandler(this.PicKayitCikis_Click);
            // 
            // errKayit
            // 
            this.errKayit.ContainerControl = this;
            // 
            // lblKayitOl
            // 
            this.lblKayitOl.AutoSize = true;
            this.lblKayitOl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblKayitOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKayitOl.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblKayitOl.Location = new System.Drawing.Point(453, 565);
            this.lblKayitOl.Name = "lblKayitOl";
            this.lblKayitOl.Size = new System.Drawing.Size(69, 18);
            this.lblKayitOl.TabIndex = 3;
            this.lblKayitOl.Text = "SING IN";
            this.lblKayitOl.Click += new System.EventHandler(this.lblKayitGirisYap);
            // 
            // txtKayitUsername
            // 
            this.txtKayitUsername.BackColor = System.Drawing.Color.LightGray;
            this.txtKayitUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKayitUsername.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKayitUsername.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtKayitUsername.Location = new System.Drawing.Point(370, 312);
            this.txtKayitUsername.Name = "txtKayitUsername";
            this.txtKayitUsername.Size = new System.Drawing.Size(245, 22);
            this.txtKayitUsername.TabIndex = 0;
            this.txtKayitUsername.Text = "username";
            // 
            // frmKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.txtKayitUsername);
            this.Controls.Add(this.lblKayitOl);
            this.Controls.Add(this.picKayitCikis);
            this.Controls.Add(this.txtKayitMail);
            this.Controls.Add(this.txtKayitSifre);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKayit";
            this.Load += new System.EventHandler(this.frmKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picKayitCikis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errKayit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtKayitSifre;
        private System.Windows.Forms.TextBox txtKayitMail;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape shpKayitOl;
        private System.Windows.Forms.PictureBox picKayitCikis;
        private System.Windows.Forms.ErrorProvider errKayit;
        private System.Windows.Forms.Label lblKayitOl;
        private System.Windows.Forms.TextBox txtKayitUsername;
    }
}