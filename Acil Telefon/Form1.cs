using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acil_Telefon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text;
            text=textBox1.Text;
            textBox1.Text = text+"1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text;
            text = textBox1.Text;
            textBox1.Text = text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string text;
            text = textBox1.Text;
            textBox1.Text = text + "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string text;
            text = textBox1.Text;
            textBox1.Text = text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string text;
            text = textBox1.Text;
            textBox1.Text = text + "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string text;
            text = textBox1.Text;
            textBox1.Text = text + "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string text;
            text = textBox1.Text;
            textBox1.Text = text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string text;
            text = textBox1.Text;
            textBox1.Text = text + "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string text;
            text = textBox1.Text;
            textBox1.Text = text + "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string text;
            text = textBox1.Text;
            textBox1.Text = text + "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string text;
            text = textBox1.Text;
            if(text!="")
            {
                textBox1.Text = text.Substring(0, text.Length - 1);
            }
        }
        public void ses(string ses, string dur)
        {
            
            if (ses == "ambulans")
            {
                SoundPlayer audio = new SoundPlayer(Acil_Telefon.Properties.Resources.ambulans);
                if (dur == "dur")
                {
                    audio.Stop();
                }
                else
                {
                    audio.PlayLooping();
                }
            }
            else if (ses == "itfaiye")
            {
                SoundPlayer audio = new SoundPlayer(Acil_Telefon.Properties.Resources.itfaiye);
                if (dur == "dur")
                {
                    audio.Stop();
                }
                else
                {
                    audio.PlayLooping();
                }
            }
            else if (ses == "polis")
            {
                SoundPlayer audio = new SoundPlayer(Acil_Telefon.Properties.Resources.polis);
                if (dur == "dur")
                {
                    audio.Stop();
                }
                else
                {
                    audio.PlayLooping();
                }
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            string text;
            text = textBox1.Text;
            if (text!="")
            {
                if (text=="112")
                {
                    panel1.BackColor = Color.FromArgb(66, 226, 184);
                    textBox1.Text = "";
                    panel1.Visible = true;
                    hemsire.Visible=true;
                    label1.Visible =true;
                    label1.Text = "Ambulans Aranıyor";
                    ses("ambulans"," ");
                }
                else if(text == "110")
                {
                    panel1.BackColor = Color.FromArgb(208, 0, 0);
                    textBox1.Text = "";
                    panel1.Visible = true;
                    itfaiye.Visible = true;
                    label1.Visible = true;
                    label1.Text = "İtfaiye Aranıyor";
                    ses("itfaiye"," ");
                }
                else if (text == "155")
                {
                    panel1.BackColor = Color.FromArgb(204, 230, 244);
                    textBox1.Text = "";
                    panel1.Visible = true;
                    polis.Visible = true;
                    label1.Visible = true;
                    label1.Text = "Polis Aranıyor";
                    ses("polis"," ");
                }
                else if(text=="131730028")
                {
                    panel1.BackColor = Color.FromArgb(255, 232, 232);
                    textBox1.Text = "";
                    panel1.Visible = true;
                    label1.Text = "M.Ali ŞAHİN";
                }
                else
                {
                    textBox1.Text = "";
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ses("polis","dur");
            ses("ambulans","dur");
            ses("itfaiye","dur");
            panel1.Visible = false;
            polis.Visible = false;
            itfaiye.Visible = false;
            hemsire.Visible = false;
        }
    }
}
