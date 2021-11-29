using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiYarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;

            buttonsonraki.Enabled = true;


            label5.Text = buttonD.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                labeldogru.Text = dogru.ToString();
                picturedogru.Visible = true;
            }
            else
            {
                yanlis++;
                labelyanlıs.Text = yanlis.ToString();
                pictureyanlis.Visible = true;
            }
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;

            buttonsonraki.Enabled = true;


            label5.Text = buttonB.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                labeldogru.Text = dogru.ToString();
                picturedogru.Visible = true;
            }
            else
            {
                yanlis++;
                labelyanlıs.Text = yanlis.ToString();
                pictureyanlis.Visible = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;

            buttonsonraki.Enabled = true;


            label5.Text = buttonC.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                labeldogru.Text = dogru.ToString();
                picturedogru.Visible = true;
            }
            else
            {
                yanlis++;
                labelyanlıs.Text = yanlis.ToString();
                pictureyanlis.Visible = true;
            }
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;

            buttonsonraki.Enabled = true;


            label5.Text = buttonA.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                labeldogru.Text = dogru.ToString();
                picturedogru.Visible = true;
            }
            else
            {
                yanlis++;
                labelyanlıs.Text = yanlis.ToString();
                pictureyanlis.Visible = true;
            }
        }

        private void buttonsonraki_Click(object sender, EventArgs e)
        {
            soruno++;
            labelsoruno.Text = soruno.ToString();
            
            pictureyanlis.Visible = false;
            picturedogru.Visible = false;

            buttonA.Enabled = true;
            buttonB.Enabled = true;
            buttonC.Enabled = true;
            buttonD.Enabled = true;

            buttonsonraki.Enabled = false;

            if (soruno==1)
            {
                richTextBox1.Text = "Türkiyenin Başkenti Neresidir?";

                buttonA.Text = "Ankara";
                buttonB.Text = "İstanbul";
                buttonC.Text = "Bursa";
                buttonD.Text= "izmir";
                label4.Text = "Ankara";
            }

            if (soruno==2)
            {
                richTextBox1.Text = "Cumhuriyet Kaç Yılında İlan Edilmiştir?";

                buttonA.Text = "1924";
                buttonB.Text = "1923";
                buttonC.Text = "1920";
                buttonD.Text = "1921";
                label4.Text = "1923";
            }

            if (soruno == 3)
            {
                richTextBox1.Text="Türkiye Süper Liginde En Çok Şampiyon Olan Takım hangisidir?";
                buttonA.Text = "Beşiktaş";
                buttonB.Text = "Trabzonspor";
                buttonC.Text = "Fenerbahçe";
                buttonD.Text = "Galatasaray";
                label4.Text = "Galatasaray";

                buttonsonraki.Text = "Sonuçlar";


            }

            if (soruno==4)
            {
                buttonA.Enabled = false;
                buttonB.Enabled = false;
                buttonC.Enabled = false;
                buttonD.Enabled = false;

                buttonsonraki.Enabled = false;

                MessageBox.Show("Doğru:" + dogru + "      " + "Yanlış:"+ yanlis);
            }
        }
    }
}
