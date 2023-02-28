namespace S4L1_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

            int[] S = new int[21];
            for (int i = 0; i < 21; i++)
            {
                S[i] = i * i;
            }

            int buf;
            for (int i = 1; i <= 20; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    buf = S[i] - S[j];
                    for (int k = 1; k < i; k++)
                    {
                        if (buf == S[k])
                        {
                            textBox1.Text += $"{j}^2 + {k}^2 = {i}^2 \r\n";
                            //std::cout << j << "^2 + " << k << "^2 = " << i << "^2\n";
                        }
                        else
                        {
                            if (buf < S[k])
                                break;
                        }
                    }
                }
            }
        }
    }
}