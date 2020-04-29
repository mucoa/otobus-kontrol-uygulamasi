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
            otbsTip.Items.AddRange(new Object[] { "---Seçiniz---", "Minibüs", "Midibüs", "Otobüs", "Körüklü Otobüs", "Otobüs 2+1", "Otobüs 2+2" });
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

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            
            if (otbsTip.SelectedIndex != 0 && guzergah.SelectedIndex != 0 && fytBox.Text != "" && ylcBox.Text != "" && plkBox.Text != "" && sfrBox.Text != "" && kptBox.Text != "")
            {
                double fiyat = double.Parse(fytBox.Text);
                int yolcu = Int32.Parse(ylcBox.Text);
                if (yolcu > 56)
                {
                    yolcu = 56;
                }
                LinkedList.SonaEkle(sfrBox.Text.ToUpper(), trhBox.Value, plkBox.Text.ToUpper(), kptBox.Text, otbsTip.SelectedItem.ToString(), guzergah.SelectedItem.ToString(), yolcu, fiyat);

                fytBox.Text = "";
                sfrBox.Text = "";
                kptBox.Text = "";
                plkBox.Text = "";
                ylcBox.Text = "";
                otbsTip.SelectedIndex = 0;
                guzergah.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Lütfen geçerli değerler giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void ylcBox_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
