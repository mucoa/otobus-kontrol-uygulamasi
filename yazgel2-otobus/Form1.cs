using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazgel2_otobus
{
    public partial class Form1 : Form
    {

        seferGoster seferlerUC = new seferGoster();

        public Form1()
        {
            InitializeComponent();
            ayarlar.Visible = false;
            //Form1 myParent = (Form1)this.Parent;
            Controls.Add(seferlerUC);
            seferlerUC.Location= new Point(203, 210);
            sidePanel.Height = homeBtn.Height;
            sidePanel.Top = homeBtn.Top;
            anasayfa1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sidePanel.Height = homeBtn.Height;
            sidePanel.Top = homeBtn.Top;
            anasayfa1.anasayf();
            anasayfa1.BringToFront();
        }

        private void addSfrBtn_Click(object sender, EventArgs e)
        {
            sidePanel.Height = addSfrBtn.Height;
            sidePanel.Top = addSfrBtn.Top;
            seferEkle1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void sfrBtn_Click(object sender, EventArgs e)
        {
            if (LinkedList.seferSayisi() != 0)
            {
                seferlerUC.ListSefer();
                sidePanel.Height = sfrBtn.Height;
                sidePanel.Top = sfrBtn.Top;
                seferlerUC.BringToFront();
            }
            else
            {
                MessageBox.Show("Sefer bulunamadı! Lütfen sefer ekleyip tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sidePanel.Height = addSfrBtn.Height;
                sidePanel.Top = addSfrBtn.Top;
                seferEkle1.BringToFront();
            }            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        new int Move;
        int Mouse_X;
        int Mouse_Y;
        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
            panel3.Cursor = Cursors.Default;
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            panel3.Cursor = Cursors.Hand;
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ayarlar.Visible == true)
            {
                ayarlar.Visible = false;
            }
            else
            {
                ayarlar.Visible = true;
            }
        }

        private void kydetBtn_Click(object sender, EventArgs e)
        {
            LinkedList.DosyaKayit();
        }
    }
}
