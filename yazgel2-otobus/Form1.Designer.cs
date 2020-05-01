namespace yazgel2_otobus
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.addSfrBtn = new System.Windows.Forms.Button();
            this.sfrBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.ayarlar = new System.Windows.Forms.Panel();
            this.kytGtrBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.kydetBtn = new System.Windows.Forms.Button();
            this.seferGoster1 = new yazgel2_otobus.seferGoster();
            this.biletSat1 = new yazgel2_otobus.biletSat();
            this.seferEkle1 = new yazgel2_otobus.seferEkle();
            this.anasayfa1 = new yazgel2_otobus.anasayfa();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ayarlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.sidePanel);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.addSfrBtn);
            this.panel1.Controls.Add(this.sfrBtn);
            this.panel1.Controls.Add(this.homeBtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 630);
            this.panel1.TabIndex = 0;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(56)))), ((int)(((byte)(94)))));
            this.sidePanel.Location = new System.Drawing.Point(0, 183);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(12, 54);
            this.sidePanel.TabIndex = 7;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(13, 582);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(38, 36);
            this.button7.TabIndex = 7;
            this.button7.Text = "?";
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // addSfrBtn
            // 
            this.addSfrBtn.FlatAppearance.BorderSize = 0;
            this.addSfrBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSfrBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addSfrBtn.ForeColor = System.Drawing.Color.White;
            this.addSfrBtn.Image = ((System.Drawing.Image)(resources.GetObject("addSfrBtn.Image")));
            this.addSfrBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addSfrBtn.Location = new System.Drawing.Point(14, 300);
            this.addSfrBtn.Name = "addSfrBtn";
            this.addSfrBtn.Size = new System.Drawing.Size(188, 54);
            this.addSfrBtn.TabIndex = 7;
            this.addSfrBtn.Text = "       Sefer Ekleme";
            this.addSfrBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addSfrBtn.UseVisualStyleBackColor = true;
            this.addSfrBtn.Click += new System.EventHandler(this.addSfrBtn_Click);
            // 
            // sfrBtn
            // 
            this.sfrBtn.FlatAppearance.BorderSize = 0;
            this.sfrBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sfrBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sfrBtn.ForeColor = System.Drawing.Color.White;
            this.sfrBtn.Image = ((System.Drawing.Image)(resources.GetObject("sfrBtn.Image")));
            this.sfrBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sfrBtn.Location = new System.Drawing.Point(13, 243);
            this.sfrBtn.Name = "sfrBtn";
            this.sfrBtn.Size = new System.Drawing.Size(188, 54);
            this.sfrBtn.TabIndex = 7;
            this.sfrBtn.Text = "       Seferler";
            this.sfrBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sfrBtn.UseVisualStyleBackColor = true;
            this.sfrBtn.Click += new System.EventHandler(this.sfrBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.homeBtn.ForeColor = System.Drawing.Color.White;
            this.homeBtn.Image = ((System.Drawing.Image)(resources.GetObject("homeBtn.Image")));
            this.homeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBtn.Location = new System.Drawing.Point(13, 183);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(188, 54);
            this.homeBtn.TabIndex = 7;
            this.homeBtn.Text = "       Anasayfa";
            this.homeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(56)))), ((int)(((byte)(94)))));
            this.panel2.Location = new System.Drawing.Point(227, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(129, 120);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(56)))), ((int)(((byte)(94)))));
            this.panel3.Location = new System.Drawing.Point(199, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(962, 15);
            this.panel3.TabIndex = 2;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(56)))), ((int)(((byte)(94)))));
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(213, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(133, 161);
            this.panel4.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Taşımacılık";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Seyr-ü Sefer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 55);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(1107, 21);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 45);
            this.button5.TabIndex = 7;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(1058, 21);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(43, 45);
            this.button6.TabIndex = 7;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // ayarlar
            // 
            this.ayarlar.BackColor = System.Drawing.Color.White;
            this.ayarlar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ayarlar.Controls.Add(this.kytGtrBtn);
            this.ayarlar.Controls.Add(this.button1);
            this.ayarlar.Controls.Add(this.kydetBtn);
            this.ayarlar.Location = new System.Drawing.Point(1022, 72);
            this.ayarlar.Name = "ayarlar";
            this.ayarlar.Size = new System.Drawing.Size(100, 100);
            this.ayarlar.TabIndex = 13;
            // 
            // kytGtrBtn
            // 
            this.kytGtrBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kytGtrBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kytGtrBtn.Image = ((System.Drawing.Image)(resources.GetObject("kytGtrBtn.Image")));
            this.kytGtrBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kytGtrBtn.Location = new System.Drawing.Point(-1, 51);
            this.kytGtrBtn.Name = "kytGtrBtn";
            this.kytGtrBtn.Size = new System.Drawing.Size(100, 48);
            this.kytGtrBtn.TabIndex = 0;
            this.kytGtrBtn.Text = "           Getir";
            this.kytGtrBtn.UseVisualStyleBackColor = true;
            this.kytGtrBtn.Click += new System.EventHandler(this.kytGtrBtn_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kaydet";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.kydetBtn_Click);
            // 
            // kydetBtn
            // 
            this.kydetBtn.FlatAppearance.BorderSize = 0;
            this.kydetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kydetBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kydetBtn.Image = ((System.Drawing.Image)(resources.GetObject("kydetBtn.Image")));
            this.kydetBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kydetBtn.Location = new System.Drawing.Point(-1, 0);
            this.kydetBtn.Name = "kydetBtn";
            this.kydetBtn.Size = new System.Drawing.Size(98, 49);
            this.kydetBtn.TabIndex = 0;
            this.kydetBtn.Text = "Kaydet";
            this.kydetBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.kydetBtn.UseVisualStyleBackColor = true;
            this.kydetBtn.Click += new System.EventHandler(this.kydetBtn_Click);
            // 
            // seferGoster1
            // 
            this.seferGoster1.Location = new System.Drawing.Point(203, 210);
            this.seferGoster1.Name = "seferGoster1";
            this.seferGoster1.Size = new System.Drawing.Size(962, 429);
            this.seferGoster1.TabIndex = 12;
            this.seferGoster1.Visible = false;
            // 
            // biletSat1
            // 
            this.biletSat1.Location = new System.Drawing.Point(203, 210);
            this.biletSat1.Name = "biletSat1";
            this.biletSat1.Size = new System.Drawing.Size(962, 429);
            this.biletSat1.TabIndex = 11;
            // 
            // seferEkle1
            // 
            this.seferEkle1.Location = new System.Drawing.Point(203, 210);
            this.seferEkle1.Name = "seferEkle1";
            this.seferEkle1.Size = new System.Drawing.Size(958, 420);
            this.seferEkle1.TabIndex = 9;
            // 
            // anasayfa1
            // 
            this.anasayfa1.Location = new System.Drawing.Point(202, 210);
            this.anasayfa1.Name = "anasayfa1";
            this.anasayfa1.Size = new System.Drawing.Size(959, 417);
            this.anasayfa1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 630);
            this.Controls.Add(this.ayarlar);
            this.Controls.Add(this.seferGoster1);
            this.Controls.Add(this.biletSat1);
            this.Controls.Add(this.seferEkle1);
            this.Controls.Add(this.anasayfa1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ayarlar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sfrBtn;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Button addSfrBtn;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private anasayfa anasayfa1;
        private seferEkle seferEkle1;
        private biletSat biletSat1;
        private seferGoster seferGoster1;
        private System.Windows.Forms.Panel ayarlar;
        private System.Windows.Forms.Button kydetBtn;
        private System.Windows.Forms.Button kytGtrBtn;
        private System.Windows.Forms.Button button1;
    }
}

