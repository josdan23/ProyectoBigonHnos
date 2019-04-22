namespace ProyectoBigonHnos.vista.compra
{
    partial class CompraDetalleView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvMaterialesAComprar = new System.Windows.Forms.DataGridView();
            this.IdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadSolicitadaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaLabel = new System.Windows.Forms.Label();
            this.IdCompraLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.EstadoLabel = new System.Windows.Forms.Label();
            this.razonSocialLabel = new System.Windows.Forms.Label();
            this.CuilLabel = new System.Windows.Forms.Label();
            this.DomicilioLable = new System.Windows.Forms.Label();
            this.TelefonoLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnAprobar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialesAComprar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(16, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Materiales a comprar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Razon Social";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cuil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Domicilio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Telefono";
            // 
            // dgvMaterialesAComprar
            // 
            this.dgvMaterialesAComprar.AllowUserToAddRows = false;
            this.dgvMaterialesAComprar.AllowUserToDeleteRows = false;
            this.dgvMaterialesAComprar.AllowUserToResizeColumns = false;
            this.dgvMaterialesAComprar.AllowUserToResizeRows = false;
            this.dgvMaterialesAComprar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaterialesAComprar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvMaterialesAComprar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMaterialesAComprar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMaterialesAComprar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMaterialesAComprar.ColumnHeadersHeight = 40;
            this.dgvMaterialesAComprar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMaterialesAComprar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCol,
            this.descripcionCol,
            this.cantidadSolicitadaCol});
            this.dgvMaterialesAComprar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvMaterialesAComprar.Location = new System.Drawing.Point(12, 258);
            this.dgvMaterialesAComprar.MultiSelect = false;
            this.dgvMaterialesAComprar.Name = "dgvMaterialesAComprar";
            this.dgvMaterialesAComprar.ReadOnly = true;
            this.dgvMaterialesAComprar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMaterialesAComprar.RowHeadersVisible = false;
            this.dgvMaterialesAComprar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMaterialesAComprar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvMaterialesAComprar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterialesAComprar.ShowCellErrors = false;
            this.dgvMaterialesAComprar.ShowCellToolTips = false;
            this.dgvMaterialesAComprar.ShowEditingIcon = false;
            this.dgvMaterialesAComprar.ShowRowErrors = false;
            this.dgvMaterialesAComprar.Size = new System.Drawing.Size(641, 156);
            this.dgvMaterialesAComprar.TabIndex = 2;
            // 
            // IdCol
            // 
            this.IdCol.HeaderText = "Id";
            this.IdCol.Name = "IdCol";
            this.IdCol.ReadOnly = true;
            // 
            // descripcionCol
            // 
            this.descripcionCol.HeaderText = "Descripcion";
            this.descripcionCol.Name = "descripcionCol";
            this.descripcionCol.ReadOnly = true;
            // 
            // cantidadSolicitadaCol
            // 
            this.cantidadSolicitadaCol.HeaderText = "Cantidad Solicitada";
            this.cantidadSolicitadaCol.Name = "cantidadSolicitadaCol";
            this.cantidadSolicitadaCol.ReadOnly = true;
            // 
            // FechaLabel
            // 
            this.FechaLabel.AutoSize = true;
            this.FechaLabel.Location = new System.Drawing.Point(509, 26);
            this.FechaLabel.Name = "FechaLabel";
            this.FechaLabel.Size = new System.Drawing.Size(10, 13);
            this.FechaLabel.TabIndex = 1;
            this.FechaLabel.Text = "-";
            // 
            // IdCompraLabel
            // 
            this.IdCompraLabel.AutoSize = true;
            this.IdCompraLabel.Location = new System.Drawing.Point(508, 52);
            this.IdCompraLabel.Name = "IdCompraLabel";
            this.IdCompraLabel.Size = new System.Drawing.Size(10, 13);
            this.IdCompraLabel.TabIndex = 1;
            this.IdCompraLabel.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(808, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Razon Social";
            // 
            // EstadoLabel
            // 
            this.EstadoLabel.AutoSize = true;
            this.EstadoLabel.Location = new System.Drawing.Point(508, 78);
            this.EstadoLabel.Name = "EstadoLabel";
            this.EstadoLabel.Size = new System.Drawing.Size(10, 13);
            this.EstadoLabel.TabIndex = 1;
            this.EstadoLabel.Text = "-";
            // 
            // razonSocialLabel
            // 
            this.razonSocialLabel.AutoSize = true;
            this.razonSocialLabel.Location = new System.Drawing.Point(143, 21);
            this.razonSocialLabel.Name = "razonSocialLabel";
            this.razonSocialLabel.Size = new System.Drawing.Size(10, 13);
            this.razonSocialLabel.TabIndex = 1;
            this.razonSocialLabel.Text = "-";
            // 
            // CuilLabel
            // 
            this.CuilLabel.AutoSize = true;
            this.CuilLabel.Location = new System.Drawing.Point(143, 47);
            this.CuilLabel.Name = "CuilLabel";
            this.CuilLabel.Size = new System.Drawing.Size(10, 13);
            this.CuilLabel.TabIndex = 1;
            this.CuilLabel.Text = "-";
            // 
            // DomicilioLable
            // 
            this.DomicilioLable.AutoSize = true;
            this.DomicilioLable.Location = new System.Drawing.Point(143, 73);
            this.DomicilioLable.Name = "DomicilioLable";
            this.DomicilioLable.Size = new System.Drawing.Size(10, 13);
            this.DomicilioLable.TabIndex = 1;
            this.DomicilioLable.Text = "-";
            // 
            // TelefonoLabel
            // 
            this.TelefonoLabel.AutoSize = true;
            this.TelefonoLabel.Location = new System.Drawing.Point(143, 99);
            this.TelefonoLabel.Name = "TelefonoLabel";
            this.TelefonoLabel.Size = new System.Drawing.Size(10, 13);
            this.TelefonoLabel.TabIndex = 1;
            this.TelefonoLabel.Text = "-";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(381, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Fecha de compra";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(431, 78);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Estado";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(416, 52);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Id Compra";
            // 
            // btnAprobar
            // 
            this.btnAprobar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAprobar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAprobar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAprobar.Location = new System.Drawing.Point(578, 25);
            this.btnAprobar.Name = "btnAprobar";
            this.btnAprobar.Size = new System.Drawing.Size(75, 32);
            this.btnAprobar.TabIndex = 3;
            this.btnAprobar.Text = "Aprobar";
            this.btnAprobar.UseVisualStyleBackColor = false;
            this.btnAprobar.Click += new System.EventHandler(this.btnAprobar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(578, 441);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 32);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(16, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Información de compra";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.CuilLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.razonSocialLabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.IdCompraLabel);
            this.panel1.Controls.Add(this.TelefonoLabel);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.EstadoLabel);
            this.panel1.Controls.Add(this.DomicilioLable);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.FechaLabel);
            this.panel1.Location = new System.Drawing.Point(15, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 135);
            this.panel1.TabIndex = 5;
            // 
            // CompraDetalleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 491);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAprobar);
            this.Controls.Add(this.dgvMaterialesAComprar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CompraDetalleView";
            this.Text = "Detalle de la compra";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialesAComprar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvMaterialesAComprar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadSolicitadaCol;
        private System.Windows.Forms.Label FechaLabel;
        private System.Windows.Forms.Label IdCompraLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label EstadoLabel;
        private System.Windows.Forms.Label razonSocialLabel;
        private System.Windows.Forms.Label CuilLabel;
        private System.Windows.Forms.Label DomicilioLable;
        private System.Windows.Forms.Label TelefonoLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnAprobar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
    }
}