namespace yazgel2_otobus
{
    partial class seferEkle
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(seferEkle));
            this.panel1 = new System.Windows.Forms.Panel();
            this.otbsTip = new System.Windows.Forms.ComboBox();
            this.guzergah = new System.Windows.Forms.ComboBox();
            this.trhBox = new System.Windows.Forms.DateTimePicker();
            this.fytBox = new System.Windows.Forms.TextBox();
            this.plkBox = new System.Windows.Forms.TextBox();
            this.kptBox = new System.Windows.Forms.TextBox();
            this.ylcBox = new System.Windows.Forms.TextBox();
            this.sfrBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.vzgBtn = new System.Windows.Forms.Button();
            this.ekleBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.otbsTip);
            this.panel1.Controls.Add(this.guzergah);
            this.panel1.Controls.Add(this.trhBox);
            this.panel1.Controls.Add(this.fytBox);
            this.panel1.Controls.Add(this.plkBox);
            this.panel1.Controls.Add(this.kptBox);
            this.panel1.Controls.Add(this.ylcBox);
            this.panel1.Controls.Add(this.sfrBox);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(14, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 395);
            this.panel1.TabIndex = 1;
            // 
            // otbsTip
            // 
            this.otbsTip.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.otbsTip.FormattingEnabled = true;
            this.otbsTip.Location = new System.Drawing.Point(304, 124);
            this.otbsTip.Name = "otbsTip";
            this.otbsTip.Size = new System.Drawing.Size(171, 28);
            this.otbsTip.TabIndex = 6;
            this.otbsTip.DropDownClosed += new System.EventHandler(this.otbsTip_DropDownClosed);
            // 
            // guzergah
            // 
            this.guzergah.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guzergah.FormattingEnabled = true;
            this.guzergah.Location = new System.Drawing.Point(304, 82);
            this.guzergah.Name = "guzergah";
            this.guzergah.Size = new System.Drawing.Size(171, 28);
            this.guzergah.TabIndex = 6;
            this.guzergah.DropDownClosed += new System.EventHandler(this.guzergah_DropDownClosed);
            // 
            // trhBox
            // 
            this.trhBox.CalendarFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.trhBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.trhBox.Location = new System.Drawing.Point(304, 338);
            this.trhBox.Name = "trhBox";
            this.trhBox.Size = new System.Drawing.Size(171, 27);
            this.trhBox.TabIndex = 2;
            // 
            // fytBox
            // 
            this.fytBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fytBox.Location = new System.Drawing.Point(304, 295);
            this.fytBox.Multiline = true;
            this.fytBox.Name = "fytBox";
            this.fytBox.Size = new System.Drawing.Size(171, 29);
            this.fytBox.TabIndex = 1;
            this.fytBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fytBox_KeyPress);
            // 
            // plkBox
            // 
            this.plkBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.plkBox.Location = new System.Drawing.Point(304, 252);
            this.plkBox.Multiline = true;
            this.plkBox.Name = "plkBox";
            this.plkBox.Size = new System.Drawing.Size(171, 29);
            this.plkBox.TabIndex = 1;
            // 
            // kptBox
            // 
            this.kptBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kptBox.Location = new System.Drawing.Point(304, 209);
            this.kptBox.Multiline = true;
            this.kptBox.Name = "kptBox";
            this.kptBox.Size = new System.Drawing.Size(171, 29);
            this.kptBox.TabIndex = 1;
            this.kptBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kptBox_KeyPress);
            // 
            // ylcBox
            // 
            this.ylcBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ylcBox.Location = new System.Drawing.Point(304, 166);
            this.ylcBox.Multiline = true;
            this.ylcBox.Name = "ylcBox";
            this.ylcBox.Size = new System.Drawing.Size(171, 29);
            this.ylcBox.TabIndex = 1;
            this.ylcBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ylcBox_KeyPress);
            // 
            // sfrBox
            // 
            this.sfrBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sfrBox.Location = new System.Drawing.Point(304, 39);
            this.sfrBox.Multiline = true;
            this.sfrBox.Name = "sfrBox";
            this.sfrBox.Size = new System.Drawing.Size(171, 29);
            this.sfrBox.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(104, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Bilet Fiyatı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(68, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Otobüs Plakası:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(121, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Kaptan:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(59, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Yolcu Kapasitesi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(96, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Otobüs Tipi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(61, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Güzergah Bilgisi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(66, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sefer Numarası:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(98, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sefer Tarihi:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(96)))));
            this.panel2.Controls.Add(this.vzgBtn);
            this.panel2.Controls.Add(this.ekleBtn);
            this.panel2.Location = new System.Drawing.Point(776, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(152, 117);
            this.panel2.TabIndex = 5;
            // 
            // vzgBtn
            // 
            this.vzgBtn.FlatAppearance.BorderSize = 0;
            this.vzgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vzgBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.vzgBtn.ForeColor = System.Drawing.Color.White;
            this.vzgBtn.Image = ((System.Drawing.Image)(resources.GetObject("vzgBtn.Image")));
            this.vzgBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vzgBtn.Location = new System.Drawing.Point(3, 63);
            this.vzgBtn.Name = "vzgBtn";
            this.vzgBtn.Size = new System.Drawing.Size(171, 54);
            this.vzgBtn.TabIndex = 4;
            this.vzgBtn.Text = "   Vazgeç";
            this.vzgBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.vzgBtn.UseVisualStyleBackColor = true;
            // 
            // ekleBtn
            // 
            this.ekleBtn.FlatAppearance.BorderSize = 0;
            this.ekleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ekleBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekleBtn.ForeColor = System.Drawing.Color.White;
            this.ekleBtn.Image = ((System.Drawing.Image)(resources.GetObject("ekleBtn.Image")));
            this.ekleBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ekleBtn.Location = new System.Drawing.Point(3, 0);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(167, 54);
            this.ekleBtn.TabIndex = 4;
            this.ekleBtn.Text = "   Ekle";
            this.ekleBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ekleBtn.UseVisualStyleBackColor = true;
            this.ekleBtn.Click += new System.EventHandler(this.ekleBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(56)))), ((int)(((byte)(94)))));
            this.label3.Location = new System.Drawing.Point(25, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "  Sefer Ekle   ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // seferEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "seferEkle";
            this.Size = new System.Drawing.Size(962, 429);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker trhBox;
        private System.Windows.Forms.TextBox fytBox;
        private System.Windows.Forms.TextBox plkBox;
        private System.Windows.Forms.TextBox kptBox;
        private System.Windows.Forms.TextBox ylcBox;
        private System.Windows.Forms.TextBox sfrBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button vzgBtn;
        private System.Windows.Forms.Button ekleBtn;
        private System.Windows.Forms.ComboBox guzergah;
        private System.Windows.Forms.ComboBox otbsTip;
    }
}
