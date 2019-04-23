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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.productosTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productosDgv)).BeginInit();
            this.materialesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialesDgv)).BeginInit();
            this.cargosExtrasTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.costosExtrasDgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(1076, 529);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 32);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(983, 529);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 32);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(18, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dni de cliente";
            // 
            // tboxDni
            // 
            this.tboxDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxDni.Location = new System.Drawing.Point(129, 52);
            this.tboxDni.Name = "tboxDni";
            this.tboxDni.Size = new System.Drawing.Size(177, 20);
            this.tboxDni.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(312, 51);
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPedidos.ColumnHeadersHeight = 40;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdPedido,
            this.colCliente,
            this.colFechaPedido});
            this.dgvPedidos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPedidos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvPedidos.Location = new System.Drawing.Point(21, 87);
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
            this.dgvPedidos.Size = new System.Drawing.Size(366, 357);
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
            this.tabControl1.ItemSize = new System.Drawing.Size(60, 32);
            this.tabControl1.Location = new System.Drawing.Point(21, 127);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(694, 238);
            this.tabControl1.TabIndex = 5;
            // 
            // productosTab
            // 
            this.productosTab.Controls.Add(this.productosDgv);
            this.productosTab.Location = new System.Drawing.Point(4, 36);
            this.productosTab.Name = "productosTab";
            this.productosTab.Padding = new System.Windows.Forms.Padding(3);
            this.productosTab.Size = new System.Drawing.Size(686, 198);
            this.productosTab.TabIndex = 0;
            this.productosTab.Text = "Productos";
            this.productosTab.UseVisualStyleBackColor = true;
            // 
            // productosDgv
            // 
            this.productosDgv.AllowUserToAddRows = false;
            this.productosDgv.AllowUserToDeleteRows = false;
            this.productosDgv.AllowUserToResizeColumns = false;
            this.productosDgv.AllowUserToResizeRows = false;
            this.productosDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productosDgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.productosDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productosDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productosDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.productosDgv.ColumnHeadersHeight = 40;
            this.productosDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProdCol,
            this.descripcionProdCol,
            this.altoProdCol,
            this.anchoProdCol,
            this.profProdCol,
            this.colorPCol,
            this.colorSCol});
            this.productosDgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.productosDgv.Location = new System.Drawing.Point(6, 6);
            this.productosDgv.MultiSelect = false;
            this.productosDgv.Name = "productosDgv";
            this.productosDgv.ReadOnly = true;
            this.productosDgv.RowHeadersVisible = false;
            this.productosDgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.productosDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productosDgv.ShowCellErrors = false;
            this.productosDgv.ShowCellToolTips = false;
            this.productosDgv.ShowEditingIcon = false;
            this.productosDgv.ShowRowErrors = false;
            this.productosDgv.Size = new System.Drawing.Size(674, 186);
            this.productosDgv.TabIndex = 0;
            // 
            // idProdCol
            // 
            this.idProdCol.HeaderText = "id";
            this.idProdCol.Name = "idProdCol";
            this.idProdCol.ReadOnly = true;
            // 
            // descripcionProdCol
            // 
            this.descripcionProdCol.HeaderText = "Descripción";
            this.descripcionProdCol.Name = "descripcionProdCol";
            this.descripcionProdCol.ReadOnly = true;
            // 
            // altoProdCol
            // 
            this.altoProdCol.HeaderText = "Alto";
            this.altoProdCol.Name = "altoProdCol";
            this.altoProdCol.ReadOnly = true;
            // 
            // anchoProdCol
            // 
            this.anchoProdCol.HeaderText = "Ancho";
            this.anchoProdCol.Name = "anchoProdCol";
            this.anchoProdCol.ReadOnly = true;
            // 
            // profProdCol
            // 
            this.profProdCol.HeaderText = "Profundidad";
            this.profProdCol.Name = "profProdCol";
            this.profProdCol.ReadOnly = true;
            // 
            // colorPCol
            // 
            this.colorPCol.HeaderText = "Color Primario";
            this.colorPCol.Name = "colorPCol";
            this.colorPCol.ReadOnly = true;
            // 
            // colorSCol
            // 
            this.colorSCol.HeaderText = "Color Secundario";
            this.colorSCol.Name = "colorSCol";
            this.colorSCol.ReadOnly = true;
            // 
            // materialesTab
            // 
            this.materialesTab.Controls.Add(this.materialesDgv);
            this.materialesTab.Location = new System.Drawing.Point(4, 36);
            this.materialesTab.Name = "materialesTab";
            this.materialesTab.Padding = new System.Windows.Forms.Padding(3);
            this.materialesTab.Size = new System.Drawing.Size(686, 198);
            this.materialesTab.TabIndex = 1;
            this.materialesTab.Text = "Materiales";
            this.materialesTab.UseVisualStyleBackColor = true;
            // 
            // materialesDgv
            // 
            this.materialesDgv.AllowUserToAddRows = false;
            this.materialesDgv.AllowUserToDeleteRows = false;
            this.materialesDgv.AllowUserToResizeColumns = false;
            this.materialesDgv.AllowUserToResizeRows = false;
            this.materialesDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.materialesDgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.materialesDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialesDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.materialesDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.materialesDgv.ColumnHeadersHeight = 40;
            this.materialesDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMaterialCol,
            this.nombreMatCol,
            this.precioUnitarioCol,
            this.unidadCol,
            this.cantidadCol,
            this.SubtotalCol});
            this.materialesDgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.materialesDgv.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.materialesDgv.Location = new System.Drawing.Point(6, 6);
            this.materialesDgv.MultiSelect = false;
            this.materialesDgv.Name = "materialesDgv";
            this.materialesDgv.RowHeadersVisible = false;
            this.materialesDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.materialesDgv.ShowCellErrors = false;
            this.materialesDgv.ShowCellToolTips = false;
            this.materialesDgv.ShowEditingIcon = false;
            this.materialesDgv.ShowRowErrors = false;
            this.materialesDgv.Size = new System.Drawing.Size(674, 186);
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
            this.cargosExtrasTab.Location = new System.Drawing.Point(4, 36);
            this.cargosExtrasTab.Name = "cargosExtrasTab";
            this.cargosExtrasTab.Padding = new System.Windows.Forms.Padding(3);
            this.cargosExtrasTab.Size = new System.Drawing.Size(686, 198);
            this.cargosExtrasTab.TabIndex = 2;
            this.cargosExtrasTab.Text = "Costos Extras";
            this.cargosExtrasTab.UseVisualStyleBackColor = true;
            // 
            // costosExtrasDgv
            // 
            this.costosExtrasDgv.AllowUserToAddRows = false;
            this.costosExtrasDgv.AllowUserToDeleteRows = false;
            this.costosExtrasDgv.AllowUserToResizeColumns = false;
            this.costosExtrasDgv.AllowUserToResizeRows = false;
            this.costosExtrasDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.costosExtrasDgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.costosExtrasDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.costosExtrasDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.costosExtrasDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.costosExtrasDgv.ColumnHeadersHeight = 40;
            this.costosExtrasDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descripcionCargoExtraCol,
            this.montoCol});
            this.costosExtrasDgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.costosExtrasDgv.Location = new System.Drawing.Point(6, 6);
            this.costosExtrasDgv.MultiSelect = false;
            this.costosExtrasDgv.Name = "costosExtrasDgv";
            this.costosExtrasDgv.ReadOnly = true;
            this.costosExtrasDgv.RowHeadersVisible = false;
            this.costosExtrasDgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.costosExtrasDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.costosExtrasDgv.ShowCellErrors = false;
            this.costosExtrasDgv.ShowCellToolTips = false;
            this.costosExtrasDgv.ShowEditingIcon = false;
            this.costosExtrasDgv.ShowRowErrors = false;
            this.costosExtrasDgv.Size = new System.Drawing.Size(674, 186);
            this.costosExtrasDgv.TabIndex = 0;
            // 
            // descripcionCargoExtraCol
            // 
            this.descripcionCargoExtraCol.HeaderText = "Descripcion";
            this.descripcionCargoExtraCol.Name = "descripcionCargoExtraCol";
            this.descripcionCargoExtraCol.ReadOnly = true;
            // 
            // montoCol
            // 
            this.montoCol.HeaderText = "Monto";
            this.montoCol.Name = "montoCol";
            this.montoCol.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(514, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Subtotal materiales";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(499, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Subtotal cargos extras";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(593, 440);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total";
            // 
            // subtotalMaterialesLbl
            // 
            this.subtotalMaterialesLbl.AutoSize = true;
            this.subtotalMaterialesLbl.Location = new System.Drawing.Point(640, 380);
            this.subtotalMaterialesLbl.Name = "subtotalMaterialesLbl";
            this.subtotalMaterialesLbl.Size = new System.Drawing.Size(10, 13);
            this.subtotalMaterialesLbl.TabIndex = 6;
            this.subtotalMaterialesLbl.Text = "-";
            // 
            // subtotalCargosExtrasLbl
            // 
            this.subtotalCargosExtrasLbl.AutoSize = true;
            this.subtotalCargosExtrasLbl.Location = new System.Drawing.Point(640, 410);
            this.subtotalCargosExtrasLbl.Name = "subtotalCargosExtrasLbl";
            this.subtotalCargosExtrasLbl.Size = new System.Drawing.Size(10, 13);
            this.subtotalCargosExtrasLbl.TabIndex = 6;
            this.subtotalCargosExtrasLbl.Text = "-";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.ForeColor = System.Drawing.Color.Maroon;
            this.totalLabel.Location = new System.Drawing.Point(640, 440);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(10, 13);
            this.totalLabel.TabIndex = 6;
            this.totalLabel.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(423, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "DETALLE DE VENTA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Número de ctas";
            this.label6.Visible = false;
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
            this.comboBox1.Location = new System.Drawing.Point(51, 400);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(79, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // montoDeCuotasLabel
            // 
            this.montoDeCuotasLabel.AutoSize = true;
            this.montoDeCuotasLabel.Location = new System.Drawing.Point(146, 403);
            this.montoDeCuotasLabel.Name = "montoDeCuotasLabel";
            this.montoDeCuotasLabel.Size = new System.Drawing.Size(82, 13);
            this.montoDeCuotasLabel.TabIndex = 7;
            this.montoDeCuotasLabel.Text = "Número de ctas";
            this.montoDeCuotasLabel.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Cliente";
            // 
            // clienteLabel
            // 
            this.clienteLabel.AutoSize = true;
            this.clienteLabel.Location = new System.Drawing.Point(103, 29);
            this.clienteLabel.Name = "clienteLabel";
            this.clienteLabel.Size = new System.Drawing.Size(10, 13);
            this.clienteLabel.TabIndex = 7;
            this.clienteLabel.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(202, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Dni";
            // 
            // dniLabel
            // 
            this.dniLabel.AutoSize = true;
            this.dniLabel.Location = new System.Drawing.Point(255, 29);
            this.dniLabel.Name = "dniLabel";
            this.dniLabel.Size = new System.Drawing.Size(10, 13);
            this.dniLabel.TabIndex = 7;
            this.dniLabel.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Domicilio";
            // 
            // domicilioLabel
            // 
            this.domicilioLabel.AutoSize = true;
            this.domicilioLabel.Location = new System.Drawing.Point(103, 54);
            this.domicilioLabel.Name = "domicilioLabel";
            this.domicilioLabel.Size = new System.Drawing.Size(10, 13);
            this.domicilioLabel.TabIndex = 7;
            this.domicilioLabel.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(521, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Fecha de venta";
            // 
            // fechaDeVentaLabel
            // 
            this.fechaDeVentaLabel.AutoSize = true;
            this.fechaDeVentaLabel.Location = new System.Drawing.Point(619, 29);
            this.fechaDeVentaLabel.Name = "fechaDeVentaLabel";
            this.fechaDeVentaLabel.Size = new System.Drawing.Size(10, 13);
            this.fechaDeVentaLabel.TabIndex = 7;
            this.fechaDeVentaLabel.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1002, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Legajo vendedor";
            // 
            // vendedorLegajoLbl
            // 
            this.vendedorLegajoLbl.AutoSize = true;
            this.vendedorLegajoLbl.Location = new System.Drawing.Point(1105, 23);
            this.vendedorLegajoLbl.Name = "vendedorLegajoLbl";
            this.vendedorLegajoLbl.Size = new System.Drawing.Size(10, 13);
            this.vendedorLegajoLbl.TabIndex = 7;
            this.vendedorLegajoLbl.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(18, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 18);
            this.label12.TabIndex = 1;
            this.label12.Text = "Pedidos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.tboxDni);
            this.groupBox1.Controls.Add(this.dgvPedidos);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 470);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(11, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 18);
            this.label13.TabIndex = 1;
            this.label13.Text = "NUEVA VENTA";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Controls.Add(this.montoDeCuotasLabel);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.subtotalMaterialesLbl);
            this.groupBox2.Controls.Add(this.subtotalCargosExtrasLbl);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.totalLabel);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(426, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(725, 470);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.domicilioLabel);
            this.panel1.Controls.Add(this.fechaDeVentaLabel);
            this.panel1.Controls.Add(this.clienteLabel);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dniLabel);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(21, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 91);
            this.panel1.TabIndex = 9;
            // 
            // NuevaVentaView
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(1164, 571);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.vendedorLegajoLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NuevaVentaView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva venta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.productosTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productosDgv)).EndInit();
            this.materialesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.materialesDgv)).EndInit();
            this.cargosExtrasTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.costosExtrasDgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
    }
}