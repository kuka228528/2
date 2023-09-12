namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newform = new Form2();
            newform.Show();
        }

       // private void button2_Click(object sender, EventArgs e)
      //  {
       //     Form3 newform = new Form3();
       //     newform.Show();
       // }

      // private void button3_Click(object sender, EventArgs e)
      // {
       //     Form4 newform = new Form4();
      //      newform.Show();
       // }
    }
}