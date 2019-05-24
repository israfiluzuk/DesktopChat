namespace Server
{
    partial class frmChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChat));
            this.richTxtmesaj = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnGonder = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblKullanici = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.rtxtchat = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTxtmesaj
            // 
            this.richTxtmesaj.BackColor = System.Drawing.Color.White;
            this.richTxtmesaj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTxtmesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTxtmesaj.Location = new System.Drawing.Point(73, 661);
            this.richTxtmesaj.Name = "richTxtmesaj";
            this.richTxtmesaj.Size = new System.Drawing.Size(648, 74);
            this.richTxtmesaj.TabIndex = 0;
            this.richTxtmesaj.Text = "";
            this.richTxtmesaj.TextChanged += new System.EventHandler(this.richTxtmesaj_TextChanged);
            this.richTxtmesaj.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTxtmesaj_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(943, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 57);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTemizle.BackgroundImage")));
            this.btnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(753, 700);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(172, 42);
            this.btnTemizle.TabIndex = 10;
            this.btnTemizle.Text = "CLEAR";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click_1);
            // 
            // btnGonder
            // 
            this.btnGonder.BackColor = System.Drawing.Color.Transparent;
            this.btnGonder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGonder.BackgroundImage")));
            this.btnGonder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGonder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGonder.Location = new System.Drawing.Point(753, 652);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(172, 42);
            this.btnGonder.TabIndex = 9;
            this.btnGonder.Text = "SEND";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.BackColor = System.Drawing.Color.Transparent;
            this.lblKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanici.Location = new System.Drawing.Point(654, 165);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(91, 17);
            this.lblKullanici.TabIndex = 13;
            this.lblKullanici.Text = "User Name : ";
            // 
            // lblUserName
            // 
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserName.Location = new System.Drawing.Point(747, 160);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(178, 25);
            this.lblUserName.TabIndex = 11;
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rtxtchat
            // 
            this.rtxtchat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtchat.Location = new System.Drawing.Point(73, 210);
            this.rtxtchat.Name = "rtxtchat";
            this.rtxtchat.Size = new System.Drawing.Size(852, 368);
            this.rtxtchat.TabIndex = 14;
            this.rtxtchat.Text = "";
            // 
            // frmChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.rtxtchat);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTxtmesaj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChat";
            this.Load += new System.EventHandler(this.frmChat_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmChat_MouseMove);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmChat_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmChat_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmChat_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTxtmesaj;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblKullanici;
        public System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.RichTextBox rtxtchat;
    }
}