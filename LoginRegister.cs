using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class LoginRegister : Form
    {
      
        private const string USERNAME = "admin";
        private const string PASSWORD = "123";

        public LoginRegister()
        {
            InitializeComponent();

            lblTitle.Text = "LOGIN";
            lblTitle.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            btnLogin.Text = "Login";

            txtbxpass.UseSystemPasswordChar = true;

            btnLogin.Click += btnLogin_Click;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtbxuser.Text.Trim();
            string password = txtbxpass.Text;

            if (username == USERNAME && password == PASSWORD)
            {
                MessageBox.Show(
                    "Login successful!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                Form1 mainForm = new Form1();
                mainForm.FormClosed += (s, args) => this.Close(); 
                mainForm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show(
                    "Invalid username or password.",
                    "Login Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                txtbxpass.Clear();
                txtbxpass.Focus();
            }
        }
    }
}
