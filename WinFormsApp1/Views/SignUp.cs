using Avia.DB;
using AviaApp.Utils;
using DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace AviaApp.Views
{
    public partial class SignUp : Form
    {
        public DBContext dbContext = new DBContext();

        public SignUp()
        {
            InitializeComponent();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Dispose();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            FormUtils.OnFormClosing(this);
        }


        private bool validateForm(int? ageIntVal)
        {
            bool isValid = true;
            if (ageIntVal < 18 || ageIntVal == null)
            {
                MessageBox.Show("Debe ser mayor de edad");
                isValid = false;
            }

            if (dpi.Text.Length < 13 || dpi.Text.Length > 13 || int.TryParse(dpi.Text, out int v))
            {
                MessageBox.Show("El dpi no es valido");
                isValid = false;
            }

            return isValid;
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            int ageIntVal = 0;
            int.TryParse(age.Text, out ageIntVal);

            if (!validateForm(ageIntVal)) {
                return;
            } 

            User user = new User
            {
                age = ageIntVal,
                dpi = dpi.Text,
                name = name.Text,
                password = password.Text,
            };
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
            SharedData.user = user;

            this.Close();
            Home home = new Home();
            home.Show();
        }
    }
}
