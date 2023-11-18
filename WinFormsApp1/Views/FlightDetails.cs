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
using DB;
using Avia.DB;

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

        //public FlightDetails()
        //{
        //    InitializeComponent();
        //    materialSkinManager = MaterialSkinManager.Instance;
        //    materialSkinManager.AddFormToManage(this);
        //    materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

        //    InitializeComponents();
        //}

        public FlightDetails(Vuelo vuelo, dynamic weatherData)
        {
            InitializeComponent();
            InitializeComponents(vuelo, weatherData);
        }

        private void InitializeComponents(Vuelo vuelo, dynamic weatherData)
        {
            this.Size = new Size(380, 380);
            Text = "Detalles del Vuelo";
            DockStyle sharedDockStyle = DockStyle.Top;
            DBContext dbContext = new DBContext();

            Panel materialCard = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
            };

            PictureBox pictureBox = new PictureBox
            {
                Size = new Size(120, 120),
                ImageLocation = vuelo.CiudadDestinoImg,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Dock = sharedDockStyle,
            };

            var lblHoraSalida = new MaterialLabel
            {
                Text = $"Hora de Salida: {vuelo.HoraSalida}",
                Dock = sharedDockStyle,
            };

            var lblHoraLlegada = new MaterialLabel
            {
                Text = $"Hora de Llegada: {vuelo.HoraLlegada}",
                Dock = sharedDockStyle,
            };

            var lblCiudadOrigen = new MaterialLabel
            {
                Text = $"Ciudad origen: {dbContext.Ciudades.Where((ciudad) => ciudad.id == vuelo.CiudadOrigenId).First().Nombre}",
                Dock = sharedDockStyle,
            };

            var lblCiudadDestino = new MaterialLabel
            {
                Text = $"Ciudad destino: {dbContext.Ciudades.Where((ciudad) => ciudad.id == vuelo.CiudadDestinoId).First().Nombre}",
                Dock = sharedDockStyle,
            };


            var lblPrecio = new MaterialLabel
            {
                Text = $"Precio: {vuelo.Precio}",
                Dock = sharedDockStyle,
            };

            materialCard.Controls.Add(lblHoraSalida);
            materialCard.Controls.Add(lblHoraLlegada);
            materialCard.Controls.Add(lblCiudadOrigen);
            materialCard.Controls.Add(lblCiudadDestino);
            materialCard.Controls.Add(lblPrecio);
            materialCard.Controls.Add(pictureBox);
            this.Controls.Add(materialCard);
            dbContext.Dispose();
        }

    }
}
