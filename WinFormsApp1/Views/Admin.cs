using Avia.DB;
using AviaApp.Utils;
using DB;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
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
    public partial class Admin : Form
    {
        DBContext dbContext { get; set; }
        public Admin()
        {
            InitializeComponent();
            dbContext = new DBContext();
            GetAdminPanel();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            dbContext.Dispose();
        }

        private void GetAdminPanel()
        {
            // Obtén todas las propiedades DbSet en el contexto
            var dbSetProperties = dbContext.GetType().GetProperties()
                .Where(p => p.PropertyType.IsGenericType &&
                            p.PropertyType.GetGenericTypeDefinition() == typeof(DbSet<>));

            Panel panel = new FlowLayoutPanel { Dock = DockStyle.Fill, FlowDirection = FlowDirection.LeftToRight, WrapContents = true, AutoSize=true };

            foreach (var dbSetProperty in dbSetProperties)
            {
                var entityType = dbSetProperty.PropertyType.GetGenericArguments().First();

                // Crea un botón para cada DbSet
                Button button = new MaterialButton
                {
                    Text = dbSetProperty.Name,
                    Tag = entityType,
                    Width = 120,
                    Height = 40,
                    Margin = new Padding(5),
                    //Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleCenter,

                };

                button.Click += (sender, e) => OpenGenericCrudForm(entityType);
                panel.Controls.Add(button);
            }

            Controls.Add(panel);
        }


        private void OpenGenericCrudForm(Type entityType)
        {
            var genericType = typeof(GenericCrudForm<>).MakeGenericType(entityType);
            var genericCrudForm = Activator.CreateInstance(genericType, dbContext ) as Form;

            genericCrudForm?.Show();
        }

    }
}
