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
    public partial class biletSat : UserControl
    {
        ArrayList seciliKoltuklar = new ArrayList();
        Dugum seciliSefer;

        public event EventHandler SpecialCondition;
        private void RaiseSpecialCondition()
        {
            if (SpecialCondition != null) // If nobody subscribed to the event, it will be null.
                SpecialCondition(this, EventArgs.Empty);
        }

        public biletSat()
        {
            
            InitializeComponent();
            koltukPanel.Visible = false;
            lblKol23.Visible = false;
            lblKol.Visible = false;
            tamamBtn.Visible = false;
            fiyatlbl.Visible = false;
            fytlbl.Visible = false;
            lira.Visible = false;
            geriBtn.Visible = false;
            rezerveBtn.Visible = false;
            tcBox.MaxLength = 11;
            telBox.MaxLength = 11;
            dtBox.Format = DateTimePickerFormat.Custom;
            dtBox.CustomFormat = "dd/MM/yyyy";
            dtBox.MinDate = new DateTime(1920, 12, 12);
            dtBox.MaxDate = new DateTime(2002, 01, 01);
            cinsBox.DropDownStyle = ComboBoxStyle.DropDownList;
            cinsBox.Items.Add("---Seçiniz---");
            cinsBox.Items.Add("Kadın");
            cinsBox.Items.Add("Erkek");
            cinsBox.SelectedIndex = 0;
        }

        public void oturusGoster(ListViewItem secili)
        {
            //seferGoster sefergosterUC = new seferGoster();
            //Controls.Add(sefergosterUC);
            string sefernumarasi = secili.SubItems[0].Text;
            seciliSefer = LinkedList.dugumuGetir(sefernumarasi);
            seciliKoltuklar = LinkedList.koltukGetir(seciliSefer);

            // ilkKolonbası = "12;43";
            // ikinciKolonbası = "50;43";
            fiyatlbl.Text = seciliSefer.biletFiyati.ToString();

            int i = 0;
            int j = 1;
            int k = 0;
            int firstx = 12;
            int firsty = 43;

            foreach (Koltuk item in seciliKoltuklar)
            {

                int numara = item.koltukNo;

                Button dynamicButton = new Button();

                dynamicButton.Name = string.Format("koltukBtn{0}",numara);
                dynamicButton.Text = " "+numara.ToString();
                dynamicButton.Location = new Point(firstx,firsty);
                dynamicButton.Size = new Size(32,32);
                dynamicButton.FlatStyle = FlatStyle.Flat;
                dynamicButton.FlatAppearance.BorderSize = 0;
                if (item.tcNo != null)
                {
                    if (item.cins != "erkek")
                    {
                        dynamicButton.Image = Image.FromFile("C:/Users/DELL/Desktop/ders/yazgel2-otobüs/images/icons8-person-female-30.png");
                    }
                    else if (item.cins != "kadın")
                    {
                        dynamicButton.Image = Image.FromFile("C:/Users/DELL/Desktop/ders/yazgel2-otobüs/images/icons8-administrator-male-30.png");
                    }
                    else
                    {
                        dynamicButton.Image = Image.FromFile("C:/Users/DELL/Desktop/ders/yazgel2-otobüs/images/icons8-red-circle-30.png");
                    }
                    dynamicButton.Text = "";
                }
                else
                {
                    dynamicButton.Image = Image.FromFile("C:/Users/DELL/Desktop/ders/yazgel2-otobüs/images/icons8-green-circle-30.png");
                    dynamicButton.Click += btn_secilmis; 
                }
                dynamicButton.ImageAlign = ContentAlignment.MiddleCenter;

                koltukPanel.Controls.Add(dynamicButton);

                if (j%2 != 0)
                {
                    firstx += 38;
                    j++; 
                }
                else
                {
                    firstx -= 38;
                    firsty += 37;
                    j = 1;
                    i++;
                }

                if (i == 7)
                {
                    if (k == 1)
                    {
                        firstx += 40;
                        k = 0;
                    }
                    else
                    {
                        k++;
                    }
                    firstx += 100;
                    firsty = 43;
                    i = 0;
                }
            }
  
        }
        public void btn_secilmis(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Image = Image.FromFile("C:/Users/DELL/Desktop/ders/yazgel2-otobüs/images/icons8-filled-circle-30.png");
            btn_degismisMi(btn);
        }

        ArrayList liste = new ArrayList();
        string koltukno = "";
        bool sonuc;
        public void btn_degismisMi(Button gelen)
        {
            if (liste.Count == 1)
            {
                foreach (Button item in liste)
                {
                    if (item == gelen)
                    {
                        liste.Clear();
                        sonuc = false; 
                    }
                    else
                    {
                        sonuc = true;
                    }
                    break;
                }
            }
            liste.Add(gelen);
            koltukno = gelen.Text;
            if (liste.Count > 1)
            {
                foreach (Button item in liste)
                {
                    item.Image = Image.FromFile("C:/Users/DELL/Desktop/ders/yazgel2-otobüs/images/icons8-green-circle-30.png");
                        liste.Clear();
                    liste.Add(gelen);
                    if (sonuc != false)
                    {
                        koltukno = gelen.Text;
                    }
                    else
                        koltukno = "";
                    break;
                }
            }

        }

        protected void kltkBtn_Click(object sender, EventArgs e)
        {
            if (tcBox.Text != "" && telBox.Text != "" && adBox.Text != "" && cinsBox.Text != "" && dtBox.Value > dtBox.MinDate && dtBox.Value < dtBox.MaxDate && mailBox.Text != "" && tcBox.Text.Length == tcBox.MaxLength && telBox.Text.Length == telBox.MaxLength)
            {
                koltukPanel.Visible = true;
                kltkBtn.Visible = false;
                RaiseSpecialCondition();
            }
            else
            {
                MessageBox.Show("Lütfen geçerli değerler girin veya boş bırakmayınız!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void secBtn_Click(object sender, EventArgs e)
        {
            if (koltukno != "")
            {
                koltukPanel.Visible = false;
                lblKol.Text = koltukno;
                geriBtn.Visible = true;
                lblKol23.Visible = true;
                fytlbl.Visible = true;
                lblKol.Visible = true;
                fiyatlbl.Visible = true;
                tamamBtn.Visible = true;
                lira.Visible = true;
                lira.BringToFront();
                rezerveBtn.Visible = true;
            }
            else
            {
                MessageBox.Show("Lütfen koltuk seçiniz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void tamamBtn_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Bilet satış işlemini onaylıyor musunuz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc != DialogResult.No)
            {
                int no = Int32.Parse(koltukno);
                foreach (Koltuk item in seciliKoltuklar)
                {
                    if (item.koltukNo == no)
                    {
                        LinkedList.koltukDoldur(seciliSefer, no, tcBox.Text, telBox.Text, adBox.Text, cinsBox.Text, dtBox.Text, mailBox.Text);
                        break;
                    }
                }
            }
        }

        private void geriBtn_Click(object sender, EventArgs e)
        {
            koltukPanel.Visible = true;
            geriBtn.Visible = false;
            lblKol23.Visible = false;
            lblKol.Visible = false;
            fytlbl.Visible = false;
            fiyatlbl.Visible = false;
            tamamBtn.Visible = false;
            lira.Visible = false;
            rezerveBtn.Visible = false;
        }

        private void rezerveBtn_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Rezervasyon işlemini onaylıyor musunuz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc != DialogResult.No)
            {
                int no = Int32.Parse(koltukno);
                foreach (Koltuk item in seciliKoltuklar)
                {
                    if (item.koltukNo == no)
                    {
                        LinkedList.koltukDoldur(seciliSefer, no, tcBox.Text, telBox.Text, adBox.Text, "rezerve", dtBox.Text, mailBox.Text);
                        break;
                    }
                }
            }
        }

        private void tcBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;

            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Lütfen bir sayı giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void telBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;

            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Lütfen bir sayı giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cinsBox_DropDownClosed(object sender, EventArgs e)
        {
            if (cinsBox.SelectedIndex == 0)
            {
                MessageBox.Show("Lütfen cinsiyet seçiniz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void adBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;

            if (!Char.IsLetter(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Lütfen bir harf giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
