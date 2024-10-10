namespace Velocify_v1._1
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

        private void gameButton_Click(object sender, EventArgs e)
        {
            
            APITestForm APIForm = new APITestForm();
            APIForm.Show();
            this.Hide();

            MessageBox.Show("Hello World!");
        }

        private void gameAddButton1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
