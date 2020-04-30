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
    }
}
