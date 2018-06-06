namespace ProyectoBigonHnos.vista.ventas
{
    partial class NuevaVentaView
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxDni = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.colIdPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDetalles = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(330, 392);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(209, 392);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dni de cliente";
            // 
            // tboxDni
            // 
            this.tboxDni.Location = new System.Drawing.Point(104, 57);
            this.tboxDni.Name = "tboxDni";
            this.tboxDni.Size = new System.Drawing.Size(208, 20);
            this.tboxDni.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(330, 57);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdPedido,
            this.colCliente,
            this.colFechaPedido});
            this.dgvPedidos.Location = new System.Drawing.Point(29, 104);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.Size = new System.Drawing.Size(376, 213);
            this.dgvPedidos.TabIndex = 4;
            // 
            // colIdPedido
            // 
            this.colIdPedido.HeaderText = "Id Pedido";
            this.colIdPedido.Name = "colIdPedido";
            // 
            // colCliente
            // 
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.Name = "colCliente";
            // 
            // colFechaPedido
            // 
            this.colFechaPedido.HeaderText = "Fecha de Pedido";
            this.colFechaPedido.Name = "colFechaPedido";
            // 
            // btnDetalles
            // 
            this.btnDetalles.Location = new System.Drawing.Point(29, 323);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(75, 23);
            this.btnDetalles.TabIndex = 0;
            this.btnDetalles.Text = "Detalle";
            this.btnDetalles.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NUEVA VENTA";
            // 
            // NuevaVentaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 450);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tboxDni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDetalles);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Name = "NuevaVentaView";
            this.Text = "NuevaVentaView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxDni;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaPedido;
        private System.Windows.Forms.Button btnDetalles;
        private System.Windows.Forms.Label label2;
    }
}