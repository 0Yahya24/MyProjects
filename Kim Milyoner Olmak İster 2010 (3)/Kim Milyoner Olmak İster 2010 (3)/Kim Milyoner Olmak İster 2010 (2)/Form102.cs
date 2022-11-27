using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Windows.Forms;

namespace Kim_Milyoner_Olmak_İster_2010__2_
{
    public partial class Form102 : Form
    {
        public Form102()
        {
            InitializeComponent();
        }
        public Int32 a, b, c, d, yc, dc;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            button1.Focus();
            button4.Focus();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            button1.Focus();
            button4.Focus();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button1.Focus();
            button4.Focus();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Focus();
            button4.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form102_Load(object sender, EventArgs e)
        {
            SoundPlayer ses = new SoundPlayer(@"C:\Users\sevinç\Desktop\Kim Milyoner Olmak İster 2010 (3)\Kim Milyoner Olmak İster 2010 (3)\Kim Milyoner Olmak İster 2010 (2)\Resources\Who-Wants-To-Be-A-Millionaire-Ask-The-Audience-Lifeline-Theme-[AudioTrimmer.com].wav");
            ses.Play();
            ses.PlayLooping();
            panel1.Visible = false;
            button4.Visible = false;
            if (Class1joker.degisken == 1)
            {
                button2.Enabled = false;
            }
            if (Class1joker.ciftcevap == 1)
            {
                button3.Enabled = false;
            }
            if (Class1joker.yarıyarıya == 1)
            {
                button6.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer ses = new SoundPlayer(@"D:\Yahya Emin Sevinç\C# Kim Milyoner (Deneme)\Kim Milyoner Olmak İster 2010 (2)\Kim Milyoner Olmak İster 2010 (2)\Resources\Who-Wants-To-Be-A-Millionaire-Ask-The-Audience-Lifeline-Theme-[AudioTrimmer.com].wav");
            ses.Stop();
            if (radioButton1.Checked == true)
            {
                radioButton3.BackColor = Color.Green;
                radioButton1.BackColor = Color.Red;
                SoundPlayer ss = new SoundPlayer(@"C:\Users\sevinç\Desktop\Kim Milyoner Olmak İster 2010 (3)\Kim Milyoner Olmak İster 2010 (3)\Kim Milyoner Olmak İster 2010 (2)\Resources\Yanlış-cevap-sesi-_dıııt_-Ses-Efekti.wav");
                ss.Play();

                MessageBox.Show("Elendiniz Doğru Cevap C");
                this.Close();
                yc++;

                Form112 ff4 = new Form112();
                ff4.Show();
                Visible = false;


            }
            else if (radioButton3.Checked == true)
            {
                radioButton3.BackColor = Color.Green;

                SoundPlayer s = new SoundPlayer(@"C:\Users\sevinç\Desktop\Kim Milyoner Olmak İster 2010 (3)\Kim Milyoner Olmak İster 2010 (3)\Kim Milyoner Olmak İster 2010 (2)\Resources\Dogru-Cevap-Ses-Efekti.wav");
                s.Play();
                MessageBox.Show("Tebrikler Doğru Bildiniz!");
                dc++;
                // SoundPlayer sees = new SoundPlayer(@"D:\Yahya Emin Sevinç\C# Kim Milyoner (Deneme)\Kim Milyoner Olmak İster 2010 (2)\Kim Milyoner Olmak İster 2010 (2)\Resources\Who-Wants-To-Be-A-Millionaire-Ask-The-Audience-Lifeline-Theme-[AudioTrimmer.com].wav");
                //sees.Play();
                Form103 f9 = new Form103();
                f9.Show();
                Visible = false;
            }
            else if (radioButton2.Checked == true)
            {
                radioButton3.BackColor = Color.Green;
                radioButton2.BackColor = Color.Red;
                SoundPlayer ss = new SoundPlayer(@"C:\Users\sevinç\Desktop\Kim Milyoner Olmak İster 2010 (3)\Kim Milyoner Olmak İster 2010 (3)\Kim Milyoner Olmak İster 2010 (2)\Resources\Yanlış-cevap-sesi-_dıııt_-Ses-Efekti.wav");
                ss.Play();

                // MessageBox.Show("Elendiniz Doğru Cevap B");
                yc++;
                MessageBox.Show("Elendiniz Doğru Cevap C");
                this.Close();
                Form112 fF4 = new Form112();
                fF4.Show();
                Visible = false;

            }
            else if (radioButton4.Checked == true)
            {
                radioButton3.BackColor = Color.Green;
                radioButton4.BackColor = Color.Red;
                SoundPlayer ss = new SoundPlayer(@"C:\Users\sevinç\Desktop\Kim Milyoner Olmak İster 2010 (3)\Kim Milyoner Olmak İster 2010 (3)\Kim Milyoner Olmak İster 2010 (2)\Resources\Yanlış-cevap-sesi-_dıııt_-Ses-Efekti.wav");
                ss.Play();

                // MessageBox.Show("Elendiniz Doğru Cevap B");
                yc++;
                MessageBox.Show("Elendiniz Doğru Cevap C");
                this.Close();
                Form112 f4 = new Form112();
                f4.Show();
                Visible = false;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seyircilere Soruyoruz");
            button1.Focus();
            panel1.Visible = true;
            Random rnd = new Random();
            a = rnd.Next(0,35);
            
            label21.Text = "%" + a.ToString();
            Random rnnd = new Random();
            b = rnd.Next(79, 89);
            label19.Text = "%"+b.ToString();
            Random rnnnd = new Random();
            c = rnd.Next(0, 15);
            label20.Text = "%" + c.ToString();
            Random rnnnnd = new Random();
            d = rnd.Next(0, 35);
            label18.Text = "%" + d.ToString();
            
            Class1joker.degisken = 1;
            button2.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button3.Enabled = false;
                SoundPlayer ss = new SoundPlayer(@"C:\Users\sevinç\Desktop\Kim Milyoner Olmak İster 2010 (3)\Kim Milyoner Olmak İster 2010 (3)\Kim Milyoner Olmak İster 2010 (2)\Resources\Yanlış-cevap-sesi-_dıııt_-Ses-Efekti.wav");
                ss.Play();
                radioButton1.BackColor = Color.Red;
        }
            else if (radioButton2.Checked == true)
            {
                button3.Enabled = false;
                radioButton2.BackColor = Color.Red;
                SoundPlayer ss = new SoundPlayer(@"C:\Users\sevinç\Desktop\Kim Milyoner Olmak İster 2010 (3)\Kim Milyoner Olmak İster 2010 (3)\Kim Milyoner Olmak İster 2010 (2)\Resources\Yanlış-cevap-sesi-_dıııt_-Ses-Efekti.wav");
                ss.Play();
            }
            else if (radioButton4.Checked == true)
            {
                button3.Enabled = false;
                radioButton4.BackColor = Color.Red;
                SoundPlayer ss = new SoundPlayer(@"C:\Users\sevinç\Desktop\Kim Milyoner Olmak İster 2010 (3)\Kim Milyoner Olmak İster 2010 (3)\Kim Milyoner Olmak İster 2010 (2)\Resources\Yanlış-cevap-sesi-_dıııt_-Ses-Efekti.wav");
                ss.Play();
            }
            else if (radioButton3.Checked == true)
            {
                radioButton3.BackColor = Color.Green;

                SoundPlayer s = new SoundPlayer(@"C:\Users\sevinç\Desktop\Kim Milyoner Olmak İster 2010 (3)\Kim Milyoner Olmak İster 2010 (3)\Kim Milyoner Olmak İster 2010 (2)\Resources\Dogru-Cevap-Ses-Efekti.wav");
                s.Play();
                MessageBox.Show("Tebrikler Doğru Bildiniz!");
                dc++;
               // SoundPlayer sees = new SoundPlayer(@"D:\Yahya Emin Sevinç\C# Kim Milyoner (Deneme)\Kim Milyoner Olmak İster 2010 (2)\Kim Milyoner Olmak İster 2010 (2)\Resources\Who-Wants-To-Be-A-Millionaire-Ask-The-Audience-Lifeline-Theme-[AudioTrimmer.com].wav");
                //sees.Play();
                Form103 f6 = new Form103();
                f6.Show();
                Visible = false;
            }
            button4.Visible = false;
            button1.Visible = true;
    }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İki Kere Cevaplama Hakkınız Var");
            button4.Visible = true;
            button1.Visible = false;
            button3.Enabled = false;
            Class1joker.ciftcevap = 1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yanlış Olan İki Şık Eleniyor");
            if (radioButton1.Enabled == false)
            {
                radioButton2.Visible = false;
            }
            radioButton1.Visible = false;
            radioButton4.Visible = false;
            Class1joker.yarıyarıya = 1;
            button6.Enabled = false;
            label21.Visible = false;
            label18.Visible = false;
        }
        }
    }

