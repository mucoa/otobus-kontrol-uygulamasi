namespace yazgel2_otobus
{
    partial class seferGoster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(seferGoster));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tarihBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.araBtn = new System.Windows.Forms.Button();
            this.araTxt = new System.Windows.Forms.TextBox();
            this.ticketBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.sfrView = new System.Windows.Forms.ListView();
            this.seferNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.seferTarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.guzegah = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.otobus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.plaka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.yolcuKapasitesi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sfrGelir = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.duzenPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.geriBtn = new System.Windows.Forms.Button();
            this.duzenleBtn = new System.Windows.Forms.Button();
            this.kpt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.duzenPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(56)))), ((int)(((byte)(94)))));
            this.label3.Location = new System.Drawing.Point(25, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "  Sefer Listesi   ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tarihBtn);
            this.panel1.Controls.Add(this.resetBtn);
            this.panel1.Controls.Add(this.araBtn);
            this.panel1.Controls.Add(this.araTxt);
            this.panel1.Controls.Add(this.ticketBtn);
            this.panel1.Controls.Add(this.editBtn);
            this.panel1.Controls.Add(this.removeBtn);
            this.panel1.Controls.Add(this.sfrView);
            this.panel1.Location = new System.Drawing.Point(14, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 395);
            this.panel1.TabIndex = 3;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.Control;
            this.monthCalendar1.Location = new System.Drawing.Point(416, 41);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            this.monthCalendar1.MouseLeave += new System.EventHandler(this.monthCalendar1_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(556, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tarih:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(634, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sefer No:";
            // 
            // tarihBtn
            // 
            this.tarihBtn.FlatAppearance.BorderSize = 0;
            this.tarihBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tarihBtn.Image = ((System.Drawing.Image)(resources.GetObject("tarihBtn.Image")));
            this.tarihBtn.Location = new System.Drawing.Point(601, 12);
            this.tarihBtn.Name = "tarihBtn";
            this.tarihBtn.Size = new System.Drawing.Size(25, 24);
            this.tarihBtn.TabIndex = 3;
            this.tarihBtn.UseVisualStyleBackColor = true;
            this.tarihBtn.Click += new System.EventHandler(this.tarihBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.FlatAppearance.BorderSize = 0;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.Image = ((System.Drawing.Image)(resources.GetObject("resetBtn.Image")));
            this.resetBtn.Location = new System.Drawing.Point(845, 12);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(22, 23);
            this.resetBtn.TabIndex = 3;
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // araBtn
            // 
            this.araBtn.FlatAppearance.BorderSize = 0;
            this.araBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.araBtn.Image = ((System.Drawing.Image)(resources.GetObject("araBtn.Image")));
            this.araBtn.Location = new System.Drawing.Point(816, 12);
            this.araBtn.Name = "araBtn";
            this.araBtn.Size = new System.Drawing.Size(22, 23);
            this.araBtn.TabIndex = 3;
            this.araBtn.UseVisualStyleBackColor = true;
            // 
            // araTxt
            // 
            this.araTxt.BackColor = System.Drawing.SystemColors.Control;
            this.araTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.araTxt.Location = new System.Drawing.Point(705, 12);
            this.araTxt.Multiline = true;
            this.araTxt.Name = "araTxt";
            this.araTxt.Size = new System.Drawing.Size(133, 24);
            this.araTxt.TabIndex = 2;
            this.araTxt.TextChanged += new System.EventHandler(this.araTxt_TextChanged);
            // 
            // ticketBtn
            // 
            this.ticketBtn.FlatAppearance.BorderSize = 0;
            this.ticketBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ticketBtn.Image = ((System.Drawing.Image)(resources.GetObject("ticketBtn.Image")));
            this.ticketBtn.Location = new System.Drawing.Point(876, 104);
            this.ticketBtn.Name = "ticketBtn";
            this.ticketBtn.Size = new System.Drawing.Size(47, 53);
            this.ticketBtn.TabIndex = 1;
            this.ticketBtn.UseVisualStyleBackColor = true;
            this.ticketBtn.Click += new System.EventHandler(this.ticketBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Image = ((System.Drawing.Image)(resources.GetObject("editBtn.Image")));
            this.editBtn.Location = new System.Drawing.Point(874, 163);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(48, 53);
            this.editBtn.TabIndex = 1;
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.FlatAppearance.BorderSize = 0;
            this.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBtn.Image = ((System.Drawing.Image)(resources.GetObject("removeBtn.Image")));
            this.removeBtn.Location = new System.Drawing.Point(875, 222);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(48, 51);
            this.removeBtn.TabIndex = 1;
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // sfrView
            // 
            this.sfrView.BackColor = System.Drawing.SystemColors.Control;
            this.sfrView.CheckBoxes = true;
            this.sfrView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.seferNo,
            this.seferTarih,
            this.guzegah,
            this.otobus,
            this.plaka,
            this.yolcuKapasitesi,
            this.sfrGelir,
            this.kpt});
            this.sfrView.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sfrView.FullRowSelect = true;
            this.sfrView.GridLines = true;
            this.sfrView.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            this.sfrView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.sfrView.Location = new System.Drawing.Point(14, 50);
            this.sfrView.Name = "sfrView";
            this.sfrView.Size = new System.Drawing.Size(856, 323);
            this.sfrView.TabIndex = 0;
            this.sfrView.UseCompatibleStateImageBehavior = false;
            this.sfrView.View = System.Windows.Forms.View.Details;
            // 
            // seferNo
            // 
            this.seferNo.Text = "Sefer No";
            this.seferNo.Width = 100;
            // 
            // seferTarih
            // 
            this.seferTarih.Text = "Sefer Tarihi";
            this.seferTarih.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.seferTarih.Width = 150;
            // 
            // guzegah
            // 
            this.guzegah.Text = "Güzergah";
            this.guzegah.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guzegah.Width = 150;
            // 
            // otobus
            // 
            this.otobus.Text = "Otobüs Tipi";
            this.otobus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.otobus.Width = 150;
            // 
            // plaka
            // 
            this.plaka.Text = "Plaka";
            this.plaka.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.plaka.Width = 150;
            // 
            // yolcuKapasitesi
            // 
            this.yolcuKapasitesi.Text = "Boşluk / Kapasite";
            this.yolcuKapasitesi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.yolcuKapasitesi.Width = 150;
            // 
            // sfrGelir
            // 
            this.sfrGelir.Text = "Gelir";
            this.sfrGelir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sfrGelir.Width = 40;
            // 
            // duzenPanel
            // 
            this.duzenPanel.Controls.Add(this.label4);
            this.duzenPanel.Controls.Add(this.panel2);
            this.duzenPanel.Location = new System.Drawing.Point(3, 3);
            this.duzenPanel.Name = "duzenPanel";
            this.duzenPanel.Size = new System.Drawing.Size(956, 423);
            this.duzenPanel.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(56)))), ((int)(((byte)(94)))));
            this.label4.Location = new System.Drawing.Point(22, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "  Sefer Düzenle   ";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.otbsTip);
            this.panel2.Controls.Add(this.guzergah);
            this.panel2.Controls.Add(this.trhBox);
            this.panel2.Controls.Add(this.fytBox);
            this.panel2.Controls.Add(this.plkBox);
            this.panel2.Controls.Add(this.kptBox);
            this.panel2.Controls.Add(this.ylcBox);
            this.panel2.Controls.Add(this.sfrBox);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(11, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(929, 395);
            this.panel2.TabIndex = 3;
            // 
            // otbsTip
            // 
            this.otbsTip.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.otbsTip.FormattingEnabled = true;
            this.otbsTip.Location = new System.Drawing.Point(304, 124);
            this.otbsTip.Name = "otbsTip";
            this.otbsTip.Size = new System.Drawing.Size(171, 28);
            this.otbsTip.TabIndex = 6;
            // 
            // guzergah
            // 
            this.guzergah.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guzergah.FormattingEnabled = true;
            this.guzergah.Location = new System.Drawing.Point(304, 82);
            this.guzergah.Name = "guzergah";
            this.guzergah.Size = new System.Drawing.Size(171, 28);
            this.guzergah.TabIndex = 6;
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(61, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Güzergah Bilgisi:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(66, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Sefer Numarası:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(98, 340);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Sefer Tarihi:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(96)))));
            this.panel3.Controls.Add(this.geriBtn);
            this.panel3.Controls.Add(this.duzenleBtn);
            this.panel3.Location = new System.Drawing.Point(776, 136);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(152, 114);
            this.panel3.TabIndex = 5;
            // 
            // geriBtn
            // 
            this.geriBtn.BackColor = System.Drawing.Color.Tomato;
            this.geriBtn.FlatAppearance.BorderSize = 0;
            this.geriBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geriBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geriBtn.ForeColor = System.Drawing.Color.Black;
            this.geriBtn.Image = ((System.Drawing.Image)(resources.GetObject("geriBtn.Image")));
            this.geriBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.geriBtn.Location = new System.Drawing.Point(2, 58);
            this.geriBtn.Name = "geriBtn";
            this.geriBtn.Size = new System.Drawing.Size(149, 54);
            this.geriBtn.TabIndex = 4;
            this.geriBtn.Text = "   Vazgeç";
            this.geriBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.geriBtn.UseVisualStyleBackColor = false;
            this.geriBtn.Click += new System.EventHandler(this.geriBtn_Click);
            // 
            // duzenleBtn
            // 
            this.duzenleBtn.BackColor = System.Drawing.Color.YellowGreen;
            this.duzenleBtn.FlatAppearance.BorderSize = 0;
            this.duzenleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.duzenleBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.duzenleBtn.ForeColor = System.Drawing.Color.Black;
            this.duzenleBtn.Image = ((System.Drawing.Image)(resources.GetObject("duzenleBtn.Image")));
            this.duzenleBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.duzenleBtn.Location = new System.Drawing.Point(2, 2);
            this.duzenleBtn.Name = "duzenleBtn";
            this.duzenleBtn.Size = new System.Drawing.Size(149, 54);
            this.duzenleBtn.TabIndex = 4;
            this.duzenleBtn.Text = "   Düzenle";
            this.duzenleBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.duzenleBtn.UseVisualStyleBackColor = false;
            this.duzenleBtn.Click += new System.EventHandler(this.duzenleBtn_Click);
            // 
            // kpt
            // 
            this.kpt.Text = "Kaptan";
            this.kpt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // seferGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.duzenPanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "seferGoster";
            this.Size = new System.Drawing.Size(962, 429);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.duzenPanel.ResumeLayout(false);
            this.duzenPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView sfrView;
        private System.Windows.Forms.ColumnHeader seferNo;
        private System.Windows.Forms.ColumnHeader seferTarih;
        private System.Windows.Forms.ColumnHeader guzegah;
        private System.Windows.Forms.ColumnHeader otobus;
        private System.Windows.Forms.ColumnHeader plaka;
        private System.Windows.Forms.ColumnHeader yolcuKapasitesi;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button araBtn;
        private System.Windows.Forms.TextBox araTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button tarihBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button ticketBtn;
        private System.Windows.Forms.Panel duzenPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox otbsTip;
        private System.Windows.Forms.ComboBox guzergah;
        private System.Windows.Forms.DateTimePicker trhBox;
        private System.Windows.Forms.TextBox fytBox;
        private System.Windows.Forms.TextBox plkBox;
        private System.Windows.Forms.TextBox kptBox;
        private System.Windows.Forms.TextBox ylcBox;
        private System.Windows.Forms.TextBox sfrBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button geriBtn;
        private System.Windows.Forms.Button duzenleBtn;
        private System.Windows.Forms.ColumnHeader sfrGelir;
        private System.Windows.Forms.ColumnHeader kpt;
    }
}
