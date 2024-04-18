using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUICalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double firstValue = double.Parse(textBox1.Text);
            double secondValue = double.Parse(textBox2.Text);

            double result = 0;

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    result = firstValue / secondValue;
                    break;
                case 1:
                    result = firstValue * secondValue;
                    break;
                case 2:
                    result = firstValue + secondValue;
                    break;
                case 3:
                    result = firstValue - secondValue;
                    break;
            }

            label1.Text = $"Result: {result}";
        }
    }
}
