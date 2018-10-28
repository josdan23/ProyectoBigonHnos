namespace ProyectoBigonHnos.vista.conceptos
{
    partial class ConceptosView
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
            this.conceptosDataGrid = new System.Windows.Forms.DataGridView();
            this.colIdConcepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcionConcepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.idConceptoDetalleTextView = new System.Windows.Forms.TextBox();
            this.descripcionDetalleTextView = new System.Windows.Forms.TextBox();
            this.tipoDetalleTextView = new System.Windows.Forms.TextBox();
            this.porcentajeDetalleTextView = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.descripcionNuevoTextView = new System.Windows.Forms.TextBox();
            this.porcentajeNuevoTextView = new System.Windows.Forms.TextBox();
            this.agregarButton = new System.Windows.Forms.Button();
            this.tipoNuevoComboBox = new System.Windows.Forms.ComboBox();
            this.obligatorioNuevoComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.obligatorioDetalleTextView = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.eliminarConceptoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.conceptosDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conceptos Agregados";
            // 
            // conceptosDataGrid
            // 
            this.conceptosDataGrid.AllowUserToAddRows = false;
            this.conceptosDataGrid.AllowUserToDeleteRows = false;
            this.conceptosDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.conceptosDataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.conceptosDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.conceptosDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.conceptosDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdConcepto,
            this.colDescripcionConcepto});
            this.conceptosDataGrid.GridColor = System.Drawing.SystemColors.InactiveBorder;
            this.conceptosDataGrid.Location = new System.Drawing.Point(26, 56);
            this.conceptosDataGrid.Name = "conceptosDataGrid";
            this.conceptosDataGrid.ReadOnly = true;
            this.conceptosDataGrid.RowHeadersWidth = 25;
            this.conceptosDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.conceptosDataGrid.Size = new System.Drawing.Size(221, 323);
            this.conceptosDataGrid.TabIndex = 1;
            this.conceptosDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.seleccionarFila);
            // 
            // colIdConcepto
            // 
            this.colIdConcepto.HeaderText = "Id";
            this.colIdConcepto.Name = "colIdConcepto";
            this.colIdConcepto.ReadOnly = true;
            // 
            // colDescripcionConcepto
            // 
            this.colDescripcionConcepto.HeaderText = "Concepto";
            this.colDescripcionConcepto.Name = "colDescripcionConcepto";
            this.colDescripcionConcepto.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Id concepto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Descripción";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tipo ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Porcentaje";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Obligatorio";
            // 
            // idConceptoDetalleTextView
            // 
            this.idConceptoDetalleTextView.Location = new System.Drawing.Point(23, 44);
            this.idConceptoDetalleTextView.Name = "idConceptoDetalleTextView";
            this.idConceptoDetalleTextView.ReadOnly = true;
            this.idConceptoDetalleTextView.Size = new System.Drawing.Size(100, 20);
            this.idConceptoDetalleTextView.TabIndex = 2;
            // 
            // descripcionDetalleTextView
            // 
            this.descripcionDetalleTextView.Location = new System.Drawing.Point(172, 44);
            this.descripcionDetalleTextView.Name = "descripcionDetalleTextView";
            this.descripcionDetalleTextView.ReadOnly = true;
            this.descripcionDetalleTextView.Size = new System.Drawing.Size(258, 20);
            this.descripcionDetalleTextView.TabIndex = 2;
            // 
            // tipoDetalleTextView
            // 
            this.tipoDetalleTextView.Location = new System.Drawing.Point(23, 96);
            this.tipoDetalleTextView.Name = "tipoDetalleTextView";
            this.tipoDetalleTextView.ReadOnly = true;
            this.tipoDetalleTextView.Size = new System.Drawing.Size(100, 20);
            this.tipoDetalleTextView.TabIndex = 2;
            // 
            // porcentajeDetalleTextView
            // 
            this.porcentajeDetalleTextView.Location = new System.Drawing.Point(172, 96);
            this.porcentajeDetalleTextView.Name = "porcentajeDetalleTextView";
            this.porcentajeDetalleTextView.ReadOnly = true;
            this.porcentajeDetalleTextView.Size = new System.Drawing.Size(100, 20);
            this.porcentajeDetalleTextView.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Descripción";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tipo ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(169, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Porcentaje";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(327, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Obligatorio";
            // 
            // descripcionNuevoTextView
            // 
            this.descripcionNuevoTextView.Location = new System.Drawing.Point(23, 46);
            this.descripcionNuevoTextView.Name = "descripcionNuevoTextView";
            this.descripcionNuevoTextView.Size = new System.Drawing.Size(258, 20);
            this.descripcionNuevoTextView.TabIndex = 2;
            // 
            // porcentajeNuevoTextView
            // 
            this.porcentajeNuevoTextView.Location = new System.Drawing.Point(172, 100);
            this.porcentajeNuevoTextView.Name = "porcentajeNuevoTextView";
            this.porcentajeNuevoTextView.Size = new System.Drawing.Size(100, 20);
            this.porcentajeNuevoTextView.TabIndex = 2;
            // 
            // agregarButton
            // 
            this.agregarButton.Location = new System.Drawing.Point(355, 140);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Size = new System.Drawing.Size(75, 23);
            this.agregarButton.TabIndex = 3;
            this.agregarButton.Text = "Agregar";
            this.agregarButton.UseVisualStyleBackColor = true;
            this.agregarButton.Click += new System.EventHandler(this.agregarButton_Click);
            // 
            // tipoNuevoComboBox
            // 
            this.tipoNuevoComboBox.FormattingEnabled = true;
            this.tipoNuevoComboBox.Location = new System.Drawing.Point(23, 100);
            this.tipoNuevoComboBox.Name = "tipoNuevoComboBox";
            this.tipoNuevoComboBox.Size = new System.Drawing.Size(100, 21);
            this.tipoNuevoComboBox.TabIndex = 4;
            // 
            // obligatorioNuevoComboBox
            // 
            this.obligatorioNuevoComboBox.Location = new System.Drawing.Point(330, 100);
            this.obligatorioNuevoComboBox.Name = "obligatorioNuevoComboBox";
            this.obligatorioNuevoComboBox.Size = new System.Drawing.Size(100, 21);
            this.obligatorioNuevoComboBox.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.eliminarConceptoButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.obligatorioDetalleTextView);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.porcentajeDetalleTextView);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.idConceptoDetalleTextView);
            this.groupBox1.Controls.Add(this.tipoDetalleTextView);
            this.groupBox1.Controls.Add(this.descripcionDetalleTextView);
            this.groupBox1.Location = new System.Drawing.Point(283, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 167);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle de concepto";
            // 
            // obligatorioDetalleTextView
            // 
            this.obligatorioDetalleTextView.Enabled = false;
            this.obligatorioDetalleTextView.FormattingEnabled = true;
            this.obligatorioDetalleTextView.Location = new System.Drawing.Point(330, 96);
            this.obligatorioDetalleTextView.Name = "obligatorioDetalleTextView";
            this.obligatorioDetalleTextView.Size = new System.Drawing.Size(100, 21);
            this.obligatorioDetalleTextView.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.agregarButton);
            this.groupBox2.Controls.Add(this.obligatorioNuevoComboBox);
            this.groupBox2.Controls.Add(this.descripcionNuevoTextView);
            this.groupBox2.Controls.Add(this.tipoNuevoComboBox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.porcentajeNuevoTextView);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(283, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 181);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nuevo concepto";
            // 
            // eliminarConceptoButton
            // 
            this.eliminarConceptoButton.Location = new System.Drawing.Point(355, 131);
            this.eliminarConceptoButton.Name = "eliminarConceptoButton";
            this.eliminarConceptoButton.Size = new System.Drawing.Size(75, 23);
            this.eliminarConceptoButton.TabIndex = 5;
            this.eliminarConceptoButton.Text = "Eliminar";
            this.eliminarConceptoButton.UseVisualStyleBackColor = true;
            this.eliminarConceptoButton.Click += new System.EventHandler(this.eliminarConceptoButton_Click);
            // 
            // ConceptosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 439);
            this.Controls.Add(this.conceptosDataGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "ConceptosView";
            this.Text = "ConceptosView";
            ((System.ComponentModel.ISupportInitialize)(this.conceptosDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView conceptosDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdConcepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcionConcepto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox idConceptoDetalleTextView;
        private System.Windows.Forms.TextBox descripcionDetalleTextView;
        private System.Windows.Forms.TextBox tipoDetalleTextView;
        private System.Windows.Forms.TextBox porcentajeDetalleTextView;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox descripcionNuevoTextView;
        private System.Windows.Forms.TextBox porcentajeNuevoTextView;
        private System.Windows.Forms.Button agregarButton;
        private System.Windows.Forms.ComboBox tipoNuevoComboBox;
        private System.Windows.Forms.ComboBox obligatorioNuevoComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox obligatorioDetalleTextView;
        private System.Windows.Forms.Button eliminarConceptoButton;
    }
}