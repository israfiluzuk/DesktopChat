namespace Server
{
    partial class frmSifreUnuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSifreUnuttum));
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.shpGonder = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblGirisYap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.shpGonder,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1000, 800);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // shpGonder
            // 
            this.shpGonder.BackColor = System.Drawing.Color.Transparent;
            this.shpGonder.BorderColor = System.Drawing.Color.Transparent;
            this.shpGonder.Location = new System.Drawing.Point(355, 401);
            this.shpGonder.Name = "shpGonder";
            this.shpGonder.Size = new System.Drawing.Size(270, 50);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rectangleShape1.BackgroundImage")));
            this.rectangleShape1.BorderColor = System.Drawing.Color.Transparent;
            this.rectangleShape1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rectangleShape1.Location = new System.Drawing.Point(942, 0);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.SelectionColor = System.Drawing.Color.Transparent;
            this.rectangleShape1.Size = new System.Drawing.Size(57, 57);
            this.rectangleShape1.Click += new System.EventHandler(this.rectangleShape1_Click);
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.LightGray;
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMail.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMail.Location = new System.Drawing.Point(364, 351);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(252, 22);
            this.txtMail.TabIndex = 1;
            this.txtMail.Text = "mail adresinizi giriniz";
            this.txtMail.Enter += new System.EventHandler(this.txtMail_Enter);
            // 
            // lblGirisYap
            // 
            this.lblGirisYap.AutoSize = true;
            this.lblGirisYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGirisYap.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblGirisYap.Location = new System.Drawing.Point(449, 498);
            this.lblGirisYap.Name = "lblGirisYap";
            this.lblGirisYap.Size = new System.Drawing.Size(88, 18);
            this.lblGirisYap.TabIndex = 6;
            this.lblGirisYap.Text = "GİRİŞ YAP";
            this.lblGirisYap.Click += new System.EventHandler(this.lblGirisYap_Click);
            // 
            // frmSifreUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.lblGirisYap);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSifreUnuttum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSifreUnuttum";
            this.Leave += new System.EventHandler(this.frmSifreUnuttum_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.TextBox txtMail;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape shpGonder;
        private System.Windows.Forms.Label lblGirisYap;
    }
}