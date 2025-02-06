using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace siomai
{
    public partial class login : Form


    {

        private string connectionString = "server=127.0.0.1; database=siomai; uid=root; pwd=axell;";
        public login()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register registerForm = new register();
            registerForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
