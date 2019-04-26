namespace ProyectoBigonHnos.vista.compra
{
    partial class NuevaCompraView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.codigoTextView = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.razonSocialLabel = new System.Windows.Forms.Label();
            this.cuitLabel = new System.Windows.Forms.Label();
            this.domicilioLabel = new System.Windows.Forms.Label();
            this.telefonoLabel = new System.Windows.Forms.Label();
            this.compraDataGrid = new System.Windows.Forms.DataGridView();
            this.idLineaCompraCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.materialesDataGrid = new System.Windows.Forms.DataGridView();
            this.colIdMat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.confirmarButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.fechaLabel = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.compraDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialesDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código";
            // 
            // codigoTextView
            // 
            this.codigoTextView.Location = new System.Drawing.Point(86, 61);
            this.codigoTextView.Name = "codigoTextView";
            this.codigoTextView.Size = new System.Drawing.Size(124, 20);
            this.codigoTextView.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Razón Social";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cuit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Domicilio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Telefono";
            // 
            // razonSocialLabel
            // 
            this.razonSocialLabel.AutoSize = true;
            this.razonSocialLabel.Location = new System.Drawing.Point(105, 20);
            this.razonSocialLabel.Name = "razonSocialLabel";
            this.razonSocialLabel.Size = new System.Drawing.Size(10, 13);
            this.razonSocialLabel.TabIndex = 0;
            this.razonSocialLabel.Text = ".";
            // 
            // cuitLabel
            // 
            this.cuitLabel.AutoSize = true;
            this.cuitLabel.Location = new System.Drawing.Point(105, 50);
            this.cuitLabel.Name = "cuitLabel";
            this.cuitLabel.Size = new System.Drawing.Size(10, 13);
            this.cuitLabel.TabIndex = 0;
            this.cuitLabel.Text = ".";
            // 
            // domicilioLabel
            // 
            this.domicilioLabel.AutoSize = true;
            this.domicilioLabel.Location = new System.Drawing.Point(105, 79);
            this.domicilioLabel.Name = "domicilioLabel";
            this.domicilioLabel.Size = new System.Drawing.Size(10, 13);
            this.domicilioLabel.TabIndex = 0;
            this.domicilioLabel.Text = ".";
            // 
            // telefonoLabel
            // 
            this.telefonoLabel.AutoSize = true;
            this.telefonoLabel.Location = new System.Drawing.Point(105, 109);
            this.telefonoLabel.Name = "telefonoLabel";
            this.telefonoLabel.Size = new System.Drawing.Size(10, 13);
            this.telefonoLabel.TabIndex = 0;
            this.telefonoLabel.Text = ".";
            // 
            // compraDataGrid
            // 
            this.compraDataGrid.AllowUserToAddRows = false;
            this.compraDataGrid.AllowUserToDeleteRows = false;
            this.compraDataGrid.AllowUserToResizeColumns = false;
            this.compraDataGrid.AllowUserToResizeRows = false;
            this.compraDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.compraDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.compraDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.compraDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.compraDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.compraDataGrid.ColumnHeadersHeight = 40;
            this.compraDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.compraDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLineaCompraCol,
            this.colIdMaterial,
            this.colDescripcion,
            this.colCantidad});
            this.compraDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.compraDataGrid.Location = new System.Drawing.Point(103, 86);
            this.compraDataGrid.MultiSelect = false;
            this.compraDataGrid.Name = "compraDataGrid";
            this.compraDataGrid.ReadOnly = true;
            this.compraDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.compraDataGrid.RowHeadersVisible = false;
            this.compraDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.compraDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.compraDataGrid.ShowCellErrors = false;
            this.compraDataGrid.ShowCellToolTips = false;
            this.compraDataGrid.ShowEditingIcon = false;
            this.compraDataGrid.ShowRowErrors = false;
            this.compraDataGrid.Size = new System.Drawing.Size(409, 423);
            this.compraDataGrid.TabIndex = 3;
            // 
            // idLineaCompraCol
            // 
            this.idLineaCompraCol.HeaderText = "#";
            this.idLineaCompraCol.Name = "idLineaCompraCol";
            this.idLineaCompraCol.ReadOnly = true;
            // 
            // colIdMaterial
            // 
            this.colIdMaterial.HeaderText = "Id Material";
            this.colIdMaterial.Name = "colIdMaterial";
            this.colIdMaterial.ReadOnly = true;
            // 
            // colDescripcion
            // 
            this.colDescripcion.HeaderText = "Descripción";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.ReadOnly = true;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad Solicitada";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(100, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Lista de materiales a comprar";
            // 
            // materialesDataGrid
            // 
            this.materialesDataGrid.AllowUserToAddRows = false;
            this.materialesDataGrid.AllowUserToDeleteRows = false;
            this.materialesDataGrid.AllowUserToResizeColumns = false;
            this.materialesDataGrid.AllowUserToResizeRows = false;
            this.materialesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.materialesDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.materialesDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialesDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.materialesDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.materialesDataGrid.ColumnHeadersHeight = 40;
            this.materialesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdMat,
            this.colDesc,
            this.colStockMinimo,
            this.colStockDisponible});
            this.materialesDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.materialesDataGrid.Location = new System.Drawing.Point(43, 282);
            this.materialesDataGrid.MultiSelect = false;
            this.materialesDataGrid.Name = "materialesDataGrid";
            this.materialesDataGrid.ReadOnly = true;
            this.materialesDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.materialesDataGrid.RowHeadersVisible = false;
            this.materialesDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.materialesDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.materialesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.materialesDataGrid.ShowCellErrors = false;
            this.materialesDataGrid.ShowCellToolTips = false;
            this.materialesDataGrid.ShowEditingIcon = false;
            this.materialesDataGrid.ShowRowErrors = false;
            this.materialesDataGrid.Size = new System.Drawing.Size(442, 235);
            this.materialesDataGrid.TabIndex = 4;
            // 
            // colIdMat
            // 
            this.colIdMat.HeaderText = "Id Material";
            this.colIdMat.Name = "colIdMat";
            this.colIdMat.ReadOnly = true;
            // 
            // colDesc
            // 
            this.colDesc.HeaderText = "Descripción";
            this.colDesc.Name = "colDesc";
            this.colDesc.ReadOnly = true;
            // 
            // colStockMinimo
            // 
            this.colStockMinimo.HeaderText = "Stock Minimo";
            this.colStockMinimo.Name = "colStockMinimo";
            this.colStockMinimo.ReadOnly = true;
            // 
            // colStockDisponible
            // 
            this.colStockDisponible.HeaderText = "Stock Disponible";
            this.colStockDisponible.Name = "colStockDisponible";
            this.colStockDisponible.ReadOnly = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(40, 261);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Materiales en deposito";
            // 
            // confirmarButton
            // 
            this.confirmarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.confirmarButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.confirmarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmarButton.Location = new System.Drawing.Point(936, 538);
            this.confirmarButton.Name = "confirmarButton";
            this.confirmarButton.Size = new System.Drawing.Size(82, 32);
            this.confirmarButton.TabIndex = 5;
            this.confirmarButton.Text = "Confirmar";
            this.confirmarButton.UseVisualStyleBackColor = false;
            this.confirmarButton.Click += new System.EventHandler(this.confirmarButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelarButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.cancelarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarButton.Location = new System.Drawing.Point(837, 538);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(77, 32);
            this.cancelarButton.TabIndex = 5;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(338, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Fecha de compra:";
            // 
            // fechaLabel
            // 
            this.fechaLabel.AutoSize = true;
            this.fechaLabel.Location = new System.Drawing.Point(447, 29);
            this.fechaLabel.Name = "fechaLabel";
            this.fechaLabel.Size = new System.Drawing.Size(65, 13);
            this.fechaLabel.TabIndex = 0;
            this.fechaLabel.Text = "29/29/1990";
            this.fechaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(229, 59);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Location = new System.Drawing.Point(6, 315);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 32);
            this.btnQuitar.TabIndex = 7;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(6, 244);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 32);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.domicilioLabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.razonSocialLabel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cuitLabel);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.telefonoLabel);
            this.panel1.Location = new System.Drawing.Point(43, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 144);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Controls.Add(this.btnQuitar);
            this.panel2.Controls.Add(this.compraDataGrid);
            this.panel2.Controls.Add(this.fechaLabel);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(506, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(529, 520);
            this.panel2.TabIndex = 9;
            // 
            // NuevaCompraView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1047, 582);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.confirmarButton);
            this.Controls.Add(this.materialesDataGrid);
            this.Controls.Add(this.codigoTextView);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NuevaCompraView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nueva compra";
            ((System.ComponentModel.ISupportInitialize)(this.compraDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialesDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codigoTextView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label razonSocialLabel;
        private System.Windows.Forms.Label cuitLabel;
        private System.Windows.Forms.Label domicilioLabel;
        private System.Windows.Forms.Label telefonoLabel;
        private System.Windows.Forms.DataGridView compraDataGrid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView materialesDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdMat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockMinimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockDisponible;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button confirmarButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label fechaLabel;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLineaCompraCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.Panel panel2;
    }
}