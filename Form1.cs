namespace fukuv0615
{
    public partial class Form1 : Form
    {
        static Random rand = new Random();

        int ans = rand.Next(0, 101);
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count += 1;
            MessageBox.Show($"{count}‰ñ–Ú‚Ì’§í");

            int guess = int.Parse(textBox1.Text);
            if (guess == ans)
            {
                MessageBox.Show("Bingo!!");
                count = 0;
                ans = rand.Next(0, 101);
            }
            else if (guess > ans)
            {
                MessageBox.Show("Greater");
            }
            else
            {
                MessageBox.Show("Less");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}