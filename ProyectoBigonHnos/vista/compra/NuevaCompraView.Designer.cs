namespace ProyectoBigonHnos.vista
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.codigoTextView = new System.Windows.Forms.TextBox();
            this.buscarButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.razonSocialLabel = new System.Windows.Forms.Label();
            this.cuitLabel = new System.Windows.Forms.Label();
            this.domicilioLabel = new System.Windows.Forms.Label();
            this.telefonoLabel = new System.Windows.Forms.Label();
            this.compraDataGrid = new System.Windows.Forms.DataGridView();
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
            this.agregarButton = new System.Windows.Forms.Button();
            this.quitarButton = new System.Windows.Forms.Button();
            this.confirmarButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.fechaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.compraDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
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
            this.label2.Text = "Codigo";
            // 
            // codigoTextView
            // 
            this.codigoTextView.Location = new System.Drawing.Point(86, 61);
            this.codigoTextView.Name = "codigoTextView";
            this.codigoTextView.Size = new System.Drawing.Size(124, 20);
            this.codigoTextView.TabIndex = 1;
            // 
            // buscarButton
            // 
            this.buscarButton.Location = new System.Drawing.Point(233, 61);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(75, 23);
            this.buscarButton.TabIndex = 2;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Razón Social";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cuit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Domicilio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Telefono";
            // 
            // razonSocialLabel
            // 
            this.razonSocialLabel.AutoSize = true;
            this.razonSocialLabel.Location = new System.Drawing.Point(126, 108);
            this.razonSocialLabel.Name = "razonSocialLabel";
            this.razonSocialLabel.Size = new System.Drawing.Size(70, 13);
            this.razonSocialLabel.TabIndex = 0;
            this.razonSocialLabel.Text = "Razón Social";
            // 
            // cuitLabel
            // 
            this.cuitLabel.AutoSize = true;
            this.cuitLabel.Location = new System.Drawing.Point(126, 138);
            this.cuitLabel.Name = "cuitLabel";
            this.cuitLabel.Size = new System.Drawing.Size(25, 13);
            this.cuitLabel.TabIndex = 0;
            this.cuitLabel.Text = "Cuit";
            // 
            // domicilioLabel
            // 
            this.domicilioLabel.AutoSize = true;
            this.domicilioLabel.Location = new System.Drawing.Point(126, 167);
            this.domicilioLabel.Name = "domicilioLabel";
            this.domicilioLabel.Size = new System.Drawing.Size(49, 13);
            this.domicilioLabel.TabIndex = 0;
            this.domicilioLabel.Text = "Domicilio";
            // 
            // telefonoLabel
            // 
            this.telefonoLabel.AutoSize = true;
            this.telefonoLabel.Location = new System.Drawing.Point(126, 197);
            this.telefonoLabel.Name = "telefonoLabel";
            this.telefonoLabel.Size = new System.Drawing.Size(49, 13);
            this.telefonoLabel.TabIndex = 0;
            this.telefonoLabel.Text = "Telefono";
            // 
            // compraDataGrid
            // 
            this.compraDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.compraDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdMaterial,
            this.colDescripcion,
            this.colCantidad});
            this.compraDataGrid.Location = new System.Drawing.Point(609, 123);
            this.compraDataGrid.Name = "compraDataGrid";
            this.compraDataGrid.Size = new System.Drawing.Size(409, 385);
            this.compraDataGrid.TabIndex = 3;
            // 
            // colIdMaterial
            // 
            this.colIdMaterial.HeaderText = "Id Material";
            this.colIdMaterial.Name = "colIdMaterial";
            // 
            // colDescripcion
            // 
            this.colDescripcion.HeaderText = "Descripción";
            this.colDescripcion.Name = "colDescripcion";
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(606, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Lista de materiales a comprar";
            // 
            // materialesDataGrid
            // 
            this.materialesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdMat,
            this.colDesc,
            this.colStockMinimo,
            this.colStockDisponible});
            this.materialesDataGrid.Location = new System.Drawing.Point(43, 282);
            this.materialesDataGrid.Name = "materialesDataGrid";
            this.materialesDataGrid.Size = new System.Drawing.Size(442, 235);
            this.materialesDataGrid.TabIndex = 4;
            // 
            // colIdMat
            // 
            this.colIdMat.HeaderText = "Id Material";
            this.colIdMat.Name = "colIdMat";
            // 
            // colDesc
            // 
            this.colDesc.HeaderText = "Descripción";
            this.colDesc.Name = "colDesc";
            // 
            // colStockMinimo
            // 
            this.colStockMinimo.HeaderText = "Stock Minimo";
            this.colStockMinimo.Name = "colStockMinimo";
            // 
            // colStockDisponible
            // 
            this.colStockDisponible.HeaderText = "Stock Disponible";
            this.colStockDisponible.Name = "colStockDisponible";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 252);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Materiales Disponibles";
            // 
            // agregarButton
            // 
            this.agregarButton.Location = new System.Drawing.Point(524, 206);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Size = new System.Drawing.Size(54, 50);
            this.agregarButton.TabIndex = 5;
            this.agregarButton.Text = "Agregar";
            this.agregarButton.UseVisualStyleBackColor = true;
            this.agregarButton.Click += new System.EventHandler(this.agregarButton_Click);
            // 
            // quitarButton
            // 
            this.quitarButton.Location = new System.Drawing.Point(524, 282);
            this.quitarButton.Name = "quitarButton";
            this.quitarButton.Size = new System.Drawing.Size(54, 50);
            this.quitarButton.TabIndex = 5;
            this.quitarButton.Text = "Quitar";
            this.quitarButton.UseVisualStyleBackColor = true;
            this.quitarButton.Click += new System.EventHandler(this.quitarButton_Click);
            // 
            // confirmarButton
            // 
            this.confirmarButton.Location = new System.Drawing.Point(938, 528);
            this.confirmarButton.Name = "confirmarButton";
            this.confirmarButton.Size = new System.Drawing.Size(54, 30);
            this.confirmarButton.TabIndex = 5;
            this.confirmarButton.Text = "Confirmar";
            this.confirmarButton.UseVisualStyleBackColor = true;
            this.confirmarButton.Click += new System.EventHandler(this.confirmarButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(858, 528);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(54, 30);
            this.cancelarButton.TabIndex = 5;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(606, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Fecha de compra";
            // 
            // fechaLabel
            // 
            this.fechaLabel.AutoSize = true;
            this.fechaLabel.Location = new System.Drawing.Point(618, 61);
            this.fechaLabel.Name = "fechaLabel";
            this.fechaLabel.Size = new System.Drawing.Size(10, 13);
            this.fechaLabel.TabIndex = 0;
            this.fechaLabel.Text = "-";
            // 
            // NuevaCompraView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 582);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.confirmarButton);
            this.Controls.Add(this.quitarButton);
            this.Controls.Add(this.agregarButton);
            this.Controls.Add(this.materialesDataGrid);
            this.Controls.Add(this.compraDataGrid);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.codigoTextView);
            this.Controls.Add(this.telefonoLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.domicilioLabel);
            this.Controls.Add(this.cuitLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.razonSocialLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fechaLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Name = "NuevaCompraView";
            this.Text = "NuevaCompraView";
            ((System.ComponentModel.ISupportInitialize)(this.compraDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialesDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codigoTextView;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label razonSocialLabel;
        private System.Windows.Forms.Label cuitLabel;
        private System.Windows.Forms.Label domicilioLabel;
        private System.Windows.Forms.Label telefonoLabel;
        private System.Windows.Forms.DataGridView compraDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView materialesDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdMat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockMinimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockDisponible;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button agregarButton;
        private System.Windows.Forms.Button quitarButton;
        private System.Windows.Forms.Button confirmarButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label fechaLabel;
    }
}