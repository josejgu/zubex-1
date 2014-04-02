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
    public partial class mdiContainer : Form
    {
        public mdiContainer()
        {
            InitializeComponent();
        }

        #region Rutinas de la página

        private void pbxAdministracion_Click(object sender, EventArgs e)
        {
            
        }

        private void pbxAlmacen_Click(object sender, EventArgs e)
        {
            opeAlmacen frmAlmacen = new opeAlmacen();
            frmAlmacen.Show();
        }

        private void pbxBolseo_Click(object sender, EventArgs e)
        {

        }

        private void pbxCargaProgPedidos_Click(object sender, EventArgs e)
        {

        }

        private void pbxCorrugado_Click(object sender, EventArgs e)
        {

        }

        private void pbxImpresion_Click(object sender, EventArgs e)
        {

        }

        private void pbxPedidos_Click(object sender, EventArgs e)
        {

        }

        private void pbxProductoTerminado_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void mdiContainer_Load(object sender, EventArgs e)
        {

        }

        #region Rutinas del programador


        #endregion

    }
}
