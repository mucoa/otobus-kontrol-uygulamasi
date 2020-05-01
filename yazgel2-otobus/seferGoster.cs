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
using System.Diagnostics;
using System.Reflection;

namespace yazgel2_otobus
{
    public partial class seferGoster : UserControl
    {
        biletSat biletUC = new biletSat();
        public seferGoster()
        {
            InitializeComponent();
            Controls.Add(biletUC);
            duzenPanel.Visible = false;
        }
        public void ListSefer()
        {
            monthCalendar1.Visible = false;

            ArrayList dugumlist = new ArrayList();
            ArrayList koltuklist = new ArrayList();
            dugumlist = LinkedList.getir();
            sfrView.Items.Clear();

            int i = 0;
            
            foreach (Dugum item in dugumlist)
            {
                i++;
                double gelir = item.yolcuKapasite-LinkedList.koltukSayi(item);
                var row = new string[] { item.seferNo, item.seferTarih.ToString(), item.guzergah, item.otobus, item.plaka, LinkedList.koltukSayi(item).ToString() + "/("+item.yolcuKapasite+")", (gelir*item.biletFiyati).ToString()+ "₺", item.kaptan };
                var lvi = new ListViewItem(row);
                if (i % 2 != 0)
                    lvi.BackColor = SystemColors.Control;
                else
                    lvi.BackColor = SystemColors.Window;
                sfrView.Items.Add(lvi);
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            //var item = sfrView.CheckedItems[0];
            //MessageBox.Show(item.SubItems[0].Text);
            
            foreach (ListViewItem item in sfrView.CheckedItems)
            {
                Dugum suanki=LinkedList.dugumuGetir(item.SubItems[0].Text);

                if (LinkedList.koltukSayi(suanki) == suanki.yolcuKapasite)
                {
                    sfrView.Items.Remove(item);
                    LinkedList.silme(item.SubItems[0].Text);
                }
                else
                {
                    MessageBox.Show("Silinmek istenen sefer/sefeler de bilet satışı yapılmıştır.\nSefer silinemez!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void monthCalendar1_MouseLeave(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
        }

        private void tarihBtn_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            ArrayList dugumlist = new ArrayList();
            dugumlist = LinkedList.getir();
            int i = 0;
            sfrView.Items.Clear();

            foreach (Dugum item in dugumlist)
            {
                if (item.seferTarih.Date.ToString("dd/MM/yyyy") == e.Start.Date.ToString("dd/MM/yyyy"))
                {
                    i++;
                    var row = new string[] { item.seferNo, item.seferTarih.ToString(), item.guzergah, item.otobus, item.plaka, LinkedList.koltukSayi(item).ToString() + "/(" + item.yolcuKapasite + ")", item.kaptan };
                    var lvi = new ListViewItem(row);
                    if (i % 2 != 0)
                        lvi.BackColor = SystemColors.Control;
                    else
                        lvi.BackColor = SystemColors.Window;
                    sfrView.Items.Add(lvi);
                }
            }
        }

        private void araTxt_TextChanged(object sender, EventArgs e)
        {
            ArrayList dugumlist = new ArrayList();
            dugumlist = LinkedList.getir();
            int i = 0;
            sfrView.Items.Clear();

            foreach (Dugum item in dugumlist)
            {
                if (item.seferNo.ToString().ToLower().Contains(araTxt.Text.ToLower()) || item.otobus.ToString().ToLower().Contains(araTxt.Text.ToLower()) || item.plaka.ToString().ToLower().Contains(araTxt.Text.ToLower()) || item.guzergah.ToString().ToLower().Contains(araTxt.Text.ToLower()) || item.kaptan.ToString().ToLower().Contains(araTxt.Text.ToLower()))
                {
                    i++;
                    var row = new string[] { item.seferNo, item.seferTarih.ToString(), item.guzergah, item.otobus, item.plaka, LinkedList.koltukSayi(item).ToString() + "/(" + item.yolcuKapasite + ")", item.kaptan };
                    var lvi = new ListViewItem(row);
                    if (i % 2 != 0)
                        lvi.BackColor = SystemColors.Control;
                    else
                        lvi.BackColor = SystemColors.Window;
                    sfrView.Items.Add(lvi);
                }
            }
        }
            
        private void resetBtn_Click(object sender, EventArgs e)
        {
            ListSefer();
        }

        private void ticketBtn_Click(object sender, EventArgs e)
        {
            if (sfrView.CheckedItems.Count > 1 || sfrView.CheckedItems.Count == 0)
            {
                MessageBox.Show("Lütfen bir sefer seçiniz!","Uyarı", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                ListSefer();
            }
            else
            {
                biletUC.oturusGoster(sfrView.CheckedItems[0]);
                biletUC.BringToFront();
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (sfrView.CheckedItems.Count > 1 || sfrView.CheckedItems.Count == 0)
            {
                MessageBox.Show("Lütfen bir sefer seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ListSefer();
            }
            else
            {
                trhBox.MinDate = DateTime.Now.Date;
                trhBox.Format = DateTimePickerFormat.Custom;
                trhBox.CustomFormat = "dd/MM/yyyy HH:mm";

                guzergah.DropDownStyle = ComboBoxStyle.DropDownList;
                otbsTip.DropDownStyle = ComboBoxStyle.DropDownList;
                guzergah.Items.AddRange(new Object[] { "---Seçiniz---", "Kocaeli - Ankara", "Kocaeli - İstanbul", "Kocaeli - İzmir" });
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
                geriBtn.TabIndex = 9;
                duzenleBtn.TabIndex = 10;
                ylcBox.MaxLength = 2;

                string sefernumarasi = sfrView.CheckedItems[0].SubItems[0].Text;
                Dugum seciliSefer = LinkedList.dugumuGetir(sefernumarasi);
                sfrBox.Text = seciliSefer.seferNo;
                ylcBox.Text = seciliSefer.yolcuKapasite.ToString();
                kptBox.Text = seciliSefer.kaptan;
                plkBox.Text = seciliSefer.plaka;
                fytBox.Text = seciliSefer.biletFiyati.ToString();
                trhBox.Value = seciliSefer.seferTarih;
                guzergah.SelectedItem = seciliSefer.guzergah;
                otbsTip.SelectedItem = seciliSefer.otobus;
                duzenPanel.Visible = true;

            }
           
        }
        private void duzenleBtn_Click(object sender, EventArgs e)
        {
            if (sfrView.CheckedItems.Count == 1)
            {
                string sefernumarasi = sfrView.CheckedItems[0].SubItems[0].Text;


                Dugum seciliSefer = LinkedList.dugumuGetir(sefernumarasi);
                if (otbsTip.SelectedIndex != 0 && guzergah.SelectedIndex != 0 && fytBox.Text != "" && ylcBox.Text != "" && plkBox.Text != "" && sfrBox.Text != "" && kptBox.Text != "")
                {
                    double fiyat = double.Parse(fytBox.Text);
                    int yolcu = Int32.Parse(ylcBox.Text);
                    if (yolcu > 56)
                    {
                        yolcu = 56;
                    }
                    if (!LinkedList.sfrKontrol(sfrBox.Text) && seciliSefer.seferNo != sfrBox.Text)
                    {
                        MessageBox.Show("Bu sefer numarasına kayıtlı bir sefer bulunmaktadır!\nLütfen farklı bir sefer numarası girin.", "Sefer Numarası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        sfrBox.Text = "";
                    }
                    else
                    {
                        LinkedList.dugumDuzenle(seciliSefer, sfrBox.Text.ToUpper(), trhBox.Value, plkBox.Text.ToUpper(), kptBox.Text, otbsTip.SelectedItem.ToString(), guzergah.SelectedItem.ToString(), yolcu, fiyat);
                        duzenPanel.Visible = false;
                        ListSefer();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen sadece 1 sefer seçin!","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
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

        private void geriBtn_Click(object sender, EventArgs e)
        {
            duzenPanel.Visible = false;
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
    }
}
