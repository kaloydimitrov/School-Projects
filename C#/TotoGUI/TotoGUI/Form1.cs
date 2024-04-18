namespace TotoGUI
{
    public partial class Form1 : Form
    {
        class Toto
        {
            private int[] array;
            int cnt, from;
            private int sh = 10000;

            public Toto(int cnt, int from)
            {
                this.cnt = cnt;
                this.from = from;
            }

            private void FillNumbers()
            {
                array = new int[from];
                for (int i = 1; i < from; i++)
                {
                    array[i] = i;
                }
            }

            private void Shuffle()
            {
                Random r = new Random();

                for (int i = 0; i < sh; i++)
                {
                    int x = r.Next(); x = x % from;
                    int y = r.Next(); y = y % from;
                    int temp = array[x]; array[x] = array[y]; array[y] = temp;
                }
            }

            public int[] Get()
            {
                FillNumbers(); Shuffle();
                int[] getArray = new int[cnt];

                for (int i = 0; i < cnt; i++)
                {
                    getArray[i] = array[i];
                }

                return getArray;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label6.Visible = true;

                Toto t = new Toto(6, 49);
                int[] numbersArray = t.Get();

                label1.Text = numbersArray[0].ToString();
                label2.Text = numbersArray[1].ToString();
                label3.Text = numbersArray[2].ToString();
                label4.Text = numbersArray[3].ToString();
                label5.Text = numbersArray[4].ToString();
                label6.Text = numbersArray[5].ToString();
            }
            else if (radioButton2.Checked)
            {
                label6.Visible = false;

                Toto t = new Toto(5, 35);
                int[] numbersArray = t.Get();

                label1.Text = numbersArray[0].ToString();
                label2.Text = numbersArray[1].ToString();
                label3.Text = numbersArray[2].ToString();
                label4.Text = numbersArray[3].ToString();
                label5.Text = numbersArray[4].ToString();
            }
            else if (radioButton3.Checked)
            {
                label6.Visible = true;

                Toto t = new Toto(6, 42);
                int[] numbersArray = t.Get();

                label1.Text = numbersArray[0].ToString();
                label2.Text = numbersArray[1].ToString();
                label3.Text = numbersArray[2].ToString();
                label4.Text = numbersArray[3].ToString();
                label5.Text = numbersArray[4].ToString();
                label6.Text = numbersArray[5].ToString();
            }
        }
    }
}