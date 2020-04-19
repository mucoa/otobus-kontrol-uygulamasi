using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazgel2_otobus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sidePanel.Height = homeBtn.Height;
            sidePanel.Top = homeBtn.Top;
            anasayfa1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sidePanel.Height = homeBtn.Height;
            sidePanel.Top = homeBtn.Top;
            anasayfa1.BringToFront();
        }

        private void addSfrBtn_Click(object sender, EventArgs e)
        {
            sidePanel.Height = addSfrBtn.Height;
            sidePanel.Top = addSfrBtn.Top;
            seferEkle1.BringToFront();
        }
    }
}
