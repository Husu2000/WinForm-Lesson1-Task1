namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = 3;
            if (button1.Text == "Baku")
            {
                button1.Text = "London";
                label1.Text = DateTime.Now.AddHours(a).ToString();
                picture.Image = Properties.Resources.Baku;
            }
                else if (button1.Text == "London") 
                {
                button1.Text = "Baku";
                label1.Text=DateTime.Now.ToString();
                picture.Image= Properties.Resources.England;
                }

        }
    }
}