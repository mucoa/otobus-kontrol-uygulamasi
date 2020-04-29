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
        }
        public void ListSefer()
        {
            monthCalendar1.Visible = false;

            ArrayList dugumlist = new ArrayList();
            ArrayList koltuklist = new ArrayList();
            dugumlist = LinkedList.getir();
            sfrView.Items.Clear();
            sfrView.FullRowSelect = false;

            int i = 0;
            
            foreach (Dugum item in dugumlist)
            {
                i++;
                var row = new string[] { item.seferNo, item.seferTarih.ToString(), item.guzergah, item.otobus, item.plaka, LinkedList.koltukSayi(item).ToString() + "/("+item.yolcuKapasite+")" };
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
                sfrView.Items.Remove(item);
                LinkedList.silme(item.SubItems[0].Text);
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
                    var row = new string[] { item.seferNo, item.seferTarih.ToString(), item.guzergah, item.otobus, item.plaka, LinkedList.koltukSayi(item).ToString() + "/(" + item.yolcuKapasite + ")" };
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
                    var row = new string[] { item.seferNo, item.seferTarih.ToString(), item.guzergah, item.otobus, item.plaka, LinkedList.koltukSayi(item).ToString() + "/(" + item.yolcuKapasite + ")" };
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
    }
}
