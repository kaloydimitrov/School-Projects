namespace SquareFormApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double side = double.Parse(textBox1.Text);

            if (side > 0)
            {
                label4.Text = $"{side * side}";
                label5.Text = $"{side * 4}";
            }
            else
            {
                label4.Text = "Error";
                label5.Text = "Error";
            }
        }
    }
}