using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazgel2_otobus
{
    public partial class seferEkle : UserControl
    {
        LinkedList sfrlist = new LinkedList();
        public seferEkle()
        {
            InitializeComponent();
            trhBox.MinDate = DateTime.Now;
            trhBox.Format = DateTimePickerFormat.Custom;
            trhBox.CustomFormat = "dd/MM/yyyy HH:mm";
            
                    
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            double fiyat = double.Parse(fytBox.Text);
            int yolcu = Int32.Parse(ylcBox.Text);
            sfrlist.SonaEkle(sfrBox.Text, trhBox.Text, plkBox.Text, kptBox.Text, otbsBox.Text, grzBox.Text, yolcu, fiyat);
            sfrlist.dugumYazdir();
        }

        private void ylcBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;

            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Lütfen geçerli bir değer giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void fytBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;

            if (!Char.IsDigit(chr) && chr != 8 && chr != 46)
            {
                e.Handled = true;
                MessageBox.Show("Lütfen geçerli bir değer giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
