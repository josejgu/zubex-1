using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TrackingControl
{
    public partial class opeAlmacen : Form
    {
        public opeAlmacen()
        {
            InitializeComponent();
        }

        private void opeAlmacen_Load(object sender, EventArgs e)
        {

        }

        private void cmdImprimir_Click(object sender, EventArgs e)
        {
            // Habilita boton de guardar
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            // Guarda observaciones y cambio de estatus
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            // Cancela modificaciones
            pnlOperativo.Enabled = true;
            pnlObservaciones.Visible = false;
            pnlObservaciones.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pnlObservaciones.Visible = true;
            pnlObservaciones.Enabled = true;
            pnlOperativo.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
