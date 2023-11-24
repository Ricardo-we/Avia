using Avia.DB;
using AviaApp.Views;
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

namespace AviaApp
{
    public partial class FormAsientos : Form
    {
        private DBContext _dbContext;
        private readonly DBContext dbContext = new DBContext();
        private int rangoInicio = 0;
        private int rangoFin = 0;

        public FormAsientos()
        {
            InitializeComponent();
            _dbContext = new DBContext();

            if (!_dbContext.Asientos.Any())
            {
                AgregarAsientos();
            }

            CargarLabels();
        }

        private void CargarLabels()
        {
            var asientos = _dbContext.Asientos.ToList();
            foreach (var asiento in asientos)
            {
                var label = Controls.Find("label" + asiento.Numero, true).FirstOrDefault() as Label;
                if (label != null)
                {
                    label.Text = asiento.Numero.ToString();

                    if (asiento.Reservado)
                    {
                        label.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        label.ForeColor = System.Drawing.Color.Black;
                    }
                }
            }
        }

        private void CargarComboBoxAsientos(int inicio, int fin)
        {
            /*var asientosFiltrados = dbContext.Asientos.Where(a => a.Numero >= inicio && a.Numero <= fin).OrderBy(a => a.Numero).ToList();

            // Ordenar la lista de asientos por número nuevamente (asegurándonos)
            asientosFiltrados = asientosFiltrados.OrderBy(a => a.Numero).ToList();


            comboBox1.DataSource = dbContext.Asientos.ToList();
            comboBox1.DisplayMember = "Numero";
            comboBox1.ValueMember = "Id";*/
            // Filtrar los asientos en el rango especificado y ordenar por número
            var asientosFiltrados = dbContext.Asientos
        .Where(a => a.Numero >= inicio && a.Numero <= fin)
        .OrderBy(a => a.Numero)
        .ToList();


            comboBox1.DataSource = null;
            comboBox1.DataSource = asientosFiltrados;
            comboBox1.DisplayMember = "Numero";
            comboBox1.ValueMember = "Id";

            comboBox1.Sorted = true;
        }


        private void FormAsientos_Load(object sender, EventArgs e)
        {
            HabilitarAsientos();
        }

        private void AgregarAsientosIniciales()
        {
            for (int numeroAsiento = 1; numeroAsiento <= 25; numeroAsiento++)
            {
                var existeAsiento = dbContext.Asientos.Any(a => a.Numero == numeroAsiento);

                if (!existeAsiento)
                {
                    dbContext.Asientos.Add(new Asiento { Numero = numeroAsiento, Clase = "VIP", Reservado = false });
                }
            }

            dbContext.SaveChanges();
        }

        private void CargarComboBoxAsientos()
        {
            comboBox1.DataSource = dbContext.Asientos.ToList();
            comboBox1.DisplayMember = "Numero";
            comboBox1.ValueMember = "Id";
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
                        var asiento = dbContext.Asientos.SingleOrDefault(a => a.Numero == numeroAsiento);

                        btnAsiento.Enabled = numeroAsiento >= rangoInicio && numeroAsiento <= rangoFin && asiento != null && !asiento.Reservado;

                        if (asiento != null && asiento.Reservado)
                        {
                            btnAsiento.BackColor = Color.Red;
                            btnAsiento.Enabled = false;
                        }
                    }
                }
            }
        }

        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialRadioButton1.Checked)
            {
                pictureBox2.Image = AviaApp.Properties.Resources.clase_vip;
                /*rangoInicio = 1;
                rangoFin = 25;
                HabilitarAsientos();*/
            }
        }

        private void materialRadioButton3_CheckedChanged(object sender, EventArgs e)
        {

            if (materialRadioButton3.Checked)
            {
                pictureBox2.Image = AviaApp.Properties.Resources.clase_empresarial;
                /*rangoInicio = 26;
                rangoFin = 65;
                HabilitarAsientos();*/
            }
        }

        private void materialRadioButton2_CheckedChanged(object sender, EventArgs e)
        {

            if (materialRadioButton2.Checked)
            {
                pictureBox2.Image = AviaApp.Properties.Resources.clase_turista;
                /* rangoInicio = 66;
                 rangoFin = 125;
                 HabilitarAsientos();*/

            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            var selectedAsiento = (Asiento)comboBox1.SelectedItem;

            if (selectedAsiento != null)
            {
                selectedAsiento.Reservado = true;
                dbContext.SaveChanges();

                MessageBox.Show($"Asiento {selectedAsiento.Numero} reservado con éxito.", "Asiento Reservado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarComboBoxAsientos();
                HabilitarAsientos();
            }
            else
            {
                MessageBox.Show("Selecciona un asiento antes de aceptar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AgregarAsientos()
        {/*
            for (int i = 1; i <= 25; i++)
            {
                var nuevoAsiento = new Asiento
                {
                    Numero = i,
                    Clase = "VIP",
                    Reservado = false
                };

                _dbContext.Asientos.Add(nuevoAsiento);
            }

            _dbContext.SaveChanges();*/
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new Home().Show();
        }

        private void FormAsientos_Load_1(object sender, EventArgs e)
        {

            CargarComboBoxAsientos();
            HabilitarAsientos();
            AgregarAsientosIniciales();
        }

        /* private void LiberarAsientos()
         {
             var asientos = _dbContext.Asientos.ToList();

             foreach (var asiento in asientos)
             {
                 asiento.Reservado = false;
             }

             _dbContext.SaveChanges();

             // Actualiza la interfaz gráfica para reflejar los cambios
             CargarLabels();
         }*/



        /* private void EliminarAsientos(int numeroInicio, int numeroFin)
         {
             *//* var asientosAEliminar = _dbContext.Asientos
                  .Where(a => a.Numero >= numeroInicio && a.Numero <= numeroFin)
                  .ToList();

              foreach (var asiento in asientosAEliminar)
              {
                  _dbContext.Asientos.Remove(asiento);
              }

              _dbContext.SaveChanges();*//*
         }*/


    }
}