namespace ProyectoBigonHnos.vista.proveedor
{
    partial class ProveedorView
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.cboxProveedores = new System.Windows.Forms.ComboBox();
            this.razonSocialProveedorTituloLabel = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.cuitProveedorTituloLabel = new System.Windows.Forms.Label();
            this.lblCuit = new System.Windows.Forms.Label();
            this.TelefonoProveedorTituloLabel = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.calleProveedortituloLabel = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.numeroProveedorTituloLabel = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.localidadProveedorTituloLabel = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.provinciaProveedorTituloLabel = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblIdProveedor = new System.Windows.Forms.Label();
            this.idProveedorTituloLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 53);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(207, 53);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proveedores";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.btnEditar);
            this.panel2.Controls.Add(this.btnNuevo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(148, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(712, 53);
            this.panel2.TabIndex = 0;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = global::ProyectoBigonHnos.Properties.Resources.eliminar_icon;
            this.btnEliminar.Location = new System.Drawing.Point(606, 8);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(91, 42);
            this.btnEliminar.TabIndex = 0;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = global::ProyectoBigonHnos.Properties.Resources.editar_icon;
            this.btnEditar.Location = new System.Drawing.Point(509, 8);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(91, 42);
            this.btnEditar.TabIndex = 0;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = global::ProyectoBigonHnos.Properties.Resources.nuevo_icon;
            this.btnNuevo.Location = new System.Drawing.Point(412, 8);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(91, 42);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // cboxProveedores
            // 
            this.cboxProveedores.BackColor = System.Drawing.SystemColors.Window;
            this.cboxProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxProveedores.FormattingEnabled = true;
            this.cboxProveedores.Location = new System.Drawing.Point(29, 105);
            this.cboxProveedores.Name = "cboxProveedores";
            this.cboxProveedores.Size = new System.Drawing.Size(201, 21);
            this.cboxProveedores.TabIndex = 2;
            this.cboxProveedores.SelectedIndexChanged += new System.EventHandler(this.onSeleccionarItem);
            // 
            // razonSocialProveedorTituloLabel
            // 
            this.razonSocialProveedorTituloLabel.AutoSize = true;
            this.razonSocialProveedorTituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.razonSocialProveedorTituloLabel.ForeColor = System.Drawing.Color.Black;
            this.razonSocialProveedorTituloLabel.Location = new System.Drawing.Point(68, 89);
            this.razonSocialProveedorTituloLabel.Name = "razonSocialProveedorTituloLabel";
            this.razonSocialProveedorTituloLabel.Size = new System.Drawing.Size(97, 18);
            this.razonSocialProveedorTituloLabel.TabIndex = 3;
            this.razonSocialProveedorTituloLabel.Text = "Razón Social";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSocial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRazonSocial.Location = new System.Drawing.Point(200, 91);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(35, 17);
            this.lblRazonSocial.TabIndex = 3;
            this.lblRazonSocial.Text = "adsf";
            // 
            // cuitProveedorTituloLabel
            // 
            this.cuitProveedorTituloLabel.AutoSize = true;
            this.cuitProveedorTituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuitProveedorTituloLabel.ForeColor = System.Drawing.Color.Black;
            this.cuitProveedorTituloLabel.Location = new System.Drawing.Point(131, 132);
            this.cuitProveedorTituloLabel.Name = "cuitProveedorTituloLabel";
            this.cuitProveedorTituloLabel.Size = new System.Drawing.Size(34, 18);
            this.cuitProveedorTituloLabel.TabIndex = 3;
            this.cuitProveedorTituloLabel.Text = "Cuit";
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCuit.Location = new System.Drawing.Point(200, 134);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(35, 17);
            this.lblCuit.TabIndex = 3;
            this.lblCuit.Text = "adsf";
            // 
            // TelefonoProveedorTituloLabel
            // 
            this.TelefonoProveedorTituloLabel.AutoSize = true;
            this.TelefonoProveedorTituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefonoProveedorTituloLabel.ForeColor = System.Drawing.Color.Black;
            this.TelefonoProveedorTituloLabel.Location = new System.Drawing.Point(99, 175);
            this.TelefonoProveedorTituloLabel.Name = "TelefonoProveedorTituloLabel";
            this.TelefonoProveedorTituloLabel.Size = new System.Drawing.Size(66, 18);
            this.TelefonoProveedorTituloLabel.TabIndex = 3;
            this.TelefonoProveedorTituloLabel.Text = "Telefono";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTelefono.Location = new System.Drawing.Point(200, 177);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(35, 17);
            this.lblTelefono.TabIndex = 3;
            this.lblTelefono.Text = "adsf";
            // 
            // calleProveedortituloLabel
            // 
            this.calleProveedortituloLabel.AutoSize = true;
            this.calleProveedortituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calleProveedortituloLabel.ForeColor = System.Drawing.Color.Black;
            this.calleProveedortituloLabel.Location = new System.Drawing.Point(375, 46);
            this.calleProveedortituloLabel.Name = "calleProveedortituloLabel";
            this.calleProveedortituloLabel.Size = new System.Drawing.Size(41, 18);
            this.calleProveedortituloLabel.TabIndex = 3;
            this.calleProveedortituloLabel.Text = "Calle";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCalle.Location = new System.Drawing.Point(454, 48);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(35, 17);
            this.lblCalle.TabIndex = 3;
            this.lblCalle.Text = "adsf";
            // 
            // numeroProveedorTituloLabel
            // 
            this.numeroProveedorTituloLabel.AutoSize = true;
            this.numeroProveedorTituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroProveedorTituloLabel.ForeColor = System.Drawing.Color.Black;
            this.numeroProveedorTituloLabel.Location = new System.Drawing.Point(354, 88);
            this.numeroProveedorTituloLabel.Name = "numeroProveedorTituloLabel";
            this.numeroProveedorTituloLabel.Size = new System.Drawing.Size(62, 18);
            this.numeroProveedorTituloLabel.TabIndex = 3;
            this.numeroProveedorTituloLabel.Text = "Número";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNumero.Location = new System.Drawing.Point(454, 90);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(35, 17);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "adsf";
            // 
            // localidadProveedorTituloLabel
            // 
            this.localidadProveedorTituloLabel.AutoSize = true;
            this.localidadProveedorTituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localidadProveedorTituloLabel.ForeColor = System.Drawing.Color.Black;
            this.localidadProveedorTituloLabel.Location = new System.Drawing.Point(345, 131);
            this.localidadProveedorTituloLabel.Name = "localidadProveedorTituloLabel";
            this.localidadProveedorTituloLabel.Size = new System.Drawing.Size(71, 18);
            this.localidadProveedorTituloLabel.TabIndex = 3;
            this.localidadProveedorTituloLabel.Text = "Localidad";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLocalidad.Location = new System.Drawing.Point(454, 133);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(35, 17);
            this.lblLocalidad.TabIndex = 3;
            this.lblLocalidad.Text = "adsf";
            // 
            // provinciaProveedorTituloLabel
            // 
            this.provinciaProveedorTituloLabel.AutoSize = true;
            this.provinciaProveedorTituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provinciaProveedorTituloLabel.ForeColor = System.Drawing.Color.Black;
            this.provinciaProveedorTituloLabel.Location = new System.Drawing.Point(347, 173);
            this.provinciaProveedorTituloLabel.Name = "provinciaProveedorTituloLabel";
            this.provinciaProveedorTituloLabel.Size = new System.Drawing.Size(69, 18);
            this.provinciaProveedorTituloLabel.TabIndex = 3;
            this.provinciaProveedorTituloLabel.Text = "Provincia";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblProvincia.Location = new System.Drawing.Point(454, 175);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(35, 17);
            this.lblProvincia.TabIndex = 3;
            this.lblProvincia.Text = "adsf";
            // 
            // lblIdProveedor
            // 
            this.lblIdProveedor.AutoSize = true;
            this.lblIdProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIdProveedor.Location = new System.Drawing.Point(200, 48);
            this.lblIdProveedor.Name = "lblIdProveedor";
            this.lblIdProveedor.Size = new System.Drawing.Size(35, 17);
            this.lblIdProveedor.TabIndex = 3;
            this.lblIdProveedor.Text = "adsf";
            // 
            // idProveedorTituloLabel
            // 
            this.idProveedorTituloLabel.AutoSize = true;
            this.idProveedorTituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idProveedorTituloLabel.ForeColor = System.Drawing.Color.Black;
            this.idProveedorTituloLabel.Location = new System.Drawing.Point(73, 46);
            this.idProveedorTituloLabel.Name = "idProveedorTituloLabel";
            this.idProveedorTituloLabel.Size = new System.Drawing.Size(92, 18);
            this.idProveedorTituloLabel.TabIndex = 3;
            this.idProveedorTituloLabel.Text = "Id Proveedor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(26, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 18);
            this.label10.TabIndex = 5;
            this.label10.Text = "Selecciona un proveedor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(25, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Información de proveedor";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.AutoSize = true;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.TelefonoProveedorTituloLabel);
            this.panel4.Controls.Add(this.provinciaProveedorTituloLabel);
            this.panel4.Controls.Add(this.lblNumero);
            this.panel4.Controls.Add(this.razonSocialProveedorTituloLabel);
            this.panel4.Controls.Add(this.calleProveedortituloLabel);
            this.panel4.Controls.Add(this.lblLocalidad);
            this.panel4.Controls.Add(this.lblCalle);
            this.panel4.Controls.Add(this.lblIdProveedor);
            this.panel4.Controls.Add(this.lblCuit);
            this.panel4.Controls.Add(this.localidadProveedorTituloLabel);
            this.panel4.Controls.Add(this.lblProvincia);
            this.panel4.Controls.Add(this.lblTelefono);
            this.panel4.Controls.Add(this.numeroProveedorTituloLabel);
            this.panel4.Controls.Add(this.lblRazonSocial);
            this.panel4.Controls.Add(this.cuitProveedorTituloLabel);
            this.panel4.Controls.Add(this.idProveedorTituloLabel);
            this.panel4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.panel4.Location = new System.Drawing.Point(125, 204);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(581, 277);
            this.panel4.TabIndex = 6;
            // 
            // ProveedorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboxProveedores);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Name = "ProveedorView";
            this.Size = new System.Drawing.Size(860, 509);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ComboBox cboxProveedores;
        private System.Windows.Forms.Label razonSocialProveedorTituloLabel;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label cuitProveedorTituloLabel;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.Label TelefonoProveedorTituloLabel;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label calleProveedortituloLabel;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label numeroProveedorTituloLabel;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label localidadProveedorTituloLabel;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label provinciaProveedorTituloLabel;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblIdProveedor;
        private System.Windows.Forms.Label idProveedorTituloLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
    }
}
