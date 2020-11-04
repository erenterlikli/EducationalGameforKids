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
    public partial class FrmMatematik : Form
    {
        public FrmMatematik()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int puan = 0;
        private void button20_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa anasayfa = new FrmAnaSayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;

            int yanit;
            
            

            if(label2.Text=="+")
            {
                yanit = Convert.ToInt32(label1.Text) + Convert.ToInt32(label3.Text);
                label5.Text = yanit.ToString();
            }

            if(label2.Text=="-")
            {
                yanit = Convert.ToInt32(label1.Text) - Convert.ToInt32(label3.Text);
                label5.Text = yanit.ToString();
            }

            if(label2.Text=="*")
            {
                yanit = Convert.ToInt32(label1.Text) * Convert.ToInt32(label3.Text);
                label5.Text = yanit.ToString();
            }

            if(label2.Text=="/")
            {
                yanit = Convert.ToInt32(label1.Text) / Convert.ToInt32(label3.Text);
                label5.Text = yanit.ToString();
            }

            if(label5.Text==textBox1.Text)
            {
                puan = puan + 10;
                label6.Text = puan.ToString();
            }

            if(label5.Text!=textBox1.Text)
            {
                puan = puan - 5;
                label6.Text = puan.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            textBox1.Clear();
            int sayı1, sayı2, islem;

            sayı1 = rastgele.Next(0, 11);
            sayı2 = rastgele.Next(0, 11);
            islem = rastgele.Next(1, 5);

            label1.Text = sayı1.ToString();
            label3.Text = sayı2.ToString();

            if (islem == 1)
            {
                label2.Text = "+";

            }

            if (islem == 2)
            {
                label2.Text = "-";
            }

            if (islem == 3)
            {
                label2.Text = "*";
            }

            if (islem == 4)
            {
                label2.Text = "/";
            }
        }

        private void FrmMatematik_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }
    }
}
