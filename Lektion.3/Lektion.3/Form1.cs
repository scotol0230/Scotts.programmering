using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lektion._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
   

        private void Button1_Click_1(object sender, EventArgs e)
        {
            string text = textBox3.Text;
            int nummer = int.Parse(textBox2.Text);
            int år1 = nummer + 50;
            
            label2.Text = år1  + " fyller " + text + " 50 år.";

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {
          
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
