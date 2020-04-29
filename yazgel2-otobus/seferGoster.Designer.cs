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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
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
            this.panel1.SuspendLayout();
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
            this.yolcuKapasitesi});
            this.sfrView.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sfrView.FullRowSelect = true;
            this.sfrView.GridLines = true;
            this.sfrView.HideSelection = false;
            listViewItem2.StateImageIndex = 0;
            this.sfrView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
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
            // seferGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "seferGoster";
            this.Size = new System.Drawing.Size(962, 429);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}
