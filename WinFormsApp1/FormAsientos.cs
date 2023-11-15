using Avia.DB;
using AviaApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AviaApp
{
    public partial class FormAsientos : Form
    {
        private readonly DBContext dbContext = new DBContext();
        private int rangoInicio = 0;
        private int rangoFin = 0;
        public FormAsientos()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormAsientos_Load(object sender, EventArgs e)
        {
            HabilitarAsientos();
        }

        private void HabilitarAsientos()
        {
            foreach (Control control in Controls)
            {
                if (control is Button btnAsiento)
                {
                    int numeroAsiento;
                    if (int.TryParse(btnAsiento.Text, out numeroAsiento))
                    {
                        btnAsiento.Enabled = numeroAsiento >= rangoInicio && numeroAsiento <= rangoFin;
                    }
                }
            }
        }

        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialRadioButton2.Checked)
            {
                pictureBox3.Image = AviaApp.Properties.Resources.clase_vip;
                rangoInicio = 1;
                rangoFin = 25;
                HabilitarAsientos();
            }
        }

        private void materialRadioButton3_CheckedChanged(object sender, EventArgs e)
        {

            if (materialRadioButton3.Checked)
            {
                pictureBox3.Image = AviaApp.Properties.Resources.clase_empresarial;
                rangoInicio = 26;
                rangoFin = 65;
                HabilitarAsientos();
            }
        }

        private void materialRadioButton2_CheckedChanged(object sender, EventArgs e)
        {

            if (materialRadioButton1.Checked)
            {
                pictureBox3.Image = AviaApp.Properties.Resources.clase_turista;
                rangoInicio = 66;
                rangoFin = 125;
                HabilitarAsientos();

            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is Button btnAsiento && btnAsiento.BackColor == Color.Green)
                {
                    int numeroAsiento;
                    if (int.TryParse(btnAsiento.Text, out numeroAsiento))
                    {
                        var asiento = dbContext.Asientos.SingleOrDefault(a => a.Numero == numeroAsiento);

                        if (asiento != null && !asiento.Reservado)
                        {
                            asiento.Reservado = true;
                            dbContext.SaveChanges(); 

                            btnAsiento.BackColor = Color.Red;

                            MessageBox.Show($"Asiento {numeroAsiento} reservado con éxito.", "Asiento Reservado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Este asiento ya está ocupado. Por favor, elige otro.", "Asiento Ocupado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al convertir el número de asiento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new Home().Show();
        }
    }
}