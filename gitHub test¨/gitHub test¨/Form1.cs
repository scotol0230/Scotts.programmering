using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gitHub_test_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Metod();
        }
        void Metod()
        {
            double radie = double.Parse(textBox1.Text);
            double area = (radie * radie) * Math.PI;
            textBox2.Text = area.ToString();
        }

    }
}
