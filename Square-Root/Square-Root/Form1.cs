namespace Square_Root
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double eps = double.Parse(textBox2.Text);
            double x = a / 2;

            while (true)
            {
                double xs = x;
                x = (x + a / x) / 2;

                if (Math.Abs(xs - x) < eps)
                {
                    break;
                }
            }

            label4.Text = x.ToString();
        }
    }
}