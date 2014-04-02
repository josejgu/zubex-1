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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Validar que esten capturados los dos campos
            // Enviar al mdicontainer
            mdiContainer frmContainer = new mdiContainer();
            frmContainer.Show();
        }

        private void btnRecuperarPass_Click(object sender, EventArgs e)
        {
            // enviar a pantalla que se llama RecuperaClave
        }
    }
}
