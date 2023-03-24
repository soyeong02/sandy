using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20233027_장소영__과제3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
                    

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            int sdata01 = int.Parse(textBox5.Text);
            string sdata02 = textBox2.Text;
            label4.Text = "성명 : " + sdata02 + "\n학번 : " + sdata01;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sdata03 = (textBox3.Text);
            string sdata04 = (textBox4.Text);
            label6.Text = "유선전화 : " + sdata03 + "\n무선전화 : " + sdata04;
           
        }

        private void label6_Click(object sender, EventArgs e)
        {
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = " ";
            label4.Text = " ";
        }
    }
}
