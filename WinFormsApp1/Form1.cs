namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void MHower(object sender, EventArgs e)
        {
            int a = ClientSize.Width;
            int b = ClientSize.Height;
            int c = Random.Shared.Next(0, a) - button1.Width;
            int d = Random.Shared.Next(0, b) - button1.Height;
            button1.Location = new Point(c, d);
        }
    }
}