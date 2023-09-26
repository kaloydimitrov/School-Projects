using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Shape_Homework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Shape Homework";

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = false;
            textBox2.Visible = false;

            label3.Visible = false;
            textBox3.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            textBox2.Visible = true;

            label3.Visible = false;
            textBox3.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            textBox2.Visible = true;

            label3.Visible = true;
            textBox3.Visible = true;
        }

        // Checks if value of TextBox is valid
        bool isValid(string tbInput)
        {
            if ((Regex.IsMatch(tbInput, @"^\d+$")) && (double.Parse(tbInput) > 0))
            {
                return true;
            }

            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, P, S, p;


            if (radioButton1.Checked)
            {
                string tb1Input = textBox1.Text;

                if (isValid(tb1Input))
                {
                    a = double.Parse(tb1Input);

                    // Perimeter
                    label4.Text = $"{a * 4}";
                    // Area
                    label5.Text = $"{a * a}";
                }
                else
                {
                    label4.Text = "Error";
                    label5.Text = "Error";
                }
            }

            else if (radioButton2.Checked)
            {
                string tb1Input = textBox1.Text;
                string tb2Input = textBox2.Text;

                if (isValid(tb1Input) && isValid(tb2Input))
                {
                    a = double.Parse(tb1Input);
                    b = double.Parse(tb2Input);

                    // Perimeter
                    label4.Text = $"{(a + b) * 2}";
                    // Area
                    label5.Text = $"{a * b}";
                }
                else
                {
                    label4.Text = "Error";
                    label5.Text = "Error";
                }
            }

            else if (radioButton3.Checked)
            {
                string tb1Input = textBox1.Text;
                string tb2Input = textBox2.Text;
                string tb3Input = textBox3.Text;

                if (isValid(tb1Input) && isValid(tb2Input) && isValid(tb3Input))
                {
                    a = double.Parse(tb1Input);
                    b = double.Parse(tb2Input);
                    c = double.Parse(tb3Input);

                    P = a + b + c;
                    p = P / 2;
                    S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                    // Perimeter
                    label4.Text = $"{P}";
                    // Area
                    label5.Text = $"{S}";
                }
                else
                {
                    label4.Text = "Error";
                    label5.Text = "Error";
                }
            }
        }
    }
}
