namespace Practice1
{
    public partial class Form1 : Form
    {
        int counter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (counter < 10)
            {
                counter++;
                label1.Text = counter.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (counter > 0)
            {
                counter--;
                label1.Text = counter.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.MediumTurquoise;
            counter = 0;
            label1.Text = counter.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (counter > 0)
            {
                counter--;
                label1.Text = counter.ToString();
            }
        }
    }
}