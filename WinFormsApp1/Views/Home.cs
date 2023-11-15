using AviaApp.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AviaApp.Views
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            FormUtils.OnFormClosing(this);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new FormAsientos().Show();
        }
    }
}
