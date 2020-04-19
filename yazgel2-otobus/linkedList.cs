using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazgel2_otobus
{
    public class Dugum
    {
        public Dugum next;
        public string seferNo;
        public string seferTarih;
        public int yolcuKapasite;
        public string plaka;
        public string kaptan;
        public string otobus;
        public string guzergah;
        public double biletFiyati;
        
    }

    public class LinkedList
    {
        private Dugum head;

        public void OneEkle(string sfrNo, string sfrTrh, string plk, string kpt, string otbs, string guzrgh, int ylcKpt, double bltFyt)
        {
            Dugum addit = new Dugum();

            addit.biletFiyati = bltFyt;
            addit.guzergah = guzrgh;
            addit.kaptan = kpt;
            addit.otobus = otbs;
            addit.plaka = plk;
            addit.seferNo = sfrNo;
            addit.seferTarih = sfrTrh;
            addit.yolcuKapasite = ylcKpt;
            addit.next = head;

            head = addit;     
        }
        //
        public void dugumYazdir()
        {
            Dugum aktif = head;
            while (aktif != null)
            {
                MessageBox.Show("sefer numarasi: "+aktif.seferNo+"\n"+"plaka : "+aktif.plaka);
                aktif = aktif.next;
            }
        }

        public void SonaEkle(string sfrNo, string sfrTrh, string plk, string kpt, string otbs, string guzrgh, int ylcKpt, double bltFyt)
        {
            if (head == null)
            {
                Dugum first = new Dugum();

                first.guzergah = guzrgh;
                first.biletFiyati = bltFyt;
                first.guzergah = guzrgh;
                first.kaptan = kpt;
                first.otobus = otbs;
                first.plaka = plk;
                first.seferNo = sfrNo;
                first.seferTarih = sfrTrh;
                first.yolcuKapasite = ylcKpt;

                head = first;
            }
            else 
            { 
                Dugum addit = new Dugum();

                addit.biletFiyati = bltFyt;
                addit.guzergah = guzrgh;
                addit.kaptan = kpt;
                addit.otobus = otbs;
                addit.plaka = plk;
                addit.seferNo = sfrNo;
                addit.seferTarih = sfrTrh;
                addit.yolcuKapasite = ylcKpt;

                Dugum aktif = head;

                while (aktif.next != null)
                {
                    aktif = aktif.next;
                }

                aktif.next = addit;
            }
            //if (aktif.next != addit)
            //{
            //    MessageBox.Show("Sefer eklenemedi tekrar deneyiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //    MessageBox.Show("Sefer eklenmiştir", "Başarılı")

        }

        //public void arayaEkle(, string sfrNo, string sfrTrh, string plk, string kpt, string otbs, string guzrgh, int ylcKpt, float bltFyt)
        //{
        //    Dugum eklenecek = new Dugum();

        //    eklenecek.biletFiyati = bltFyt;
        //    eklenecek.guzergah = guzrgh;
        //    eklenecek.kaptan = kpt;
        //    eklenecek.otobus = otbs;
        //    eklenecek.plaka = plk;
        //    eklenecek.seferNo = sfrNo;
        //    eklenecek.seferTarih = sfrTrh;
        //    eklenecek.yolcuKapasite = ylcKpt;

        //    Dugum aktif = head;

        //    while (aktif.next != aranan)
        //    {

        //    }

        //}

        public void silme(string sfrno)
        {
            Dugum deleted = new Dugum();

            deleted.seferNo = sfrno;

            Dugum iter = head;

            Dugum prev = null;

            while (iter.next != null)
            {
                if (iter.seferNo == deleted.seferNo)
                {
                    break;
                }
                prev = iter;
                iter = iter.next;
            }

            if (iter != null)
            {
                if (prev == null)
                {
                    head = head.next;
                }
                else
                {
                    prev.next = iter.next;
                }
            }
            else
            {
                MessageBox.Show("Silinecek veri bulunumadı lütfen tekrar deneyiniz!", "Hata",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }
}
