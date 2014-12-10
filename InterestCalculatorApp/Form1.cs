using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterestCalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bank = comboBox1.Text;
            double time = Convert.ToDouble(textBox1.Text);
            double prAmount = Convert.ToDouble(textBox2.Text);
            if (bank == "BRAC")
            {
                double tbbrac = prAmount * time * 6;
                double tbbrac3 = tbbrac / 100;
                textBox3.Text = tbbrac3.ToString();
            }
            else if (bank == "DBBL")
            {
                double tbdbbl = prAmount * time * 7;
                double tbdbbl3 = tbdbbl / 100;
                textBox3.Text = tbdbbl3.ToString();
            }
            else
            {
                double tbhsbc = prAmount * time * 8;
                double tbhsbc3 = tbhsbc / 100;
                textBox3.Text = tbhsbc3.ToString();
            }
        }
    }
}
