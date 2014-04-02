using System.Data.SqlClient;
using System.Text;
using System.Drawing;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace TrackingControl
{
    public partial class mdiContainer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdiContainer));
            this.lblAdministracion = new System.Windows.Forms.Label();
            this.lblProductoTerminado = new System.Windows.Forms.Label();
            this.lblBolseo = new System.Windows.Forms.Label();
            this.lblCorrugado = new System.Windows.Forms.Label();
            this.lblImpresion = new System.Windows.Forms.Label();
            this.lblAlmacen = new System.Windows.Forms.Label();
            this.lblProduccion = new System.Windows.Forms.Label();
            this.lblProgramacioPedido = new System.Windows.Forms.Label();
            this.pbxAdministracion = new System.Windows.Forms.PictureBox();
            this.pbxProductoTerminado = new System.Windows.Forms.PictureBox();
            this.pbxBolseo = new System.Windows.Forms.PictureBox();
            this.pbxCorrugado = new System.Windows.Forms.PictureBox();
            this.pbxImpresion = new System.Windows.Forms.PictureBox();
            this.pbxAlmacen = new System.Windows.Forms.PictureBox();
            this.pbxPedidos = new System.Windows.Forms.PictureBox();
            this.pbxCargaProgPedidos = new System.Windows.Forms.PictureBox();
            this.lblmnuInicio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdministracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProductoTerminado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBolseo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCorrugado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImpresion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAlmacen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCargaProgPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdministracion
            // 
            this.lblAdministracion.AutoSize = true;
            this.lblAdministracion.Location = new System.Drawing.Point(872, 433);
            this.lblAdministracion.Name = "lblAdministracion";
            this.lblAdministracion.Size = new System.Drawing.Size(75, 13);
            this.lblAdministracion.TabIndex = 33;
            this.lblAdministracion.Text = "Administración";
            // 
            // lblProductoTerminado
            // 
            this.lblProductoTerminado.AutoSize = true;
            this.lblProductoTerminado.Location = new System.Drawing.Point(593, 434);
            this.lblProductoTerminado.Name = "lblProductoTerminado";
            this.lblProductoTerminado.Size = new System.Drawing.Size(103, 13);
            this.lblProductoTerminado.TabIndex = 32;
            this.lblProductoTerminado.Text = "Producto Terminado";
            // 
            // lblBolseo
            // 
            this.lblBolseo.AutoSize = true;
            this.lblBolseo.Location = new System.Drawing.Point(347, 434);
            this.lblBolseo.Name = "lblBolseo";
            this.lblBolseo.Size = new System.Drawing.Size(39, 13);
            this.lblBolseo.TabIndex = 31;
            this.lblBolseo.Text = "Bolseo";
            // 
            // lblCorrugado
            // 
            this.lblCorrugado.AutoSize = true;
            this.lblCorrugado.Location = new System.Drawing.Point(70, 434);
            this.lblCorrugado.Name = "lblCorrugado";
            this.lblCorrugado.Size = new System.Drawing.Size(56, 13);
            this.lblCorrugado.TabIndex = 30;
            this.lblCorrugado.Text = "Corrugado";
            // 
            // lblImpresion
            // 
            this.lblImpresion.AutoSize = true;
            this.lblImpresion.Location = new System.Drawing.Point(883, 252);
            this.lblImpresion.Name = "lblImpresion";
            this.lblImpresion.Size = new System.Drawing.Size(52, 13);
            this.lblImpresion.TabIndex = 29;
            this.lblImpresion.Text = "Impresión";
            // 
            // lblAlmacen
            // 
            this.lblAlmacen.AutoSize = true;
            this.lblAlmacen.Location = new System.Drawing.Point(621, 252);
            this.lblAlmacen.Name = "lblAlmacen";
            this.lblAlmacen.Size = new System.Drawing.Size(48, 13);
            this.lblAlmacen.TabIndex = 28;
            this.lblAlmacen.Text = "Almacén";
            // 
            // lblProduccion
            // 
            this.lblProduccion.AutoSize = true;
            this.lblProduccion.Location = new System.Drawing.Point(336, 252);
            this.lblProduccion.Name = "lblProduccion";
            this.lblProduccion.Size = new System.Drawing.Size(61, 13);
            this.lblProduccion.TabIndex = 27;
            this.lblProduccion.Text = "Producción";
            // 
            // lblProgramacioPedido
            // 
            this.lblProgramacioPedido.AutoSize = true;
            this.lblProgramacioPedido.Location = new System.Drawing.Point(37, 252);
            this.lblProgramacioPedido.Name = "lblProgramacioPedido";
            this.lblProgramacioPedido.Size = new System.Drawing.Size(172, 13);
            this.lblProgramacioPedido.TabIndex = 26;
            this.lblProgramacioPedido.Text = "Carga de programación de pedidos";
            // 
            // pbxAdministracion
            // 
            this.pbxAdministracion.Location = new System.Drawing.Point(844, 300);
            this.pbxAdministracion.Name = "pbxAdministracion";
            this.pbxAdministracion.Size = new System.Drawing.Size(121, 122);
            this.pbxAdministracion.TabIndex = 25;
            this.pbxAdministracion.TabStop = false;
            // 
            // pbxProductoTerminado
            // 
            this.pbxProductoTerminado.Image = ((System.Drawing.Image)(resources.GetObject("pbxProductoTerminado.Image")));
            this.pbxProductoTerminado.Location = new System.Drawing.Point(581, 300);
            this.pbxProductoTerminado.Name = "pbxProductoTerminado";
            this.pbxProductoTerminado.Size = new System.Drawing.Size(121, 122);
            this.pbxProductoTerminado.TabIndex = 24;
            this.pbxProductoTerminado.TabStop = false;
            // 
            // pbxBolseo
            // 
            this.pbxBolseo.Location = new System.Drawing.Point(302, 300);
            this.pbxBolseo.Name = "pbxBolseo";
            this.pbxBolseo.Size = new System.Drawing.Size(121, 122);
            this.pbxBolseo.TabIndex = 23;
            this.pbxBolseo.TabStop = false;
            // 
            // pbxCorrugado
            // 
            this.pbxCorrugado.Location = new System.Drawing.Point(38, 300);
            this.pbxCorrugado.Name = "pbxCorrugado";
            this.pbxCorrugado.Size = new System.Drawing.Size(121, 122);
            this.pbxCorrugado.TabIndex = 22;
            this.pbxCorrugado.TabStop = false;
            // 
            // pbxImpresion
            // 
            this.pbxImpresion.Location = new System.Drawing.Point(844, 118);
            this.pbxImpresion.Name = "pbxImpresion";
            this.pbxImpresion.Size = new System.Drawing.Size(121, 122);
            this.pbxImpresion.TabIndex = 21;
            this.pbxImpresion.TabStop = false;
            // 
            // pbxAlmacen
            // 
            this.pbxAlmacen.Image = ((System.Drawing.Image)(resources.GetObject("pbxAlmacen.Image")));
            this.pbxAlmacen.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbxAlmacen.InitialImage")));
            this.pbxAlmacen.Location = new System.Drawing.Point(581, 118);
            this.pbxAlmacen.Name = "pbxAlmacen";
            this.pbxAlmacen.Size = new System.Drawing.Size(121, 122);
            this.pbxAlmacen.TabIndex = 20;
            this.pbxAlmacen.TabStop = false;
            this.pbxAlmacen.Click += new System.EventHandler(this.pbxAlmacen_Click);
            // 
            // pbxPedidos
            // 
            this.pbxPedidos.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbxPedidos.ErrorImage")));
            this.pbxPedidos.Image = ((System.Drawing.Image)(resources.GetObject("pbxPedidos.Image")));
            this.pbxPedidos.Location = new System.Drawing.Point(302, 118);
            this.pbxPedidos.Name = "pbxPedidos";
            this.pbxPedidos.Size = new System.Drawing.Size(121, 122);
            this.pbxPedidos.TabIndex = 19;
            this.pbxPedidos.TabStop = false;
            // 
            // pbxCargaProgPedidos
            // 
            this.pbxCargaProgPedidos.Location = new System.Drawing.Point(38, 118);
            this.pbxCargaProgPedidos.Name = "pbxCargaProgPedidos";
            this.pbxCargaProgPedidos.Size = new System.Drawing.Size(121, 122);
            this.pbxCargaProgPedidos.TabIndex = 18;
            this.pbxCargaProgPedidos.TabStop = false;
            // 
            // lblmnuInicio
            // 
            this.lblmnuInicio.AutoSize = true;
            this.lblmnuInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmnuInicio.Location = new System.Drawing.Point(34, 21);
            this.lblmnuInicio.Name = "lblmnuInicio";
            this.lblmnuInicio.Size = new System.Drawing.Size(293, 31);
            this.lblmnuInicio.TabIndex = 17;
            this.lblmnuInicio.Text = "Pantalla de mnuInicio";
            // 
            // mdiContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.lblAdministracion);
            this.Controls.Add(this.lblProductoTerminado);
            this.Controls.Add(this.lblBolseo);
            this.Controls.Add(this.lblCorrugado);
            this.Controls.Add(this.lblImpresion);
            this.Controls.Add(this.lblAlmacen);
            this.Controls.Add(this.lblProduccion);
            this.Controls.Add(this.lblProgramacioPedido);
            this.Controls.Add(this.pbxAdministracion);
            this.Controls.Add(this.pbxProductoTerminado);
            this.Controls.Add(this.pbxBolseo);
            this.Controls.Add(this.pbxCorrugado);
            this.Controls.Add(this.pbxImpresion);
            this.Controls.Add(this.pbxAlmacen);
            this.Controls.Add(this.pbxPedidos);
            this.Controls.Add(this.pbxCargaProgPedidos);
            this.Controls.Add(this.lblmnuInicio);
            this.IsMdiContainer = true;
            this.Name = "mdiContainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tracking Control 1.0.0";
            this.Load += new System.EventHandler(this.mdiContainer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdministracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProductoTerminado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBolseo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCorrugado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImpresion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAlmacen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCargaProgPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdministracion;
        private System.Windows.Forms.Label lblProductoTerminado;
        private System.Windows.Forms.Label lblBolseo;
        private System.Windows.Forms.Label lblCorrugado;
        private System.Windows.Forms.Label lblImpresion;
        private System.Windows.Forms.Label lblAlmacen;
        private System.Windows.Forms.Label lblProduccion;
        private System.Windows.Forms.Label lblProgramacioPedido;
        private System.Windows.Forms.PictureBox pbxAdministracion;
        private System.Windows.Forms.PictureBox pbxProductoTerminado;
        private System.Windows.Forms.PictureBox pbxBolseo;
        private System.Windows.Forms.PictureBox pbxCorrugado;
        private System.Windows.Forms.PictureBox pbxImpresion;
        private System.Windows.Forms.PictureBox pbxAlmacen;
        private System.Windows.Forms.PictureBox pbxPedidos;
        private System.Windows.Forms.PictureBox pbxCargaProgPedidos;
        private System.Windows.Forms.Label lblmnuInicio;
    }
}

