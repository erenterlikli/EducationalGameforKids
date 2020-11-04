using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EğitimUygulaması
{
    public partial class FrmHayvanlar : Form
    {
        public FrmHayvanlar()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\Eren\source\repos\EğitimUygulaması\EğitimUygulaması\bin\Debug\Sesler\kedi.mp3";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\Eren\source\repos\EğitimUygulaması\EğitimUygulaması\bin\Debug\Sesler\köpek.mp3";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\Eren\source\repos\EğitimUygulaması\EğitimUygulaması\bin\Debug\Sesler\kuş.mp3";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\Eren\source\repos\EğitimUygulaması\EğitimUygulaması\bin\Debug\Sesler\inek.mp3";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\Eren\source\repos\EğitimUygulaması\EğitimUygulaması\bin\Debug\Sesler\at.mp3";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\Eren\source\repos\EğitimUygulaması\EğitimUygulaması\bin\Debug\Sesler\koyun.mp3";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\Eren\source\repos\EğitimUygulaması\EğitimUygulaması\bin\Debug\Sesler\eşek.mp3";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\Eren\source\repos\EğitimUygulaması\EğitimUygulaması\bin\Debug\Sesler\maymun.mp3";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\Eren\source\repos\EğitimUygulaması\EğitimUygulaması\bin\Debug\Sesler\kurbağa.mp3";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa anasayfa = new FrmAnaSayfa();
            anasayfa.Show();
            this.Hide();
        }
    }
}
