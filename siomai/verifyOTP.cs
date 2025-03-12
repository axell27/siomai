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
    public partial class verifyOTP : Form
    {
        private string currentUsername;
        private string generatedOTP;
        private DateTime otpExpirationTime;

        public verifyOTP(string username, string otp, DateTime expirationTime)
        {
            InitializeComponent();
            currentUsername = username;
            generatedOTP = otp;
            otpExpirationTime = expirationTime;
        }

        private void verifyOTPButton_Click(object sender, EventArgs e)
        {
            string enteredOTP = otpTextBox.Text.Trim();

            if (string.IsNullOrEmpty(enteredOTP))
            {
                MessageBox.Show("Please enter the OTP.");
                return;
            }

            if (DateTime.Now > otpExpirationTime)
            {
                MessageBox.Show("OTP has expired. Please request a new one.");
                this.Close();
                return;
            }

            if (enteredOTP == generatedOTP)
            {
                MessageBox.Show("OTP verified successfully! Proceed to reset your password.");
                this.Hide();
                resetPassword resetForm = new resetPassword(currentUsername);
                resetForm.Show();
            }
            else
            {
                MessageBox.Show("Incorrect OTP. Please try again.");
            }
        }
    }
}
