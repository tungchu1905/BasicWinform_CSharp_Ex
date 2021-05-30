using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Security_Panel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxCal.TextLength < 4)
                textBoxCal.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxCal.TextLength < 4)
                textBoxCal.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxCal.TextLength < 4)
                textBoxCal.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBoxCal.TextLength < 4)
                textBoxCal.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBoxCal.TextLength < 4)
                textBoxCal.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBoxCal.TextLength < 4)
                textBoxCal.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBoxCal.TextLength < 4)
                textBoxCal.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBoxCal.TextLength < 4)
                textBoxCal.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBoxCal.TextLength < 4)
                textBoxCal.Text += button9.Text;
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            if (textBoxCal.TextLength < 4)
                textBoxCal.Text += button0.Text;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxCal.Text = "";
        }
        string[] pass = {"6990","6999","0100","9998","1006","1007","1008" };
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            bool check = false;
            DateTime now = DateTime.Now;
            for (int i = 0; i < pass.Length; i++)
            {
                if (textBoxCal.Text.Equals(pass[i]))
                {
                    check = true;
                    break;
                }
            }
            if(check == true)
            {
                listBox1.Items.Add(now + " Access Success!");
            }
            else
            {
                listBox1.Items.Add(now + " Access Denie!");
            }
            

        }
    }
}
