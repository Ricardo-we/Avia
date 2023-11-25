using Avia.DB;
using DB;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AviaApp
{
    public partial class MisVuelosForm : MaterialForm
    {
        private List<Asiento> listaAsientos;

        public MisVuelosForm()
        {
            InitializeComponent();

            // Configuración del tema Material Skin
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue600, Primary.Blue700,
                Primary.Blue400, Accent.Blue400,
                TextShade.WHITE
            );

            listaAsientos = ObtenerAsientosDesdeLaBaseDeDatos();

            CrearComponentes();
        }

        private List<Asiento> ObtenerAsientosDesdeLaBaseDeDatos()
        {
            using (DBContext db = new DBContext())
            {
                return db.Asientos.Where((asiento) => asiento.UserId == SharedData.user.id).ToList();
            }
        }

        private void CrearComponentes()
        {
            var panelContenedor = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
            };

            var cardList = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = true,
            };

            var sharedDockStyle = DockStyle.Bottom;

            foreach (var asiento in listaAsientos)
            {
                var card = new MaterialCard
                {
                    Size = new Size(250, 250), 
                    Dock = DockStyle.Bottom,
                    Depth = 0,
                };

                Vuelo? vueloData;
                using (DBContext db = new DBContext())
                {
                    vueloData = db.Vuelos.Where((vuelo) => vuelo.id == asiento.VueloId).FirstOrDefault();
                }

                var cardImage = new PictureBox
                {
                    ImageLocation = vueloData.CiudadDestinoImg,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Dock = sharedDockStyle,
                    Width = 220,
                    Height = 120
                };

                var cardContent = new MaterialLabel
                {
                    Text = $"Asiento {asiento.Numero}",
                    FontType = MaterialSkinManager.fontType.H5,
                    Dock = sharedDockStyle,
                };

                var claseLabel = new MaterialLabel
                {
                    Text = $"Clase: {asiento.Clase}",
                    FontType = MaterialSkinManager.fontType.Subtitle2,
                    Dock = sharedDockStyle,
                };

                var reservadoLabel = new MaterialLabel
                {
                    Text = $"Reservado: " + (asiento.Reservado ? "Sí" : "No"),
                    FontType = MaterialSkinManager.fontType.Subtitle1,
                    Dock = sharedDockStyle,
                };

                card.Controls.Add(cardImage);
                card.Controls.Add(cardContent);
                card.Controls.Add(claseLabel);
                card.Controls.Add(reservadoLabel);

                cardList.Controls.Add(card);
            }

            panelContenedor.Controls.Add(cardList);
            Controls.Add(panelContenedor);
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
