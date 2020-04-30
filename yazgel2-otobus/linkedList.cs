using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace yazgel2_otobus
{
    public class Koltuk
    {
        public Koltuk next;
        public Koltuk prev;
        public string sefer;
        public int koltukNo;
        public string tcNo;
        public string adSoyad;
        public string cins;
        public string cepTel;
        public string dTarih;
        public string mail;
    }

    public class Dugum
    {
        public Dugum next;
        public Koltuk koltuk;
        public string seferNo;
        public DateTime seferTarih;
        public int yolcuKapasite;
        public string plaka;
        public string kaptan;
        public string otobus;
        public string guzergah;
        public double biletFiyati;
        
    }

    public static class LinkedList
    {
        public static Dugum head;
        public static Koltuk ilk;

        public static void OneEkle(string sfrNo, DateTime sfrTrh, string plk, string kpt, string otbs, string guzrgh, int ylcKpt, double bltFyt)
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

        public static void dugumYazdir()
        {
            Dugum aktif = head; //listenin başına sarıyor!
            while (aktif != null)
            {
                MessageBox.Show(aktif.seferNo + "-");
                aktif = aktif.next;
            }
        }
        public static ArrayList getir()
        {
            ArrayList dugumlist = new ArrayList();
            Dugum aktif = head;

            while (aktif != null)
            {
                dugumlist.Add(aktif);
                aktif = aktif.next;
            }
            return dugumlist;//Liste olarak döndürülüyor.
        }
        
        public static Dugum dugumuGetir(string sfrNo)
        {
            Dugum aktif = head;

            while (aktif != null)
            {
                if (aktif.seferNo == sfrNo)
                {
                    break;
                }
                aktif = aktif.next;
            }
            return aktif;
        }


        public static int seferSayisi()
        {
            int seferCount=0;
            Dugum aktif = head;

            while(aktif != null)
            {
                aktif = aktif.next;
                seferCount++;
            }

            return seferCount;
        }

        public static void SonaEkle(string sfrNo, DateTime sfrTrh, string plk, string kpt, string otbs, string guzrgh, int ylcKpt, double bltFyt)
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

                for (int i = 1; i <= first.yolcuKapasite; i++)
                {
                    koltukEkle(first, i);
                }


                head = first;
               
                MessageBox.Show("Sefer eklenmiştir!", "Başarılı", MessageBoxButtons.OK,MessageBoxIcon.Information);
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

                for (int i = 1; i <= addit.yolcuKapasite; i++)
                {
                    koltukEkle(addit, i);
                }

                Dugum aktif = head;

                while (aktif.next != null)
                {
                    aktif = aktif.next;
                }

                aktif.next = addit;

                if (aktif.next != addit)
                {
                    MessageBox.Show("Sefer eklenemedi tekrar deneyiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Sefer eklenmiştir", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    
            }

        }

        public static void koltukEkle(Dugum aktif, int konum)
        {
            Koltuk yeniKoltuk = new Koltuk();

            if (aktif.koltuk == null)
            {          
                yeniKoltuk.koltukNo = konum;
                yeniKoltuk.sefer = aktif.seferNo;

                aktif.koltuk = yeniKoltuk;
            }
            else
            {
                yeniKoltuk.koltukNo = konum;
                yeniKoltuk.sefer = aktif.seferNo;

                Koltuk ilk = aktif.koltuk;

                while (ilk.next != null)
                {
                    ilk = ilk.next;
                }
                ilk.next = yeniKoltuk;
            }
                      
        }

        public static void koltukDoldur(Dugum aktif, int kolno, string tcno, string ceptel, string ad, string cinsiyet, string dtarih, string Mail)
        {
            Koltuk ilk = aktif.koltuk;
            Koltuk ilkKoltuk = aktif.koltuk;

            while( ilk.koltukNo != kolno)
            {
                ilk = ilk.next;
            }
            aktif.koltuk = ilk;
            aktif.koltuk.mail = Mail;
            aktif.koltuk.tcNo = tcno;
            aktif.koltuk.adSoyad = ad;
            aktif.koltuk.cepTel = ceptel;
            aktif.koltuk.cins = cinsiyet;
            aktif.koltuk.dTarih = dtarih;

            aktif.koltuk = ilkKoltuk;

            MessageBox.Show("İşlem onaylanmıştır.","",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        public static void dugumDuzenle(Dugum aktif, string sfrNo, DateTime sfrTrh, string plk, string kpt, string otbs, string guzrgh, int ylcKpt, double bltFyt)
        {
            aktif.guzergah = guzrgh;
            aktif.seferNo = sfrNo;
            aktif.seferTarih = sfrTrh;
            aktif.yolcuKapasite = ylcKpt;
            aktif.biletFiyati = bltFyt;
            aktif.plaka = plk;
            aktif.kaptan = kpt;
            aktif.otobus = otbs;

            MessageBox.Show("Düzenleme işlemi başarılı.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool tcKontrol(Dugum aktif, string tcno)
        {
            Koltuk ilk = aktif.koltuk;
            Koltuk ilkKoltuk = aktif.koltuk;
            bool deger = true;

            while (ilk != null)
            {
                if (ilk.tcNo == tcno)
                {
                    deger = false;
                }
                ilk = ilk.next;
            }
            aktif.koltuk = ilkKoltuk;
            return deger;
        }

        public static bool sfrKontrol(string no)
        {
            bool deger = true;
            Dugum aktif = head;

            while (aktif != null)
            {
                if (aktif.seferNo == no)
                {
                    deger = false;
                }
                aktif = aktif.next;
            }
            return deger;
        }
        public static bool koltukBosalt(Dugum aktif, int kolno)
        {
            bool deger = false;
            Koltuk ilk = aktif.koltuk;
            Koltuk ilkKoltuk = aktif.koltuk;

            while (ilk != null)
            {
                if (ilk.koltukNo == kolno)
                {
                    break;
                }
                ilk = ilk.next;
            }

            if (ilk != null)
            {
                aktif.koltuk = ilk;
                aktif.koltuk.mail = null;
                aktif.koltuk.tcNo = null;
                aktif.koltuk.adSoyad = null;
                aktif.koltuk.cepTel = null;
                aktif.koltuk.cins = null;
                aktif.koltuk.dTarih = null;

                aktif.koltuk = ilkKoltuk;
                deger = true;
            }

            return deger;
        }

        public static int toplamYolcu()
        {
            Dugum aktif = head;
            int sayac = 0;
            while (aktif != null)
            {
                Koltuk ilk = aktif.koltuk;

                while (ilk != null)
                {
                    if (ilk.tcNo != null)
                    {
                        sayac++;
                    }
                    ilk = ilk.next;
                }

                aktif = aktif.next;
            }

            return sayac;
        }

        public static double toplamGelir()
        {
            Dugum aktif = head;
            double sayac = 0;
            while (aktif != null)
            {
                Koltuk ilk = aktif.koltuk;

                while (ilk != null)
                {
                    if (ilk.tcNo != null)
                    {
                        sayac += aktif.biletFiyati;
                    }
                    ilk = ilk.next;
                }

                aktif = aktif.next;
            }

            return sayac;
        }
        
        public static void DosyaKayit()
        {
            var path = @"c:\Users\DELL\Desktop\ders\yazgel2-otobüs\kayitlar\" +DateTime.Now.Date.ToString("dd/MM/yyyy")+".txt";
            string strdetails = "{0, -20}{1, -20}{2,-20}{3, -20}{4, -20}{5, -20}{6, -20}{7, -20}";

            List<string> satirlar = new List<string>();
            satirlar.Add(String.Format(strdetails, "Sefer No", "Sefer Tarih", "Guzergah", "Plaka", "OtobusTip", "BiletFiyat", "YolcuKapasite", "Kaptan"));

           

            Dugum aktif = head;
            while (aktif != null)
            {
                Koltuk ilk = aktif.koltuk;
                satirlar.Add(String.Format(strdetails, aktif.seferNo, aktif.seferTarih, aktif.guzergah, aktif.plaka, aktif.otobus, aktif.biletFiyati, aktif.yolcuKapasite, aktif.kaptan));
                satirlar.Add(String.Format(strdetails, "Koltuklar", "", "", "", "", "", "", ""));
                while (ilk != null)
                {
                    
                    if (ilk.tcNo != null)
                    {
                        satirlar.Add(String.Format(strdetails, "", ilk.koltukNo, ilk.tcNo, ilk.adSoyad, ilk.cepTel, ilk.cins, ilk.dTarih, ilk.mail));
                    }
                    else
                    {
                        satirlar.Add(String.Format(strdetails, "", ilk.koltukNo, "Boş", "", "", "", "", ""));
                    }
                    ilk = ilk.next;
                }

                aktif = aktif.next;
            }
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    foreach (string item in satirlar)
                    {
                        sw.WriteLine(item);
                    }
                }
                MessageBox.Show("Kayıt başarılı.","", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Gün sonu kayıt işlemi yapılmıştır!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static ArrayList koltukGetir(Dugum aktif)
        {
            Dugum ilk = aktif;
            ArrayList koltuklist = new ArrayList();
            Koltuk ilkKoltuk = aktif.koltuk;

            while (ilk.koltuk != null)
            {
                koltuklist.Add(ilk.koltuk);
                ilk.koltuk = ilk.koltuk.next;
            }
            aktif.koltuk = ilkKoltuk;
            return koltuklist;
        }
        
        public static int koltukSayi(Dugum aktif)
        {
            Koltuk ilk = aktif.koltuk;

            int sayac = 0;

            while (ilk != null)
            {
                if (ilk.tcNo == null)
                {
                    sayac++;
                }
                ilk = ilk.next;
            }
            return sayac;
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

        public static void silme(string sfrno)
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
