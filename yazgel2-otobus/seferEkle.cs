using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace yazgel2_otobus
{
    public partial class seferEkle : UserControl
    {
        public string kapasit;
        public seferEkle()
        {
            InitializeComponent();
            trhBox.MinDate = DateTime.Now;
            trhBox.Format = DateTimePickerFormat.Custom;
            trhBox.CustomFormat = "dd/MM/yyyy HH:mm";
            

            guzergah.DropDownStyle = ComboBoxStyle.DropDownList;
            otbsTip.DropDownStyle = ComboBoxStyle.DropDownList;
            guzergah.Items.AddRange(new Object[] { "---Seçiniz---","Kocaeli - Ankara", "Kocaeli - İstanbul", "Kocaeli - İzmir" });
            guzergah.SelectedIndex = 0;
            otbsTip.Items.AddRange(new Object[] { "---Seçiniz---", "Minibüs", "Midibüs", "Otobüs", "Körüklü Otobüs" });
            otbsTip.SelectedIndex = 0;
            sfrBox.TabIndex = 1;
            guzergah.TabIndex = 2;
            otbsTip.TabIndex = 3;
            ylcBox.TabIndex = 4;
            kptBox.TabIndex = 5;
            plkBox.TabIndex = 6;
            fytBox.TabIndex = 7;
            trhBox.TabIndex = 8;
            vzgBtn.TabIndex = 9;
            ekleBtn.TabIndex = 10;
            ylcBox.MaxLength = 2;
            

        }
        
        public void sfrGetir()
        {
            if (LinkedList.seferSayisi() > 0)
            {
                Dugum son = LinkedList.sonSefer();
                string sferNo = son.seferNo;
                string newStr = sferNo.Substring(3, 1);
                int no = Int32.Parse(newStr);
                no++;
                string yeniSfre = "sfr" + no.ToString();
                sfrBox.Text = yeniSfre;
                sfrBox.Enabled = false;
                sfrNoGtr.Visible = false;
            }
            else
            {
                MessageBox.Show("Sefer numarası bulunamadı dosyadan getirmek için butonu kullanın yada el ile yazınız.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sfrNoGtr.Visible = true;
            }
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            
            if (otbsTip.SelectedIndex != 0 && guzergah.SelectedIndex != 0 && fytBox.Text != "" && ylcBox.Text != "" && plkBox.Text != "" && sfrBox.Text != "" && kptBox.Text != "")
            {
                double fiyat = double.Parse(fytBox.Text, System.Globalization.CultureInfo.InvariantCulture);
                int yolcu = Int32.Parse(ylcBox.Text);
                if (yolcu > 56)
                {
                    yolcu = 56;
                }
                if (!LinkedList.sfrKontrol(sfrBox.Text))
                {
                    MessageBox.Show("Bu sefer numarasına kayıtlı bir sefer bulunmaktadır!\nLütfen farklı bir sefer numarası girin.", "Sefer Numarası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sfrBox.Text = "";
                }
                else
                {
                    LinkedList.SonaEkle(sfrBox.Text.ToUpper(), trhBox.Value, plkBox.Text.ToUpper(), kptBox.Text, otbsTip.SelectedItem.ToString(), guzergah.SelectedItem.ToString(), yolcu, fiyat);

                    fytBox.Text = "";
                    kptBox.Text = "";
                    plkBox.Text = "";
                    ylcBox.Text = "";
                    otbsTip.SelectedIndex = 0;
                    guzergah.SelectedIndex = 0;
                    sfrGetir();
                }
                
            }
            else
            {
                MessageBox.Show("Lütfen geçerli değerler giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kptBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;

            if (!Char.IsLetter(chr) && chr != 8 && chr != 32)
            {

                e.Handled = true;
                MessageBox.Show("Lütfen bir harf giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ylcBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;

            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Lütfen bir sayı giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void fytBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;

            if (!Char.IsDigit(chr) && chr != 8 && chr != 46)
            {

                e.Handled = true;
                MessageBox.Show("Lütfen bir sayı giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guzergah_DropDownClosed(object sender, EventArgs e)
        {
            if (guzergah.SelectedIndex == 0)
            {
                MessageBox.Show("Lütfen güzergah seçiniz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void otbsTip_DropDownClosed(object sender, EventArgs e)
        {
            if (otbsTip.SelectedIndex == 0)
            {
                MessageBox.Show("Lütfen tip seçiniz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void sfrNoGtr_Click(object sender, EventArgs e)
        {
            List<string> sfrlist = new List<string>();

            if (LinkedList.gelenler != null)
            {
                sfrlist = LinkedList.gelenler;
                int sayi = sfrlist.Count-1;
                string[] bolme = sfrlist[sayi].Split(' ');
                string yeni = bolme[0].Substring(3, 1);
                int deger = Int32.Parse(yeni);
                deger++;
                sfrBox.Text = "sfr" + deger;
                sfrBox.Enabled = false;
                sfrNoGtr.Visible = false;
            }
            else
            {
                MessageBox.Show("Önce ayarlar sekmesinden geçmiş sefer getiriniz!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void seferEkle_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void vzgBtn_Click(object sender, EventArgs e)
        {
            fytBox.Text = "";
            kptBox.Text = "";
            plkBox.Text = "";
            ylcBox.Text = "";
            otbsTip.SelectedIndex = 0;
            guzergah.SelectedIndex = 0;

        }
    }
}
