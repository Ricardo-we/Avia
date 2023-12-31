﻿using Avia.DB;
using AviaApp.Utils;
using DB;
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
    public partial class EquipajeForm : Form
    {

        public EquipajeForm()
        {
            InitializeComponent();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            double altoParsed = NumberUtils.parseDouble(alto.Text);

            Equipaje equipaje = new Equipaje
            {
                alto = altoParsed,
                ancho = NumberUtils.parseDouble(ancho.Text),
                largo = NumberUtils.parseDouble(largo.Text),
                peso = NumberUtils.parseDouble(peso.Text),
                user = SharedData.user,
            };

            using (DBContext dbContext = new DBContext())
            {
                dbContext.Equipajes.Add(equipaje);
                dbContext.SaveChanges();
            }

        }

        private void EquipajeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
