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
    public partial class FrmEşleştir : Form
    {
        public FrmEşleştir()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Köpek";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Kuş";
        }

        private void FrmEşleştir_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Kedi";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "Maymun";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "Eşek";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "Kurbağa";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = "Koyun";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = "İnek";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label2.Text = "Cow";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label2.Text = "Sheep";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label2.Text = "Dog";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label2.Text = "Donkey";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label2.Text = "Cat";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label2.Text = "Monkey";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label2.Text = "Bird";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label2.Text = "Frog";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if(label1.Text=="Köpek" && label2.Text=="Dog")
            {
                button1.BackColor = Color.LimeGreen;
                button14.BackColor = Color.LimeGreen;
                button1.Enabled = false;
                button14.Enabled = false;
            }

            if(label1.Text=="Kuş" && label2.Text=="Bird")
            {
                button2.BackColor = Color.Fuchsia;
                button10.BackColor = Color.Fuchsia;
                button2.Enabled = false;
                button10.Enabled = false;
            }

            if(label1.Text=="Kedi" && label2.Text=="Cat")
            {
                button3.BackColor = Color.Yellow;
                button12.BackColor = Color.Yellow;
                button3.Enabled = false;
                button12.Enabled = false;
            }

            if(label1.Text=="Maymun" && label2.Text=="Monkey")
            {
                button4.BackColor = Color.DodgerBlue;
                button11.BackColor = Color.DodgerBlue;
                button4.Enabled = false;
                button11.Enabled = false;
            }

            if(label1.Text=="Eşek" && label2.Text=="Donkey")
            {
                button5.BackColor = Color.Chocolate;
                button13.BackColor = Color.Chocolate;
                button5.Enabled = false;
                button13.Enabled = false;
            }

            if (label1.Text == "Kurbağa" && label2.Text == "Frog")
            {
                button6.BackColor = Color.MediumSeaGreen;
                button9.BackColor = Color.MediumSeaGreen;
                button6.Enabled = false;
                button9.Enabled = false;
            }

            if (label1.Text == "Koyun" && label2.Text == "Sheep")
            {
                button7.BackColor = Color.IndianRed;
                button15.BackColor = Color.IndianRed;
                button7.Enabled = false;
                button15.Enabled = false;
            }

            if (label1.Text == "İnek" && label2.Text == "Cow")
            {
                button8.BackColor = Color.Goldenrod;
                button16.BackColor = Color.Goldenrod;
                button8.Enabled = false;
                button16.Enabled = false;
            }

            if (label1.Text == "At" && label2.Text == "Horse")
            {
                button18.BackColor = Color.SeaGreen;
                button19.BackColor = Color.SeaGreen;
                button18.Enabled = false;
                button19.Enabled = false;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            label1.Text = "At";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            label2.Text = "Horse";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa anasayfa = new FrmAnaSayfa();
            anasayfa.Show();
            this.Hide();
        }
    }
}
