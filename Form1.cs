﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_mrs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
        }

        //прорисовка контуров
        private void House()
        {
            Bitmap bmp = new Bitmap(picture.Width, picture.Height);
            Graphics graph = Graphics.FromImage(bmp);

            //внешний   контур квартиры
            graph.DrawLine(System.Drawing.Pens.Black, 10, 10, 10, 450);
            graph.DrawLine(System.Drawing.Pens.Black, 10, 10, 830, 10);
            graph.DrawLine(System.Drawing.Pens.Black, 10, 449, 460, 449);
            graph.DrawLine(System.Drawing.Pens.Black, 550, 450, 550, 230);
            graph.DrawLine(System.Drawing.Pens.Black, 550, 230, 830, 230);
            graph.DrawLine(System.Drawing.Pens.Black, 830, 230, 830, 10);
            //дверь входная
            graph.DrawLine(System.Drawing.Pens.Black, 520, 449, 550, 449);
            //стены кухни
            graph.DrawLine(System.Drawing.Pens.Black, 435, 449, 435, 380);
            graph.DrawLine(System.Drawing.Pens.Black, 435, 330, 435, 280);
            //стена между ванной и комнатой 1
            graph.DrawLine(System.Drawing.Pens.Black, 435, 230, 435, 10);
            //стена между кухней и комната_1
            graph.DrawLine(System.Drawing.Pens.Black, 435, 304, 10, 304);
            //стена комната_2
            graph.DrawLine(System.Drawing.Pens.Black, 630, 230, 630, 200);
            //стена между комната_2 и ванной
            graph.DrawLine(System.Drawing.Pens.Black, 630, 150, 630, 10);
            //стена ванной
            graph.DrawLine(System.Drawing.Pens.Black, 630, 120, 600, 120);
            graph.DrawLine(System.Drawing.Pens.Black, 550, 120, 435, 120);
            picture.Image = bmp;
        }


        // расположение textBox
        private void Boxes()
        {
            //комната 1
            textBox1.Font = new System.Drawing.Font(FontFamily.Families[13], this.Height / 10);
            textBox1.Width = 104;
            textBox1.Location = new Point(11, 14);
            textBox2.Font = new System.Drawing.Font(FontFamily.Families[13], this.Height / 10);
            textBox2.Width = 104;
            textBox2.Location = new Point(116, 14);
            textBox3.Font = new System.Drawing.Font(FontFamily.Families[13], this.Height / 10);
            textBox3.Width = 104;
            textBox3.Location = new Point(221, 14);
            textBox4.Font = new System.Drawing.Font(FontFamily.Families[13], this.Height / 10);
            textBox4.Width = 107;
            textBox4.Location = new Point(326, 14);
            textBox5.Font = new System.Drawing.Font(FontFamily.Families[13], this.Height / 10);
            textBox5.Width = 104;
            textBox5.Location = new Point(11, 111);
            textBox6.Font = new System.Drawing.Font(FontFamily.Families[13], this.Height / 10);
            textBox6.Width = 104;
            textBox6.Location = new Point(116, 111);
            textBox7.Font = new System.Drawing.Font(FontFamily.Families[13], this.Height / 10);
            textBox7.Width = 104;
            textBox7.Location = new Point(221, 111);
            textBox8.Font = new System.Drawing.Font(FontFamily.Families[13], this.Height / 10);
            textBox8.Width = 107;
            textBox8.Location = new Point(326, 111);
            textBox9.Font = new System.Drawing.Font(FontFamily.Families[13], this.Height / 10);
            textBox9.Width = 104;
            textBox9.Location = new Point(11, 208);
            textBox10.Font = new System.Drawing.Font(FontFamily.Families[13], this.Height / 10);
            textBox10.Width = 104;
            textBox10.Location = new Point(116, 208);
            textBox11.Font = new System.Drawing.Font(FontFamily.Families[13], this.Height / 10);
            textBox11.Width = 104;
            textBox11.Location = new Point(221, 208);
            textBox12.Font = new System.Drawing.Font(FontFamily.Families[13], this.Height / 10);
            textBox12.Width = 107;
            textBox12.Location = new Point(326, 208);

            //кухня
            textBox13.Font = new System.Drawing.Font(FontFamily.Families[13], this.Height / 14);
            textBox13.Width = 104;
            textBox13.Location = new Point(11, 308);
            textBox14.Font = new System.Drawing.Font(FontFamily.Families[13], this.Height / 14);
            textBox14.Width = 104;
            textBox14.Location = new Point(116, 308);
            textBox15.Font = new System.Drawing.Font(FontFamily.Families[13], this.Height / 14);
            textBox15.Width = 104;
            textBox15.Location = new Point(221, 308);
            textBox16.Font = new System.Drawing.Font(FontFamily.Families[13], this.Height / 14);
            textBox16.Width = 107;
            textBox16.Location = new Point(326, 308);
            textBox17.Font = new System.Drawing.Font(FontFamily.Families[13], this.Height / 14);
            textBox17.Width = 104;
            textBox17.Location = new Point(11, 379);
            textBox18.Font = new System.Drawing.Font(FontFamily.Families[13], this.Height / 14);
            textBox18.Width = 104;
            textBox18.Location = new Point(116, 379);
            textBox19.Font = new System.Drawing.Font(FontFamily.Families[13], this.Height / 14);
            textBox19.Width = 104;
            textBox19.Location = new Point(221, 379);
            textBox20.Font = new System.Drawing.Font(FontFamily.Families[13], this.Height / 14);
            textBox20.Width = 107;
            textBox20.Location = new Point(326, 379);

            //ванная
            textBox21.Font = new System.Drawing.Font(FontFamily.Families[13], this.Height / 9);
            textBox21.Width = 63;
            textBox21.Location = new Point(436, 14);
            textBox22.Font = new System.Drawing.Font(FontFamily.Families[13], this.Height / 9);
            textBox22.Width = 63;
            textBox22.Location = new Point(500, 14);
            textBox23.Font = new System.Drawing.Font(FontFamily.Families[13], this.Height / 9);
            textBox23.Width = 64;
            textBox23.Location = new Point(564, 14);

            //коридор
            textBox24.Font = new System.Drawing.Font(FontFamily.Families[13], this.Height / 16);
            textBox24.Width = 112;
            textBox24.Location = new Point(436, 387);
            textBox25.Font = new System.Drawing.Font(FontFamily.Families[13], this.Height / 16);
            textBox25.Width = 112;
            textBox25.Location = new Point(436, 323);
            textBox26.Font = new System.Drawing.Font(FontFamily.Families[13], this.Height / 16);
            textBox26.Width = 112;
            textBox26.Location = new Point(436, 259);
            textBox27.Font = new System.Drawing.Font(FontFamily.Families[13], this.Height / 16);
            textBox27.Width = 112;
            textBox27.Location = new Point(436, 196);
            textBox28.Font = new System.Drawing.Font(FontFamily.Families[13], this.Height / 14);
            textBox28.Width = 112;
            textBox28.Location = new Point(436, 124);
            textBox29.Font = new System.Drawing.Font(FontFamily.Families[13], this.Height / 9);
            textBox29.Width = 79;
            textBox29.Location = new Point(549, 124);

            //комната_2
            textBox30.Font = new System.Drawing.Font(FontFamily.Families[13], this.Height / 13 - 3);
            textBox30.Width = 65;
            textBox30.Location = new Point(631, 14);
            textBox31.Font = new System.Drawing.Font(FontFamily.Families[13], this.Height / 13 - 3);
            textBox31.Width = 65;
            textBox31.Location = new Point(697, 14);
            textBox32.Font = new System.Drawing.Font(FontFamily.Families[13], this.Height / 13 - 3);
            textBox32.Width = 65;
            textBox32.Location = new Point(763, 14);
            textBox33.Font = new System.Drawing.Font(FontFamily.Families[13], this.Height / 13 - 3);
            textBox33.Width = 65;
            textBox33.Location = new Point(631, 87);
            textBox34.Font = new System.Drawing.Font(FontFamily.Families[13], this.Height / 13 - 3);
            textBox34.Width = 65;
            textBox34.Location = new Point(697, 87);
            textBox35.Font = new System.Drawing.Font(FontFamily.Families[13], this.Height / 13 - 3);
            textBox35.Width = 65;
            textBox35.Location = new Point(763, 87);
            textBox36.Font = new System.Drawing.Font(FontFamily.Families[13], this.Height / 13 - 4);
            textBox36.Width = 65;
            textBox36.Location = new Point(631, 160);
            textBox37.Font = new System.Drawing.Font(FontFamily.Families[13], this.Height / 13 - 4);
            textBox37.Width = 65;
            textBox37.Location = new Point(697, 160);
            textBox38.Font = new System.Drawing.Font(FontFamily.Families[13], this.Height / 13 - 4);
            textBox38.Width = 65;
            textBox38.Location = new Point(763, 160);

        }
        private void Completion()
        {

            textBox1.Text = "68";
            textBox2.Text = "68";
            textBox3.Text = "69";
            textBox4.Text = "69";
            textBox5.Text = "74";
            textBox6.Text = "64";
            textBox7.Text = "68";
            textBox8.Text = "73";
            textBox9.Text = "73";
            textBox10.Text = "71";
            textBox11.Text = "71";
            textBox12.Text = "77";
            textBox13.Text = "85";
            textBox14.Text = "80";
            textBox15.Text = "76";
            textBox16.Text = "69";
            textBox17.Text = "86";
            textBox18.Text = "82";
            textBox19.Text = "78";
            textBox20.Text = "75";
            textBox21.Text = "64";
            textBox22.Text = "60";
            textBox23.Text = "55";
            textBox24.Text = "68";
            textBox25.Text = "64";
            textBox26.Text = "64";
            textBox27.Text = "62";
            textBox28.Text = "62";
            textBox29.Text = "49";
            textBox30.Text = "45";
            textBox31.Text = "42";
            textBox32.Text = "42";
            textBox33.Text = "44";
            textBox34.Text = "33";
            textBox35.Text = "38";
            textBox36.Text = "32";
            textBox37.Text = "25";
            textBox38.Text = "28";

        }

        int[] Arr = new int[] { 68, 68, 69, 69, 74, 64, 68, 73, 73, 71, 71, 77, 85, 80, 76, 69, 86, 82, 78, 75, 69, 64, 60, 68, 64, 64, 62, 62, 49, 45, 42, 42, 44, 33, 38, 32, 25, 28 };
        int[] Prakt = new int[] {-25,-28,-32,-33,-38,-44,-42,-42,-45,-49,-55,-60,-62,-64,-62,-64,-73,-69,-68,-69,-64,-64,-68,-74,-68,-68,-77,-71,-71,-71,-79,-85,-86,-88,-82,-85, -86,-88};    
        int[] Teor = new int[] { -18,-21,-23,-26,-28,-33,-38,-43,-47,-50,-53,-56,-59,-60,-64,-69,-71,-73,-73,-74,-74,-76,-76,-76,-77,-77,-78,-78,-81,-82,-82,-83,-84,-85,-87,-88,-90,-92};
        double[] LLong = new double[] {0.2,0.5,0.7,1,1.2,1.5,2,2.3,2.7,3,3.3,3.6,3.9,4,4.5,5,5.5,6,6.1,6.5,7,7.5,8,8.5,9.5,10,10.5,11,11.5,12.5,13,14,15,16.5,17.5,18,19,20};
        int hetR, hetG;

        private void rgb_f(int x)
        {
            hetR = hetG = 255;
            int midi = 61;
            if (x >= midi)
            {

                hetG = 255 - (7 * (x - midi));
            }
            else
            {
                hetR = 255 - 7 * (midi - x);
                hetG = 220;
            }


        }

        private void Colors()
        {
            int i = 0;
            rgb_f(Arr[i]);
            textBox1.BackColor = Color.FromArgb(255, hetR, hetG, 0);
            i++;
            rgb_f(Arr[i]);
            textBox2.BackColor = Color.FromArgb(255, hetR, hetG, 0);
            i++;
            rgb_f(Arr[i]);
            textBox3.BackColor = Color.FromArgb(255, hetR, hetG, 0);
            i++;
            rgb_f(Arr[i]);
            textBox4.BackColor = Color.FromArgb(255, hetR, hetG, 0);
            i++;
            rgb_f(Arr[i]);
            textBox5.BackColor = Color.FromArgb(255, hetR, hetG, 0);
            i++;
            rgb_f(Arr[i]);
            textBox6.BackColor = Color.FromArgb(255, hetR, hetG, 0);
            i++;
            rgb_f(Arr[i]);
            textBox7.BackColor = Color.FromArgb(255, hetR, hetG, 0);
            i++;
            rgb_f(Arr[i]);
            textBox8.BackColor = Color.FromArgb(255, hetR, hetG, 0);
            i++;
            rgb_f(Arr[i]);
            textBox9.BackColor = Color.FromArgb(255, hetR, hetG, 0);
            i++;
            rgb_f(Arr[i]);
            textBox10.BackColor = Color.FromArgb(255, hetR, hetG, 0);
            i++;
            rgb_f(Arr[i]);
            textBox11.BackColor = Color.FromArgb(255, hetR, hetG, 0);
            i++;
            rgb_f(Arr[i]);
            textBox12.BackColor = Color.FromArgb(255, hetR, hetG, 0);
            i++;
            rgb_f(Arr[i]);
            textBox13.BackColor = Color.FromArgb(255, hetR, hetG, 0);
            i++;
            rgb_f(Arr[i]);
            textBox14.BackColor = Color.FromArgb(255, hetR, hetG, 0);
            i++;
            rgb_f(Arr[i]);
            textBox15.BackColor = Color.FromArgb(255, hetR, hetG, 0);
            i++;
            rgb_f(Arr[i]);
            textBox16.BackColor = Color.FromArgb(255, hetR, hetG, 0);
            i++;
            rgb_f(Arr[i]);
            textBox17.BackColor = Color.FromArgb(255, hetR, hetG, 0);
            i++;
            rgb_f(Arr[i]);
            textBox18.BackColor = Color.FromArgb(255, hetR, hetG, 0);
            i++;
            rgb_f(Arr[i]);
            textBox19.BackColor = Color.FromArgb(255, hetR, hetG, 0);
            i++;
            rgb_f(Arr[i]);
            textBox20.BackColor = Color.FromArgb(255, hetR, hetG, 0);
            i++;
            rgb_f(Arr[i]);
            textBox21.BackColor = Color.FromArgb(255, hetR, hetG, 0);
            i++;
            rgb_f(Arr[i]);
            textBox22.BackColor = Color.FromArgb(255, hetR, hetG, 0);
            i++;
            rgb_f(Arr[i]);
            textBox23.BackColor = Color.FromArgb(255, hetR, hetG, 0);
            i++;
            rgb_f(Arr[i]);
            textBox24.BackColor = Color.FromArgb(255, hetR, hetG, 0);
            i++;
            rgb_f(Arr[i]);
            textBox25.BackColor = Color.FromArgb(255, hetR, hetG, 0);
            i++;
            rgb_f(Arr[i]);
            textBox26.BackColor = Color.FromArgb(255, hetR, hetG, 0);
            i++;
            rgb_f(Arr[i]);
            textBox27.BackColor = Color.FromArgb(255, hetR, hetG, 0);
            i++;
            rgb_f(Arr[i]);
            textBox28.BackColor = Color.FromArgb(255, hetR, hetG, 0);
            i++;
            rgb_f(Arr[i]);
            textBox29.BackColor = Color.FromArgb(255, hetR, hetG, 0);
            i++;
            rgb_f(Arr[i]);
            textBox30.BackColor = Color.FromArgb(255, hetR, hetG, 0);
            i++;
            rgb_f(Arr[i]);
            textBox31.BackColor = Color.FromArgb(255, hetR, hetG, 0);
            i++;
            rgb_f(Arr[i]);
            textBox32.BackColor = Color.FromArgb(255, hetR, hetG, 0);
            i++;
            rgb_f(Arr[i]);
            textBox33.BackColor = Color.FromArgb(255, hetR, hetG, 0);
            i++;
            rgb_f(Arr[i]);
            textBox34.BackColor = Color.FromArgb(255, hetR, hetG, 0);
            i++;
            rgb_f(Arr[i]);
            textBox35.BackColor = Color.FromArgb(255, hetR, hetG, 0);
            i++;
            rgb_f(Arr[i]);
            textBox36.BackColor = Color.FromArgb(255, hetR, hetG, 0);
            i++;
            rgb_f(Arr[i]);
            textBox37.BackColor = Color.FromArgb(255, hetR, hetG, 0);
            i++; 
            rgb_f(Arr[i]);
            textBox38.BackColor = Color.FromArgb(255, hetR, hetG, 0);
            i++;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Boxes();
            Completion();
            Colors();
            pictureBox1.Visible = true;
        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            picture.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            textBox15.Visible = false;
            textBox16.Visible = false;
            textBox17.Visible = false;
            textBox18.Visible = false;
            textBox19.Visible = false;
            textBox20.Visible = false;
            textBox21.Visible = false;
            textBox22.Visible = false;
            textBox23.Visible = false;
            textBox24.Visible = false;
            textBox25.Visible = false;
            textBox26.Visible = false;
            textBox27.Visible = false;
            textBox28.Visible = false;
            textBox29.Visible = false;
            textBox30.Visible = false;
            textBox31.Visible = false;
            textBox32.Visible = false;
            textBox33.Visible = false;
            textBox34.Visible = false;
            textBox35.Visible = false;
            textBox36.Visible = false;
            textBox37.Visible = false;
            textBox38.Visible = false;
            pictureBox1.Visible = false;
            int Error = 0;
            this.chart1.Series[0].Points.Clear();
            this.chart1.Series[1].Points.Clear();
            for (int i = 0; i < 38; i++)
            {
                Error += Teor[i] - Prakt[i];
                this.chart1.Series[0].Points.AddXY(LLong[i], Teor[i]);
                this.chart1.Series[1].Points.AddXY(LLong[i], Prakt[i]);
            }
            //  chart1.Visible = false;
            TextBox MyTextBox = new TextBox();
            Label MyLabel = new Label();
            MyLabel.Top = 335;
            MyLabel.Left = 810;
            MyTextBox.Top = 350;
            MyTextBox.Left = 800;
            this.Controls.Add(MyTextBox);
            string s1 = Error.ToString();
            MyTextBox.Text = s1;
            this.Controls.Add(MyLabel);
            MyLabel.Text = "Error: ";
        }
    
    private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
         
            House();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
