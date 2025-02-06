namespace siomai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            login loginForm = new login();
            loginForm.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            register registerForm = new register();
            registerForm.Show();
        }
    }
}
