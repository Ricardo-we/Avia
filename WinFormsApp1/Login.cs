using Avia.DB;
using AviaApp.Utils;
using AviaApp.Views;
using DB;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void signUpButton_Click_1(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Close();
            // this.Hide();
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            FormUtils.OnFormClosing(this);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                DBContext dbContext = new DBContext();
                var user = dbContext.Users
                    .Where((User user) => user.dpi == dpi.Text && user.password == password.Text)
                    .First();
                this.Close();
                new Home().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("El usuario ingresado no existe o alg�n dato es inv�lido");
            }
        }
    }
}