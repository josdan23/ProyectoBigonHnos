namespace ProyectoBigonHnos.vista.empleado
{
    partial class EditarEmpleadoView
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvFamiliares = new System.Windows.Forms.DataGridView();
            this.colDniFamiliar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colParentesco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscapacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tboxCategoria = new System.Windows.Forms.TextBox();
            this.tboxContrasenia = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tboxUsuario = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.Label();
            this.tboxTelefono = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tboxProvincia = new System.Windows.Forms.TextBox();
            this.tboxCuit = new System.Windows.Forms.TextBox();
            this.tboxLocalidad = new System.Windows.Forms.TextBox();
            this.tboxDni = new System.Windows.Forms.TextBox();
            this.tboxNumero = new System.Windows.Forms.TextBox();
            this.tboxNombre = new System.Windows.Forms.TextBox();
            this.tboxCalle = new System.Windows.Forms.TextBox();
            this.tboxApellido = new System.Windows.Forms.TextBox();
            this.tboxLegajo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnBorrarFamiliar = new System.Windows.Forms.Button();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaEgreso = new System.Windows.Forms.DateTimePicker();
            this.cboxAdministrador = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamiliares)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(624, 486);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 41;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(714, 486);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvFamiliares
            // 
            this.dgvFamiliares.AllowUserToAddRows = false;
            this.dgvFamiliares.AllowUserToDeleteRows = false;
            this.dgvFamiliares.AllowUserToResizeColumns = false;
            this.dgvFamiliares.AllowUserToResizeRows = false;
            this.dgvFamiliares.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFamiliares.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvFamiliares.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFamiliares.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvFamiliares.ColumnHeadersHeight = 40;
            this.dgvFamiliares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFamiliares.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDniFamiliar,
            this.colParentesco,
            this.colFechaNac,
            this.colDiscapacidad});
            this.dgvFamiliares.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvFamiliares.Location = new System.Drawing.Point(18, 350);
            this.dgvFamiliares.Name = "dgvFamiliares";
            this.dgvFamiliares.ReadOnly = true;
            this.dgvFamiliares.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvFamiliares.RowHeadersVisible = false;
            this.dgvFamiliares.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvFamiliares.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvFamiliares.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFamiliares.Size = new System.Drawing.Size(771, 112);
            this.dgvFamiliares.TabIndex = 38;
            // 
            // colDniFamiliar
            // 
            this.colDniFamiliar.HeaderText = "Dni Familiar";
            this.colDniFamiliar.Name = "colDniFamiliar";
            this.colDniFamiliar.ReadOnly = true;
            // 
            // colParentesco
            // 
            this.colParentesco.HeaderText = "Parentesco";
            this.colParentesco.Name = "colParentesco";
            this.colParentesco.ReadOnly = true;
            // 
            // colFechaNac
            // 
            this.colFechaNac.HeaderText = "Fecha de Nacimiento";
            this.colFechaNac.Name = "colFechaNac";
            this.colFechaNac.ReadOnly = true;
            // 
            // colDiscapacidad
            // 
            this.colDiscapacidad.HeaderText = "Discapacidad";
            this.colDiscapacidad.Name = "colDiscapacidad";
            this.colDiscapacidad.ReadOnly = true;
            // 
            // tboxCategoria
            // 
            this.tboxCategoria.Location = new System.Drawing.Point(137, 239);
            this.tboxCategoria.Name = "tboxCategoria";
            this.tboxCategoria.Size = new System.Drawing.Size(100, 20);
            this.tboxCategoria.TabIndex = 11;
            // 
            // tboxContrasenia
            // 
            this.tboxContrasenia.Location = new System.Drawing.Point(137, 291);
            this.tboxContrasenia.Name = "tboxContrasenia";
            this.tboxContrasenia.Size = new System.Drawing.Size(100, 20);
            this.tboxContrasenia.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(558, 163);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Fecha de Egreso";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(134, 222);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Categoria";
            // 
            // tboxUsuario
            // 
            this.tboxUsuario.Location = new System.Drawing.Point(21, 291);
            this.tboxUsuario.Name = "tboxUsuario";
            this.tboxUsuario.Size = new System.Drawing.Size(100, 20);
            this.tboxUsuario.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(556, 109);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Fecha de Ingreso";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(134, 274);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Contraseña";
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Location = new System.Drawing.Point(18, 274);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(43, 13);
            this.Usuario.TabIndex = 25;
            this.Usuario.Text = "Usuario";
            // 
            // tboxTelefono
            // 
            this.tboxTelefono.Location = new System.Drawing.Point(21, 239);
            this.tboxTelefono.Name = "tboxTelefono";
            this.tboxTelefono.Size = new System.Drawing.Size(100, 20);
            this.tboxTelefono.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Telefono";
            // 
            // tboxProvincia
            // 
            this.tboxProvincia.Location = new System.Drawing.Point(369, 180);
            this.tboxProvincia.Name = "tboxProvincia";
            this.tboxProvincia.Size = new System.Drawing.Size(100, 20);
            this.tboxProvincia.TabIndex = 9;
            // 
            // tboxCuit
            // 
            this.tboxCuit.Location = new System.Drawing.Point(369, 126);
            this.tboxCuit.Name = "tboxCuit";
            this.tboxCuit.Size = new System.Drawing.Size(100, 20);
            this.tboxCuit.TabIndex = 5;
            // 
            // tboxLocalidad
            // 
            this.tboxLocalidad.Location = new System.Drawing.Point(252, 180);
            this.tboxLocalidad.Name = "tboxLocalidad";
            this.tboxLocalidad.Size = new System.Drawing.Size(100, 20);
            this.tboxLocalidad.TabIndex = 8;
            // 
            // tboxDni
            // 
            this.tboxDni.Location = new System.Drawing.Point(252, 126);
            this.tboxDni.Name = "tboxDni";
            this.tboxDni.Size = new System.Drawing.Size(100, 20);
            this.tboxDni.TabIndex = 4;
            // 
            // tboxNumero
            // 
            this.tboxNumero.Location = new System.Drawing.Point(137, 180);
            this.tboxNumero.Name = "tboxNumero";
            this.tboxNumero.Size = new System.Drawing.Size(100, 20);
            this.tboxNumero.TabIndex = 7;
            // 
            // tboxNombre
            // 
            this.tboxNombre.Location = new System.Drawing.Point(137, 126);
            this.tboxNombre.Name = "tboxNombre";
            this.tboxNombre.Size = new System.Drawing.Size(100, 20);
            this.tboxNombre.TabIndex = 3;
            // 
            // tboxCalle
            // 
            this.tboxCalle.Location = new System.Drawing.Point(21, 180);
            this.tboxCalle.Name = "tboxCalle";
            this.tboxCalle.Size = new System.Drawing.Size(100, 20);
            this.tboxCalle.TabIndex = 6;
            // 
            // tboxApellido
            // 
            this.tboxApellido.Location = new System.Drawing.Point(21, 126);
            this.tboxApellido.Name = "tboxApellido";
            this.tboxApellido.Size = new System.Drawing.Size(100, 20);
            this.tboxApellido.TabIndex = 2;
            // 
            // tboxLegajo
            // 
            this.tboxLegajo.Location = new System.Drawing.Point(21, 72);
            this.tboxLegajo.Name = "tboxLegajo";
            this.tboxLegajo.Size = new System.Drawing.Size(100, 20);
            this.tboxLegajo.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(366, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Provincia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cuit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(249, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Localidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Dni";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(134, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Número";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Calle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Legajo";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 13);
            this.label16.TabIndex = 42;
            this.label16.Text = "Editar empleado";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 334);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 13);
            this.label17.TabIndex = 43;
            this.label17.Text = "Familiares";
            // 
            // btnBorrarFamiliar
            // 
            this.btnBorrarFamiliar.Location = new System.Drawing.Point(714, 311);
            this.btnBorrarFamiliar.Name = "btnBorrarFamiliar";
            this.btnBorrarFamiliar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarFamiliar.TabIndex = 44;
            this.btnBorrarFamiliar.Text = "Borrar";
            this.btnBorrarFamiliar.UseVisualStyleBackColor = true;
            this.btnBorrarFamiliar.Click += new System.EventHandler(this.btnBorrarFamiliar_Click);
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(559, 126);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaIngreso.TabIndex = 45;
            // 
            // dtpFechaEgreso
            // 
            this.dtpFechaEgreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEgreso.Location = new System.Drawing.Point(561, 179);
            this.dtpFechaEgreso.Name = "dtpFechaEgreso";
            this.dtpFechaEgreso.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaEgreso.TabIndex = 46;
            // 
            // cboxAdministrador
            // 
            this.cboxAdministrador.AutoSize = true;
            this.cboxAdministrador.Location = new System.Drawing.Point(272, 294);
            this.cboxAdministrador.Name = "cboxAdministrador";
            this.cboxAdministrador.Size = new System.Drawing.Size(89, 17);
            this.cboxAdministrador.TabIndex = 14;
            this.cboxAdministrador.Text = "Administrador";
            this.cboxAdministrador.UseVisualStyleBackColor = true;
            // 
            // EditarEmpleadoView
            // 
            this.AcceptButton = this.button2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button3;
            this.ClientSize = new System.Drawing.Size(850, 521);
            this.Controls.Add(this.cboxAdministrador);
            this.Controls.Add(this.dtpFechaEgreso);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.btnBorrarFamiliar);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvFamiliares);
            this.Controls.Add(this.tboxCategoria);
            this.Controls.Add(this.tboxContrasenia);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tboxUsuario);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.tboxTelefono);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tboxProvincia);
            this.Controls.Add(this.tboxCuit);
            this.Controls.Add(this.tboxLocalidad);
            this.Controls.Add(this.tboxDni);
            this.Controls.Add(this.tboxNumero);
            this.Controls.Add(this.tboxNombre);
            this.Controls.Add(this.tboxCalle);
            this.Controls.Add(this.tboxApellido);
            this.Controls.Add(this.tboxLegajo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditarEmpleadoView";
            this.Text = "EditarEmpleadoView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamiliares)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvFamiliares;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDniFamiliar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colParentesco;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscapacidad;
        private System.Windows.Forms.TextBox tboxCategoria;
        private System.Windows.Forms.TextBox tboxContrasenia;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tboxUsuario;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.TextBox tboxTelefono;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tboxProvincia;
        private System.Windows.Forms.TextBox tboxCuit;
        private System.Windows.Forms.TextBox tboxLocalidad;
        private System.Windows.Forms.TextBox tboxDni;
        private System.Windows.Forms.TextBox tboxNumero;
        private System.Windows.Forms.TextBox tboxNombre;
        private System.Windows.Forms.TextBox tboxCalle;
        private System.Windows.Forms.TextBox tboxApellido;
        private System.Windows.Forms.TextBox tboxLegajo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnBorrarFamiliar;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.DateTimePicker dtpFechaEgreso;
        private System.Windows.Forms.CheckBox cboxAdministrador;
    }
}