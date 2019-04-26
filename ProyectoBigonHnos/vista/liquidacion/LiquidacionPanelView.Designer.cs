namespace ProyectoBigonHnos.vista.liquidacion
{
    partial class LiquidacionPanelView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.liquidacionDgv = new System.Windows.Forms.DataGridView();
            this.periodoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.legajoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLiquidacionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.periodoCombobox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.detalleBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liquidacionDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 62);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(244, 62);
            this.panel3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Liquidación";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.btnEditar);
            this.panel2.Controls.Add(this.btnNuevo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(142, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(712, 62);
            this.panel2.TabIndex = 4;
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
            this.btnEditar.Text = "Liquidar";
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
            this.btnNuevo.Location = new System.Drawing.Point(392, 8);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(111, 42);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Conceptos";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // liquidacionDgv
            // 
            this.liquidacionDgv.AllowUserToAddRows = false;
            this.liquidacionDgv.AllowUserToDeleteRows = false;
            this.liquidacionDgv.AllowUserToResizeColumns = false;
            this.liquidacionDgv.AllowUserToResizeRows = false;
            this.liquidacionDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.liquidacionDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.liquidacionDgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.liquidacionDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.liquidacionDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.liquidacionDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.liquidacionDgv.ColumnHeadersHeight = 40;
            this.liquidacionDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.periodoCol,
            this.legajoCol,
            this.colApellido,
            this.nombreCol,
            this.idLiquidacionCol});
            this.liquidacionDgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.liquidacionDgv.Location = new System.Drawing.Point(29, 171);
            this.liquidacionDgv.MultiSelect = false;
            this.liquidacionDgv.Name = "liquidacionDgv";
            this.liquidacionDgv.ReadOnly = true;
            this.liquidacionDgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.liquidacionDgv.RowHeadersVisible = false;
            this.liquidacionDgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.liquidacionDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.liquidacionDgv.ShowCellErrors = false;
            this.liquidacionDgv.ShowCellToolTips = false;
            this.liquidacionDgv.ShowEditingIcon = false;
            this.liquidacionDgv.ShowRowErrors = false;
            this.liquidacionDgv.Size = new System.Drawing.Size(790, 340);
            this.liquidacionDgv.TabIndex = 1;
            this.liquidacionDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.seleccionarFila);
            // 
            // periodoCol
            // 
            this.periodoCol.HeaderText = "Periodo";
            this.periodoCol.Name = "periodoCol";
            this.periodoCol.ReadOnly = true;
            // 
            // legajoCol
            // 
            this.legajoCol.HeaderText = "Legajo";
            this.legajoCol.Name = "legajoCol";
            this.legajoCol.ReadOnly = true;
            // 
            // colApellido
            // 
            this.colApellido.HeaderText = "Apellido";
            this.colApellido.Name = "colApellido";
            this.colApellido.ReadOnly = true;
            // 
            // nombreCol
            // 
            this.nombreCol.HeaderText = "Nombre";
            this.nombreCol.Name = "nombreCol";
            this.nombreCol.ReadOnly = true;
            // 
            // idLiquidacionCol
            // 
            this.idLiquidacionCol.HeaderText = "Id liquidacion";
            this.idLiquidacionCol.Name = "idLiquidacionCol";
            this.idLiquidacionCol.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(28, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Periodo";
            // 
            // periodoCombobox
            // 
            this.periodoCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.periodoCombobox.FormattingEnabled = true;
            this.periodoCombobox.Location = new System.Drawing.Point(94, 130);
            this.periodoCombobox.Name = "periodoCombobox";
            this.periodoCombobox.Size = new System.Drawing.Size(173, 21);
            this.periodoCombobox.TabIndex = 3;
            this.periodoCombobox.SelectedIndexChanged += new System.EventHandler(this.periodoCombobox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(26, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lista de liquidaciones";
            // 
            // detalleBtn
            // 
            this.detalleBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.detalleBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.detalleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detalleBtn.Location = new System.Drawing.Point(730, 123);
            this.detalleBtn.Name = "detalleBtn";
            this.detalleBtn.Size = new System.Drawing.Size(89, 32);
            this.detalleBtn.TabIndex = 4;
            this.detalleBtn.Text = "Detalle";
            this.detalleBtn.UseVisualStyleBackColor = true;
            this.detalleBtn.Click += new System.EventHandler(this.detalleBtn_Click);
            // 
            // LiquidacionPanelView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.detalleBtn);
            this.Controls.Add(this.periodoCombobox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.liquidacionDgv);
            this.Controls.Add(this.panel1);
            this.Name = "LiquidacionPanelView";
            this.Size = new System.Drawing.Size(854, 556);
            this.Load += new System.EventHandler(this.LiquidacionPanelView_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.liquidacionDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView liquidacionDgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox periodoCombobox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button detalleBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn legajoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLiquidacionCol;
    }
}
