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
    public partial class anasayfa : UserControl
    {
        ArrayList koltuk = new ArrayList();
        Dugum sefer;
        int kolno;
        bool basildiMi = false;

        public anasayfa()
        {
            InitializeComponent();
            iptalPanel.Visible = false;
            ad.Text = "";
            blt.Text = "";
            ad.Visible = false;
            blt.Visible = false;
            biletFiyat.Visible = false;
            adSoyad.Visible = false;
            iptalEtBtn.Visible = false;
            sfrLbl.Text = "0";
            ylcLbl.Text = "0";
            lisPanel.Visible = false;
            

            tcBox.MaxLength = 11;
        }

        private void iptalBtn_Click(object sender, EventArgs e)
        {
            iptalPanel.Visible = true;
        }

        public void anasayf()
        {
            sfrLbl.Text = LinkedList.seferSayisi().ToString();
            ylcLbl.Text = LinkedList.toplamYolcu().ToString();

        }

        public void listele()
        {
            sfrListbox.Items.Clear();
            List<string> gelenler = new List<string>();
            string strdetails = "{0, -20}{1, -20}{2,-20}{3, -20}{4, -20}{5, -20}{6, -20}{7, -20}";
            sfrListbox.Items.Add(String.Format(strdetails, "Sefer No", "Sefer Tarih", "Guzergah", "Plaka", "OtobusTip", "BiletFiyat", "YolcuKapasite", "Kaptan"));

            if (LinkedList.gelenler.Count != 0)
            {
                gelenler = LinkedList.gelenler;
                foreach (string item in gelenler)
                {
                    sfrListbox.Items.Add(item);
                }
                lisPanel.Visible = true;
            }
            else
            {
                MessageBox.Show("Liste getirlemedi!","Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void araBtn_Click(object sender, EventArgs e)
        {
            sefer = LinkedList.dugumuGetir(sfrBox.Text);
            if (sefer == null)
            {
                MessageBox.Show("Sefer numarası bulunamadı!","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                blt.Text = sefer.biletFiyati.ToString();

                koltuk =LinkedList.koltukGetir(sefer);

                foreach (Koltuk item in koltuk)
                {
                    if (item.tcNo == tcBox.Text)
                    {
                        kolno = item.koltukNo;
                        ad.Text = item.adSoyad;
                        break;
                    }
                }
                if (ad.Text == "")
                {
                    MessageBox.Show("Kayıtlı Tc no bulunamadı!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ad.Visible = true;
                    blt.Visible = true;
                    adSoyad.Visible = true;
                    biletFiyat.Visible = true;
                    iptalEtBtn.Visible = true;
                }
            }
        }

        private void iptalEtBtn_Click(object sender, EventArgs e)
        {
            if (!LinkedList.koltukBosalt(sefer, kolno))
            {
                MessageBox.Show("Bilet İptal edilemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Bilet İptal edildi.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            iptalPanel.Visible = false;
            ad.Text = "";
            blt.Text = "";
            ad.Visible = false;
            blt.Visible = false;
            biletFiyat.Visible = false;
            adSoyad.Visible = false;
            iptalEtBtn.Visible = false;
            anasayf();
        }

        private void toplamBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Toplam gelir : " + LinkedList.toplamGelir().ToString() + "₺", "", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void closeAra_Click(object sender, EventArgs e)
        {
            iptalPanel.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lisPanel.Visible = false;
        }

        private void gcmsSefer_Click(object sender, EventArgs e)
        {
            if (!basildiMi)
            {
                MessageBox.Show("Önce ayarlar sekmesinden geçmiş sefer getiriniz!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                listele();
            }
        }
        public void basilma()
        {
            //if (LinkedList.gelenler.Count != 0)
            {
                basildiMi = true;
            }
        }
    }
}
