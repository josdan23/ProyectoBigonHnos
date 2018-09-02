namespace ProyectoBigonHnos.vista
{
    partial class ClientesView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.dniColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxDni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBoxApellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tBoxNombre = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvTelefonos = new System.Windows.Forms.DataGridView();
            this.numeroColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tboxCalle = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tboxNumero = new System.Windows.Forms.TextBox();
            this.tboxLocalidad = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tboxProvincia = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefonos)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(954, 53);
            this.panel1.TabIndex = 0;
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
            this.label1.Size = new System.Drawing.Size(113, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clientes";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.btnEditar);
            this.panel2.Controls.Add(this.btnNuevo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(242, 0);
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
            // dgvClientes
            // 
            this.dgvClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dniColumn,
            this.apellidoColumn,
            this.nombreColumn,
            this.Column1});
            this.dgvClientes.Location = new System.Drawing.Point(29, 121);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(335, 381);
            this.dgvClientes.TabIndex = 1;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.seleccionarFila);
            // 
            // dniColumn
            // 
            this.dniColumn.HeaderText = "Dni";
            this.dniColumn.Name = "dniColumn";
            this.dniColumn.ReadOnly = true;
            // 
            // apellidoColumn
            // 
            this.apellidoColumn.HeaderText = "Apellido";
            this.apellidoColumn.Name = "apellidoColumn";
            this.apellidoColumn.ReadOnly = true;
            // 
            // nombreColumn
            // 
            this.nombreColumn.HeaderText = "Nombre";
            this.nombreColumn.Name = "nombreColumn";
            this.nombreColumn.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(461, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dni";
            // 
            // tboxDni
            // 
            this.tboxDni.Enabled = false;
            this.tboxDni.Location = new System.Drawing.Point(464, 137);
            this.tboxDni.Name = "tboxDni";
            this.tboxDni.Size = new System.Drawing.Size(100, 20);
            this.tboxDni.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(461, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Información del cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(567, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Apellido";
            // 
            // tBoxApellido
            // 
            this.tBoxApellido.Enabled = false;
            this.tBoxApellido.Location = new System.Drawing.Point(570, 137);
            this.tBoxApellido.Name = "tBoxApellido";
            this.tBoxApellido.Size = new System.Drawing.Size(100, 20);
            this.tBoxApellido.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(673, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nombre";
            // 
            // tBoxNombre
            // 
            this.tBoxNombre.Enabled = false;
            this.tBoxNombre.Location = new System.Drawing.Point(676, 137);
            this.tBoxNombre.Name = "tBoxNombre";
            this.tBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.tBoxNombre.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Lista de clientes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(461, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Telefonos";
            this.label6.Click += new System.EventHandler(this.label3_Click);
            // 
            // dgvTelefonos
            // 
            this.dgvTelefonos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTelefonos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTelefonos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgvTelefonos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTelefonos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTelefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefonos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroColumn,
            this.dataGridViewTextBoxColumn4});
            this.dgvTelefonos.Location = new System.Drawing.Point(464, 331);
            this.dgvTelefonos.Name = "dgvTelefonos";
            this.dgvTelefonos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTelefonos.RowHeadersVisible = false;
            this.dgvTelefonos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTelefonos.Size = new System.Drawing.Size(345, 78);
            this.dgvTelefonos.TabIndex = 1;
            // 
            // numeroColumn
            // 
            this.numeroColumn.HeaderText = "Número";
            this.numeroColumn.Name = "numeroColumn";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(461, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Domicilio";
            this.label7.Click += new System.EventHandler(this.label3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(461, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Calle";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(567, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Numero";
            // 
            // tboxCalle
            // 
            this.tboxCalle.Enabled = false;
            this.tboxCalle.Location = new System.Drawing.Point(464, 245);
            this.tboxCalle.Name = "tboxCalle";
            this.tboxCalle.Size = new System.Drawing.Size(100, 20);
            this.tboxCalle.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(673, 229);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Localidad";
            // 
            // tboxNumero
            // 
            this.tboxNumero.Enabled = false;
            this.tboxNumero.Location = new System.Drawing.Point(570, 245);
            this.tboxNumero.Name = "tboxNumero";
            this.tboxNumero.Size = new System.Drawing.Size(100, 20);
            this.tboxNumero.TabIndex = 3;
            // 
            // tboxLocalidad
            // 
            this.tboxLocalidad.Enabled = false;
            this.tboxLocalidad.Location = new System.Drawing.Point(676, 245);
            this.tboxLocalidad.Name = "tboxLocalidad";
            this.tboxLocalidad.Size = new System.Drawing.Size(100, 20);
            this.tboxLocalidad.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(789, 229);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Provincia";
            // 
            // tboxProvincia
            // 
            this.tboxProvincia.Enabled = false;
            this.tboxProvincia.Location = new System.Drawing.Point(792, 245);
            this.tboxProvincia.Name = "tboxProvincia";
            this.tboxProvincia.Size = new System.Drawing.Size(100, 20);
            this.tboxProvincia.TabIndex = 3;
            // 
            // ClientesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tboxProvincia);
            this.Controls.Add(this.tboxLocalidad);
            this.Controls.Add(this.tboxNumero);
            this.Controls.Add(this.tBoxNombre);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tBoxApellido);
            this.Controls.Add(this.tboxCalle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tboxDni);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvTelefonos);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.panel1);
            this.Name = "ClientesView";
            this.Size = new System.Drawing.Size(954, 545);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefonos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxDni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBoxApellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBoxNombre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvTelefonos;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tboxCalle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tboxNumero;
        private System.Windows.Forms.TextBox tboxLocalidad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tboxProvincia;
    }
}
