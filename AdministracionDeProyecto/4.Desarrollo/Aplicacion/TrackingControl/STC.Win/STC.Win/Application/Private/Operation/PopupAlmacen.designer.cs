namespace TrackingControl
{
    public partial class PopupAlmacen : Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.pbxImprimir = new System.Windows.Forms.PictureBox();
            this.rbnAprobar = new System.Windows.Forms.RadioButton();
            this.rbnRechazar = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.lblFechaEntrega = new System.Windows.Forms.Label();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.btnRefrescar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImprimir)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aprobar-Rechazar";
            // 
            // pbxImprimir
            // 
            this.pbxImprimir.Location = new System.Drawing.Point(39, 159);
            this.pbxImprimir.Name = "pbxImprimir";
            this.pbxImprimir.Size = new System.Drawing.Size(158, 144);
            this.pbxImprimir.TabIndex = 1;
            this.pbxImprimir.TabStop = false;
            // 
            // rbnAprobar
            // 
            this.rbnAprobar.AutoSize = true;
            this.rbnAprobar.Location = new System.Drawing.Point(246, 159);
            this.rbnAprobar.Name = "rbnAprobar";
            this.rbnAprobar.Size = new System.Drawing.Size(62, 17);
            this.rbnAprobar.TabIndex = 2;
            this.rbnAprobar.TabStop = true;
            this.rbnAprobar.Text = "Aprobar";
            this.rbnAprobar.UseVisualStyleBackColor = true;
            // 
            // rbnRechazar
            // 
            this.rbnRechazar.AutoSize = true;
            this.rbnRechazar.Location = new System.Drawing.Point(370, 159);
            this.rbnRechazar.Name = "rbnRechazar";
            this.rbnRechazar.Size = new System.Drawing.Size(71, 17);
            this.rbnRechazar.TabIndex = 3;
            this.rbnRechazar.TabStop = true;
            this.rbnRechazar.Text = "Rechazar";
            this.rbnRechazar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pedido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha entrega";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha ingreso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Observaciones";
            // 
            // txtPedido
            // 
            this.txtPedido.Location = new System.Drawing.Point(370, 190);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(150, 20);
            this.txtPedido.TabIndex = 9;
            // 
            // lblFechaEntrega
            // 
            this.lblFechaEntrega.AutoSize = true;
            this.lblFechaEntrega.Location = new System.Drawing.Point(367, 224);
            this.lblFechaEntrega.Name = "lblFechaEntrega";
            this.lblFechaEntrega.Size = new System.Drawing.Size(126, 13);
            this.lblFechaEntrega.TabIndex = 10;
            this.lblFechaEntrega.Text = "30 de diciembre del 2013";
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Location = new System.Drawing.Point(367, 253);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(126, 13);
            this.lblFechaIngreso.TabIndex = 11;
            this.lblFechaIngreso.Text = "30 de diciembre del 2013";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(249, 335);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(271, 116);
            this.txtObservaciones.TabIndex = 12;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(57, 313);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(115, 23);
            this.btnRefrescar.TabIndex = 13;
            this.btnRefrescar.Text = "Refrescar Pantalla";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            // 
            // PopupAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.lblFechaEntrega);
            this.Controls.Add(this.txtPedido);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbnRechazar);
            this.Controls.Add(this.rbnAprobar);
            this.Controls.Add(this.pbxImprimir);
            this.Controls.Add(this.label1);
            this.Name = "PopupAlmacen";
            this.Text = "PopupAlmacen";
            this.Load += new System.EventHandler(this.PopupAlmacen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImprimir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxImprimir;
        private System.Windows.Forms.RadioButton rbnAprobar;
        private System.Windows.Forms.RadioButton rbnRechazar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.Label lblFechaEntrega;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button btnRefrescar;
    }
}