using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string archName = textBox1.Text;
            int projects = int.Parse(textBox2.Text);

            label1.Text = $"The architext {archName} will need {projects * 3} hours to complete {projects} project/s.";
        }
    }
}
