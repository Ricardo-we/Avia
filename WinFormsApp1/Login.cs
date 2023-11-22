using Avia.DB;
using AviaApp;
using AviaApp.Services;
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
            var response = WeatherService.GetWeather();
            Debug.WriteLine(response);
        }


        private void signUpButton_Click_1(object sender, EventArgs e)
        {
            new SignUp().Show();
            this.Dispose();
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
                SharedData.user = user;
                this.Dispose();
                if(user.rol == "admin")
                {
                    new Admin().Show();
                    return;
                }
                new Home().Show();
            } catch (Exception ex)
            {
                MessageBox.Show("El usuario ingresado no existe o algún dato es inválido");
            }
        }
    }
}