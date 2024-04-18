using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvenAndOddAndSquareFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n = double.Parse(textBox1.Text);

            if (n % 2 == 0)
            {
                label3.Text = "Да";
            }
            else
            {
                label3.Text = "Не";
            }
        }
    }
}
