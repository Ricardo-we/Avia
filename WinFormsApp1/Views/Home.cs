using Avia.DB;
using AviaApp.Utils;
using DB;
using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class Home : MaterialForm
    {
        private MaterialTextBox txtCiudadOrigen;
        private MaterialTextBox txtCiudadDestino;
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
            // Configuración de la ventana principal
            this.Size = new Size(800, 600);
            this.Text = "Reserva de Vuelo";

            // Configuración de los componentes
            txtCiudadOrigen = new MaterialTextBox();
            txtCiudadOrigen.Location = new Point(20, initialY + 20);
            txtCiudadOrigen.Size = new Size(200, 30);
            txtCiudadOrigen.Hint = "Ciudad de Origen";

            txtCiudadDestino = new MaterialTextBox();
            txtCiudadDestino.Location = new Point(240, initialY + 20);
            txtCiudadDestino.Size = new Size(200, 30);
            txtCiudadDestino.Hint = "Ciudad de Destino";

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

            // Agregar los componentes al formulario
            this.Controls.Add(txtCiudadOrigen);
            this.Controls.Add(txtCiudadDestino);
            this.Controls.Add(dateTimePickerFechaIda);
            this.Controls.Add(dateTimePickerFechaVuelta);
            this.Controls.Add(btnBuscarVuelos);
            this.Controls.Add(panelTarjetas);
        }


        private void btnBuscarVuelos_Click(object sender, EventArgs e)
        {
            // Obtener datos de entrada del usuario (ciudad origen, ciudad destino, fechas, etc.)
            string ciudadOrigen = txtCiudadOrigen.Text;
            string ciudadDestino = txtCiudadDestino.Text;
            DateTime fechaIda = dateTimePickerFechaIda.Value;
            DateTime fechaVuelta = dateTimePickerFechaVuelta.Value;

            // Realizar la búsqueda en la base de datos utilizando Entity Framework
            using (var context = new DBContext())
            {
                var resultados = context.TarjetasVuelo
                    .Where(tarjeta => tarjeta.Vuelo.CiudadOrigen.Nombre == ciudadOrigen &&
                                      tarjeta.Vuelo.CiudadDestino.Nombre == ciudadDestino &&
                                      tarjeta.Vuelo.FechaIda == fechaIda &&
                                      tarjeta.Vuelo.FechaVuelta == fechaVuelta)
                    .ToList();

                // Mostrar los resultados en forma de tarjetas en tu formulario
                MostrarResultados(resultados);
            }
        }

        private void MostrarResultados(List<TarjetaVuelo> resultados)
        {
            // Limpiar el panel antes de agregar nuevas tarjetas
            panelTarjetas.Controls.Clear();

            foreach (var tarjeta in resultados)
            {
                var materialCard = new MaterialCard
                {
                    Width = 200, // Ajusta el ancho según tus necesidades
                    Height = 250 // Ajusta la altura según tus necesidades
                };

                materialCard.Controls.Add(new PictureBox
                {
                    // Configurar PictureBox con la imagen de la ciudad destino, etc.
                    ImageLocation = tarjeta.CiudadDestinoImgUrl,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Dock = DockStyle.Top,
                    Height = 120 // Ajusta la altura según tus necesidades
                });

                materialCard.Controls.Add(new Label
                {
                    Text = $"Precio: {tarjeta.Precio:C}",
                    Dock = DockStyle.Top
                });

                materialCard.Controls.Add(new Label
                {
                    Text = $"Hora de salida: {tarjeta.HoraSalida}",
                    Dock = DockStyle.Top
                });

                materialCard.Controls.Add(new Label
                {
                    Text = $"Hora de llegada: {tarjeta.HoraLlegada}",
                    Dock = DockStyle.Top
                });

                materialCard.Click += (sender, e) => MostrarDetallesVuelo(tarjeta.VueloId);

                panelTarjetas.Controls.Add(materialCard);
            }
        }

        private void MostrarDetallesVuelo(int vueloId)
        {
            using (var context = new DBContext())
            {
                var detalleVuelo = context.Vuelos
                    .FirstOrDefault(detalle => detalle.id == vueloId);
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



    }
}
