using AviaApp.Utils;
using AviaApp.Views;

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


        protected override void OnFormClosing(FormClosingEventArgs e) {
            FormUtils.OnFormClosing(this);
        }
    }
}