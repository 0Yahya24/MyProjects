using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace Kim_Milyoner_Olmak_İster_2010__2_
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        public Int32 a, b, c, d, t = 120, dc, yc;

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t--;
            label2.Text = t.ToString();
            


            if (t == 0)
            {
                MessageBox.Show("Süreniz Doldu Elendiniz");
                Application.Exit();
            }
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            SoundPlayer ses = new SoundPlayer(@"C:\Users\sevinç\Desktop\Kim Milyoner Olmak İster 2010 (3)\Kim Milyoner Olmak İster 2010 (3)\Kim Milyoner Olmak İster 2010 (2)\Resources\Who-Wants-To-Be-A-Millionaire-Ask-The-Audience-Lifeline-Theme-[AudioTrimmer.com].wav");
            ses.Play();
            ses.PlayLooping();
            if (Class1joker.degisken == 1)
            {
                button2.Enabled = false;
            }
            if (Class1joker.ciftcevap == 1)
            {
                button3.Enabled = false;
            }
            timer1.Start();
            timer1.Interval = 900;
            panel1.Visible = false;
            button4.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Random r = new Random();
            a = r.Next(1,25);
            label21.Text = "%" + a.ToString();
            Random rn = new Random();
            b = rn.Next(1, 25);
            label20.Text = "%" + b.ToString();
            Random rnd = new Random();
            c = rnd.Next(50, 75);
            label19.Text = "%" + c.ToString();
            Random rnnd = new Random();
            d = rnnd.Next(1, 25);
            label18.Text = "%" + d.ToString();
            Class1joker.degisken = 1;
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

                Form4 f4 = new Form4();
                f4.Show();
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
                Form9 f9 = new Form9();
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
                Form4 f4 = new Form4();
                f4.Show();
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
                Form4 f4 = new Form4();
                f4.Show();
                Visible = false;

            }
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İki Kere Cevaplama Hakkınız Var");
            button4.Visible = true;
            button1.Visible = false;
            button3.Enabled = false;
            Class1joker.ciftcevap = 1;
        }

        private void button4_Click_1(object sender, EventArgs e)
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
                Form9 f6 = new Form9();
                f6.Show();
                Visible = false;
            }
            button4.Visible = false;
            button1.Visible = true;
            timer1.Stop();
    }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Focus();
            button4.Focus();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button1.Focus();
            button4.Focus();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            button1.Focus();
            button4.Focus();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            button1.Focus();
            button4.Focus();
        }
        }
    }

