using MaterialSkin.Controls;
using MaterialSkin;
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
    public partial class FlightDetails : MaterialForm
    {
        private MaterialComboBox txtCiudadOrigen;
        private MaterialComboBox txtCiudadDestino;
        private DateTimePicker dateTimePickerFechaIda;
        private DateTimePicker dateTimePickerFechaVuelta;
        private Button btnBuscarVuelos;
        private Panel panelTarjetas;
        private readonly MaterialSkinManager materialSkinManager;

        public FlightDetails()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            InitializeComponents();
        }

        private void InitializeComponents()
        {
            int initialY = 100;
            this.Size = new Size(800, 600);
            this.Text = "Reserva de Vuelo";

            txtCiudadOrigen = new MaterialComboBox();
            txtCiudadOrigen.Location = new Point(20, initialY + 20);
            txtCiudadOrigen.Size = new Size(200, 30);
            txtCiudadOrigen.Hint = "Ciudad de Origen";


            txtCiudadDestino = new MaterialComboBox();
            txtCiudadDestino.Location = new Point(240, initialY + 20);
            txtCiudadDestino.Size = new Size(200, 30);
            txtCiudadDestino.Hint = "Ciudad de Destino";

            //using (var context = new DBContext())
            //{
            //    txtCiudadOrigen.DataSource = context.Ciudades.ToList();
            //    txtCiudadOrigen.DisplayMember = "Nombre";
            //    txtCiudadOrigen.ValueMember = "Nombre";

            //    txtCiudadDestino.DataSource = context.Ciudades.ToList();
            //    txtCiudadDestino.DisplayMember = "Nombre";
            //    txtCiudadDestino.ValueMember = "Nombre";
            //}


            dateTimePickerFechaIda = new DateTimePicker();
            dateTimePickerFechaIda.Location = new Point(20, initialY + 70);

            dateTimePickerFechaVuelta = new DateTimePicker();
            dateTimePickerFechaVuelta.Location = new Point(240, initialY + 70);

            btnBuscarVuelos = new Button();
            btnBuscarVuelos.Location = new Point(20, initialY + 120);
            btnBuscarVuelos.Size = new Size(120, 40);
            btnBuscarVuelos.Text = "Buscar Vuelos";
            //btnBuscarVuelos.Click += btnBuscarVuelos_Click;

            panelTarjetas = new Panel();
            panelTarjetas.Location = new Point(20, initialY + 170);
            panelTarjetas.Size = new Size(760, 400);
            panelTarjetas.BorderStyle = BorderStyle.FixedSingle;

            this.Controls.Add(txtCiudadOrigen);
            this.Controls.Add(txtCiudadDestino);
            this.Controls.Add(dateTimePickerFechaIda);
            this.Controls.Add(dateTimePickerFechaVuelta);
            this.Controls.Add(btnBuscarVuelos);
            this.Controls.Add(panelTarjetas);
        }


    }
}
