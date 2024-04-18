using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YardForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double yard = double.Parse(textBox1.Text);

            double price = yard * 7.61;
            double discount = price * 0.18;

            double finalPrice = price - discount;

            label4.Text = finalPrice.ToString();
            label5.Text = discount.ToString();
        }
    }
}
