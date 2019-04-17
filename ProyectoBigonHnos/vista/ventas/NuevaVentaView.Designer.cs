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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxDni = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.colIdPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.productosTab = new System.Windows.Forms.TabPage();
            this.productosDgv = new System.Windows.Forms.DataGridView();
            this.idProdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionProdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.altoProdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anchoProdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profProdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorPCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorSCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialesTab = new System.Windows.Forms.TabPage();
            this.materialesDgv = new System.Windows.Forms.DataGridView();
            this.idMaterialCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreMatCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitarioCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubtotalCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargosExtrasTab = new System.Windows.Forms.TabPage();
            this.costosExtrasDgv = new System.Windows.Forms.DataGridView();
            this.descripcionCargoExtraCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.subtotalMaterialesLbl = new System.Windows.Forms.Label();
            this.subtotalCargosExtrasLbl = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.montoDeCuotasLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.clienteLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dniLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.domicilioLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.fechaDeVentaLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.vendedorLegajoLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.productosTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productosDgv)).BeginInit();
            this.materialesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialesDgv)).BeginInit();
            this.cargosExtrasTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.costosExtrasDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(1073, 529);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(980, 529);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dni de cliente";
            // 
            // tboxDni
            // 
            this.tboxDni.Location = new System.Drawing.Point(109, 54);
            this.tboxDni.Name = "tboxDni";
            this.tboxDni.Size = new System.Drawing.Size(208, 20);
            this.tboxDni.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(325, 52);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.AllowUserToResizeColumns = false;
            this.dgvPedidos.AllowUserToResizeRows = false;
            this.dgvPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPedidos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvPedidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPedidos.ColumnHeadersHeight = 40;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdPedido,
            this.colCliente,
            this.colFechaPedido});
            this.dgvPedidos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPedidos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvPedidos.Location = new System.Drawing.Point(24, 104);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvPedidos.RowHeadersVisible = false;
            this.dgvPedidos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPedidos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.ShowCellErrors = false;
            this.dgvPedidos.ShowCellToolTips = false;
            this.dgvPedidos.ShowEditingIcon = false;
            this.dgvPedidos.ShowRowErrors = false;
            this.dgvPedidos.Size = new System.Drawing.Size(376, 303);
            this.dgvPedidos.TabIndex = 4;
            this.dgvPedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.seleccionarPedido);
            // 
            // colIdPedido
            // 
            this.colIdPedido.HeaderText = "Id Pedido";
            this.colIdPedido.Name = "colIdPedido";
            this.colIdPedido.ReadOnly = true;
            // 
            // colCliente
            // 
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.ReadOnly = true;
            // 
            // colFechaPedido
            // 
            this.colFechaPedido.HeaderText = "Fecha de Pedido";
            this.colFechaPedido.Name = "colFechaPedido";
            this.colFechaPedido.ReadOnly = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.productosTab);
            this.tabControl1.Controls.Add(this.materialesTab);
            this.tabControl1.Controls.Add(this.cargosExtrasTab);
            this.tabControl1.Location = new System.Drawing.Point(444, 104);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(708, 266);
            this.tabControl1.TabIndex = 5;
            // 
            // productosTab
            // 
            this.productosTab.Controls.Add(this.productosDgv);
            this.productosTab.Location = new System.Drawing.Point(4, 22);
            this.productosTab.Name = "productosTab";
            this.productosTab.Padding = new System.Windows.Forms.Padding(3);
            this.productosTab.Size = new System.Drawing.Size(700, 240);
            this.productosTab.TabIndex = 0;
            this.productosTab.Text = "Productos";
            this.productosTab.UseVisualStyleBackColor = true;
            // 
            // productosDgv
            // 
            this.productosDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productosDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProdCol,
            this.descripcionProdCol,
            this.altoProdCol,
            this.anchoProdCol,
            this.profProdCol,
            this.colorPCol,
            this.colorSCol});
            this.productosDgv.Location = new System.Drawing.Point(6, 6);
            this.productosDgv.Name = "productosDgv";
            this.productosDgv.Size = new System.Drawing.Size(688, 248);
            this.productosDgv.TabIndex = 0;
            // 
            // idProdCol
            // 
            this.idProdCol.HeaderText = "id";
            this.idProdCol.Name = "idProdCol";
            // 
            // descripcionProdCol
            // 
            this.descripcionProdCol.HeaderText = "Descripción";
            this.descripcionProdCol.Name = "descripcionProdCol";
            // 
            // altoProdCol
            // 
            this.altoProdCol.HeaderText = "Alto";
            this.altoProdCol.Name = "altoProdCol";
            // 
            // anchoProdCol
            // 
            this.anchoProdCol.HeaderText = "Ancho";
            this.anchoProdCol.Name = "anchoProdCol";
            // 
            // profProdCol
            // 
            this.profProdCol.HeaderText = "Profundidad";
            this.profProdCol.Name = "profProdCol";
            // 
            // colorPCol
            // 
            this.colorPCol.HeaderText = "Color Primario";
            this.colorPCol.Name = "colorPCol";
            // 
            // colorSCol
            // 
            this.colorSCol.HeaderText = "Color Secundario";
            this.colorSCol.Name = "colorSCol";
            // 
            // materialesTab
            // 
            this.materialesTab.Controls.Add(this.materialesDgv);
            this.materialesTab.Location = new System.Drawing.Point(4, 22);
            this.materialesTab.Name = "materialesTab";
            this.materialesTab.Padding = new System.Windows.Forms.Padding(3);
            this.materialesTab.Size = new System.Drawing.Size(700, 240);
            this.materialesTab.TabIndex = 1;
            this.materialesTab.Text = "Materiales";
            this.materialesTab.UseVisualStyleBackColor = true;
            // 
            // materialesDgv
            // 
            this.materialesDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialesDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMaterialCol,
            this.nombreMatCol,
            this.precioUnitarioCol,
            this.unidadCol,
            this.cantidadCol,
            this.SubtotalCol});
            this.materialesDgv.Location = new System.Drawing.Point(6, 6);
            this.materialesDgv.Name = "materialesDgv";
            this.materialesDgv.Size = new System.Drawing.Size(667, 267);
            this.materialesDgv.TabIndex = 0;
            // 
            // idMaterialCol
            // 
            this.idMaterialCol.HeaderText = "Id Material";
            this.idMaterialCol.Name = "idMaterialCol";
            // 
            // nombreMatCol
            // 
            this.nombreMatCol.HeaderText = "Material";
            this.nombreMatCol.Name = "nombreMatCol";
            // 
            // precioUnitarioCol
            // 
            this.precioUnitarioCol.HeaderText = "Precio Unitario";
            this.precioUnitarioCol.Name = "precioUnitarioCol";
            // 
            // unidadCol
            // 
            this.unidadCol.HeaderText = "Unidad";
            this.unidadCol.Name = "unidadCol";
            // 
            // cantidadCol
            // 
            this.cantidadCol.HeaderText = "Cantidad";
            this.cantidadCol.Name = "cantidadCol";
            // 
            // SubtotalCol
            // 
            this.SubtotalCol.HeaderText = "Subtotal";
            this.SubtotalCol.Name = "SubtotalCol";
            // 
            // cargosExtrasTab
            // 
            this.cargosExtrasTab.Controls.Add(this.costosExtrasDgv);
            this.cargosExtrasTab.Location = new System.Drawing.Point(4, 22);
            this.cargosExtrasTab.Name = "cargosExtrasTab";
            this.cargosExtrasTab.Padding = new System.Windows.Forms.Padding(3);
            this.cargosExtrasTab.Size = new System.Drawing.Size(700, 240);
            this.cargosExtrasTab.TabIndex = 2;
            this.cargosExtrasTab.Text = "Costos Extras";
            this.cargosExtrasTab.UseVisualStyleBackColor = true;
            // 
            // costosExtrasDgv
            // 
            this.costosExtrasDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.costosExtrasDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descripcionCargoExtraCol,
            this.montoCol});
            this.costosExtrasDgv.Location = new System.Drawing.Point(6, 6);
            this.costosExtrasDgv.Name = "costosExtrasDgv";
            this.costosExtrasDgv.Size = new System.Drawing.Size(663, 248);
            this.costosExtrasDgv.TabIndex = 0;
            // 
            // descripcionCargoExtraCol
            // 
            this.descripcionCargoExtraCol.HeaderText = "Descripcion";
            this.descripcionCargoExtraCol.Name = "descripcionCargoExtraCol";
            // 
            // montoCol
            // 
            this.montoCol.HeaderText = "Monto";
            this.montoCol.Name = "montoCol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(912, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Subtotal materiales";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(896, 449);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Subtotal cargos extras";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(977, 479);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total";
            // 
            // subtotalMaterialesLbl
            // 
            this.subtotalMaterialesLbl.AutoSize = true;
            this.subtotalMaterialesLbl.Location = new System.Drawing.Point(1038, 419);
            this.subtotalMaterialesLbl.Name = "subtotalMaterialesLbl";
            this.subtotalMaterialesLbl.Size = new System.Drawing.Size(35, 13);
            this.subtotalMaterialesLbl.TabIndex = 6;
            this.subtotalMaterialesLbl.Text = "label2";
            // 
            // subtotalCargosExtrasLbl
            // 
            this.subtotalCargosExtrasLbl.AutoSize = true;
            this.subtotalCargosExtrasLbl.Location = new System.Drawing.Point(1038, 449);
            this.subtotalCargosExtrasLbl.Name = "subtotalCargosExtrasLbl";
            this.subtotalCargosExtrasLbl.Size = new System.Drawing.Size(35, 13);
            this.subtotalCargosExtrasLbl.TabIndex = 6;
            this.subtotalCargosExtrasLbl.Text = "label2";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(1038, 479);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(35, 13);
            this.totalLabel.TabIndex = 6;
            this.totalLabel.Text = "label2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(451, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "DETALLE DE VENTA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(471, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Número de ctas";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "3",
            "6",
            "9",
            "12",
            "18"});
            this.comboBox1.Location = new System.Drawing.Point(474, 428);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(79, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // montoDeCuotasLabel
            // 
            this.montoDeCuotasLabel.AutoSize = true;
            this.montoDeCuotasLabel.Location = new System.Drawing.Point(587, 434);
            this.montoDeCuotasLabel.Name = "montoDeCuotasLabel";
            this.montoDeCuotasLabel.Size = new System.Drawing.Size(82, 13);
            this.montoDeCuotasLabel.TabIndex = 7;
            this.montoDeCuotasLabel.Text = "Número de ctas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(445, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Cliente";
            // 
            // clienteLabel
            // 
            this.clienteLabel.AutoSize = true;
            this.clienteLabel.Location = new System.Drawing.Point(514, 49);
            this.clienteLabel.Name = "clienteLabel";
            this.clienteLabel.Size = new System.Drawing.Size(10, 13);
            this.clienteLabel.TabIndex = 7;
            this.clienteLabel.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(613, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Dni";
            // 
            // dniLabel
            // 
            this.dniLabel.AutoSize = true;
            this.dniLabel.Location = new System.Drawing.Point(666, 49);
            this.dniLabel.Name = "dniLabel";
            this.dniLabel.Size = new System.Drawing.Size(10, 13);
            this.dniLabel.TabIndex = 7;
            this.dniLabel.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(445, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Domicilio";
            // 
            // domicilioLabel
            // 
            this.domicilioLabel.AutoSize = true;
            this.domicilioLabel.Location = new System.Drawing.Point(514, 74);
            this.domicilioLabel.Name = "domicilioLabel";
            this.domicilioLabel.Size = new System.Drawing.Size(10, 13);
            this.domicilioLabel.TabIndex = 7;
            this.domicilioLabel.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(947, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Fecha de venta";
            // 
            // fechaDeVentaLabel
            // 
            this.fechaDeVentaLabel.AutoSize = true;
            this.fechaDeVentaLabel.Location = new System.Drawing.Point(1045, 88);
            this.fechaDeVentaLabel.Name = "fechaDeVentaLabel";
            this.fechaDeVentaLabel.Size = new System.Drawing.Size(10, 13);
            this.fechaDeVentaLabel.TabIndex = 7;
            this.fechaDeVentaLabel.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(942, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Legajo vendedor";
            // 
            // vendedorLegajoLbl
            // 
            this.vendedorLegajoLbl.AutoSize = true;
            this.vendedorLegajoLbl.Location = new System.Drawing.Point(1045, 36);
            this.vendedorLegajoLbl.Name = "vendedorLegajoLbl";
            this.vendedorLegajoLbl.Size = new System.Drawing.Size(10, 13);
            this.vendedorLegajoLbl.TabIndex = 7;
            this.vendedorLegajoLbl.Text = "-";
            // 
            // NuevaVentaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1164, 580);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.montoDeCuotasLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.vendedorLegajoLbl);
            this.Controls.Add(this.fechaDeVentaLabel);
            this.Controls.Add(this.dniLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.clienteLabel);
            this.Controls.Add(this.domicilioLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.subtotalCargosExtrasLbl);
            this.Controls.Add(this.subtotalMaterialesLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tboxDni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Name = "NuevaVentaView";
            this.Text = "NuevaVentaView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.productosTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productosDgv)).EndInit();
            this.materialesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.materialesDgv)).EndInit();
            this.cargosExtrasTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.costosExtrasDgv)).EndInit();
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage productosTab;
        private System.Windows.Forms.DataGridView productosDgv;
        private System.Windows.Forms.TabPage materialesTab;
        private System.Windows.Forms.TabPage cargosExtrasTab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label subtotalMaterialesLbl;
        private System.Windows.Forms.Label subtotalCargosExtrasLbl;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionProdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn altoProdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn anchoProdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn profProdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorPCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorSCol;
        private System.Windows.Forms.DataGridView materialesDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMaterialCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMatCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitarioCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubtotalCol;
        private System.Windows.Forms.DataGridView costosExtrasDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionCargoExtraCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoCol;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label montoDeCuotasLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label clienteLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label dniLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label domicilioLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label fechaDeVentaLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label vendedorLegajoLbl;
    }
}