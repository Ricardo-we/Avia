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
            // Configuración del formulario
            Size = new Size(400, 300);
            int initialY = 200;
            Text = "Detalles del Vuelo";

            // Agregar controles y mostrar información (ajusta según tus necesidades)
            // Ejemplo: Mostrar la imagen de la ciudad destino
            PictureBox pictureBox = new PictureBox
            {
                Location = new Point(20, initialY + 20),
                Size = new Size(120, 120),
                ImageLocation = vuelo.CiudadDestinoImg,
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            // Ejemplo: Mostrar horarios, precio y pronóstico del clima
            Label lblHoraSalida = new MaterialLabel
            {
                Location = new Point(160, initialY +  20),
                Text = $"Hora de Salida: {vuelo.HoraSalida}"
            };

            Label lblHoraLlegada = new Label
            {
                Location = new Point(160, initialY + 50),
                Text = $"Hora de Llegada: {vuelo.HoraLlegada}"
            };

            Label lblPrecio = new Label
            {
                Location = new Point(160, initialY + 80),
                Text = $"Precio: {vuelo.Precio:C}"
            };

            //Label lblClima = new Label
            //{
            //    Location = new System.Drawing.Point(160, 110),
            //    Text = $"Clima: {weatherData?.condition?.text}, Temperatura: {weatherData?.temp_c}°C"
            //};

            // Agregar los controles al formulario
            this.Controls.Add(pictureBox);
            this.Controls.Add(lblHoraSalida);
            this.Controls.Add(lblHoraLlegada);
            this.Controls.Add(lblPrecio);
            //this.Controls.Add(lblClima);
        }


    }
}
