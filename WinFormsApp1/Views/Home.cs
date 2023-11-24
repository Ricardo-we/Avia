using Avia.DB;
using AviaApp.Services;
using AviaApp.Utils;
using DB;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AviaApp.Views
{
    public partial class Home : MaterialForm
    {
        private MaterialComboBox txtCiudadOrigen;
        private MaterialComboBox txtCiudadDestino;
        private DateTimePicker dateTimePickerFechaIda;
        private DateTimePicker dateTimePickerFechaVuelta;
        private Button btnBuscarVuelos;
        private Panel panelTarjetas;
        private readonly MaterialSkinManager materialSkinManager;
        public Home()
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

            using (var context = new DBContext())
            {
                txtCiudadOrigen.DataSource = context.Ciudades.ToList();
                txtCiudadOrigen.DisplayMember = "Nombre";
                txtCiudadOrigen.ValueMember = "Nombre";

                txtCiudadDestino.DataSource = context.Ciudades.ToList();
                txtCiudadDestino.DisplayMember = "Nombre";
                txtCiudadDestino.ValueMember = "Nombre";
            }


            dateTimePickerFechaIda = new DateTimePicker();
            dateTimePickerFechaIda.Location = new Point(20, initialY + 70);

            dateTimePickerFechaVuelta = new DateTimePicker();
            dateTimePickerFechaVuelta.Location = new Point(240, initialY + 70);

            btnBuscarVuelos = new Button();
            btnBuscarVuelos.Location = new Point(20, initialY + 120);
            btnBuscarVuelos.Size = new Size(120, 40);
            btnBuscarVuelos.Text = "Buscar Vuelos";
            btnBuscarVuelos.Click += btnBuscarVuelos_Click;

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


        private void btnBuscarVuelos_Click(object sender, EventArgs e)
        {
            string ciudadOrigen = txtCiudadOrigen.Text;
            string ciudadDestino = txtCiudadDestino.Text;
            DateTime fechaIda = dateTimePickerFechaIda.Value;
            DateTime fechaVuelta = dateTimePickerFechaVuelta.Value;

            using (var context = new DBContext())
            {
                var resultados = context.Vuelos
                    .Where(tarjeta =>
                        (tarjeta.CiudadOrigen.Nombre == ciudadOrigen
                        && tarjeta.CiudadDestino.Nombre == ciudadDestino)
                        && (tarjeta.FechaIda.Date >= fechaIda.Date
                        && tarjeta.FechaVuelta.Date <= fechaVuelta.Date)
                    )
                    .ToList();
                MostrarResultados(resultados);
            }
        }

        private void MostrarResultados(List<Vuelo> resultados)
        {
            panelTarjetas.Controls.Clear();
            if (resultados.Count <= 0)
            {
                panelTarjetas.Controls.Add(new Label { Dock = DockStyle.Top, Text = "No se encontraron datos." });
                return;
            }

            foreach (var tarjeta in resultados)
            {
                DockStyle sharedDockStyle = DockStyle.Bottom;

                var materialCard = new MaterialCard
                {
                    Width = 350,
                    Height = 240,
                    //Margin = new Padding { Left = 20, Right = 20 },
                    Controls = {
                        new MaterialLabel
                        {
                            FontType = MaterialSkinManager.fontType.H6,
                            Text = $"Ver detalles",
                            Dock = sharedDockStyle
                        },
                        new MaterialLabel
                        {
                            Text = $"Precio: {tarjeta.Precio:C}",
                            Dock = sharedDockStyle,
                        },
                        new MaterialLabel
                        {
                            Text = $"Hora de salida: {tarjeta.HoraSalida}",
                            Dock = sharedDockStyle
                        },
                        new MaterialLabel
                        {
                            Text = $"Hora de llegada: {tarjeta.HoraLlegada}",
                            Dock = sharedDockStyle
                        },
                        new PictureBox
                        {
                            ImageLocation = tarjeta.CiudadDestinoImg,
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Dock = sharedDockStyle,
                            Width = 220,
                            Height = 120
                        },
                    },
                };

                var detailsButton = new MaterialButton
                {
                    Dock = sharedDockStyle,
                    Text = "Ver detalles del vuelo",
                    Type = MaterialButton.MaterialButtonType.Outlined,
                };

                detailsButton.Click += async (sender, e) => await MostrarDetallesVuelo(tarjeta);
                materialCard.Controls.Add(detailsButton);

                panelTarjetas.Controls.Add(materialCard);
            }
        }

        private async Task MostrarDetallesVuelo(Vuelo vuelo)
        {
            using (DBContext db = new DBContext())
            {
                Ciudad ciudadDestino = db.Ciudades.Where((ciudad) => ciudad.id == vuelo.CiudadDestinoId).First();
                var weatherData = await WeatherService.GetWeather(vuelo.FechaIda, ciudadDestino.Nombre);
                new FlightDetails(vuelo, weatherData).Show();
            }

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

        private void equipajeButton_Click(object sender, EventArgs e)
        {
            new EquipajeForm().Show();
        }
    }
}
