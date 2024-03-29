﻿namespace ProyectoBigonHnos.vista.pedidos
{
    partial class AgregarMaterialesNecesariosView
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
            this.materialesDisponiblesDGV = new System.Windows.Forms.DataGridView();
            this.IdMaterialCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cantidadTxBox = new System.Windows.Forms.TextBox();
            this.SubtotalTxbox = new System.Windows.Forms.TextBox();
            this.AgregarBtn = new System.Windows.Forms.Button();
            this.salirBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.materialesDisponiblesDGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialesDisponiblesDGV
            // 
            this.materialesDisponiblesDGV.AllowUserToAddRows = false;
            this.materialesDisponiblesDGV.AllowUserToDeleteRows = false;
            this.materialesDisponiblesDGV.AllowUserToResizeColumns = false;
            this.materialesDisponiblesDGV.AllowUserToResizeRows = false;
            this.materialesDisponiblesDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.materialesDisponiblesDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.materialesDisponiblesDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialesDisponiblesDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.materialesDisponiblesDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.materialesDisponiblesDGV.ColumnHeadersHeight = 40;
            this.materialesDisponiblesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.materialesDisponiblesDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMaterialCol,
            this.nombreCol,
            this.UnidadCol,
            this.PrecioCol});
            this.materialesDisponiblesDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.materialesDisponiblesDGV.Location = new System.Drawing.Point(24, 62);
            this.materialesDisponiblesDGV.MultiSelect = false;
            this.materialesDisponiblesDGV.Name = "materialesDisponiblesDGV";
            this.materialesDisponiblesDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.materialesDisponiblesDGV.RowHeadersVisible = false;
            this.materialesDisponiblesDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.materialesDisponiblesDGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.materialesDisponiblesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.materialesDisponiblesDGV.ShowCellErrors = false;
            this.materialesDisponiblesDGV.ShowCellToolTips = false;
            this.materialesDisponiblesDGV.ShowEditingIcon = false;
            this.materialesDisponiblesDGV.ShowRowErrors = false;
            this.materialesDisponiblesDGV.Size = new System.Drawing.Size(615, 182);
            this.materialesDisponiblesDGV.TabIndex = 0;
            // 
            // IdMaterialCol
            // 
            this.IdMaterialCol.HeaderText = "Id";
            this.IdMaterialCol.Name = "IdMaterialCol";
            // 
            // nombreCol
            // 
            this.nombreCol.HeaderText = "Nombre";
            this.nombreCol.Name = "nombreCol";
            // 
            // UnidadCol
            // 
            this.UnidadCol.HeaderText = "Unidad";
            this.UnidadCol.Name = "UnidadCol";
            // 
            // PrecioCol
            // 
            this.PrecioCol.HeaderText = "Precio por unidad";
            this.PrecioCol.Name = "PrecioCol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Materiales Disponibles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad";
            // 
            // cantidadTxBox
            // 
            this.cantidadTxBox.Location = new System.Drawing.Point(143, 277);
            this.cantidadTxBox.Name = "cantidadTxBox";
            this.cantidadTxBox.Size = new System.Drawing.Size(100, 20);
            this.cantidadTxBox.TabIndex = 3;
            this.cantidadTxBox.TextChanged += new System.EventHandler(this.ingresarTexto);
            // 
            // SubtotalTxbox
            // 
            this.SubtotalTxbox.Enabled = false;
            this.SubtotalTxbox.Location = new System.Drawing.Point(474, 277);
            this.SubtotalTxbox.Name = "SubtotalTxbox";
            this.SubtotalTxbox.Size = new System.Drawing.Size(100, 20);
            this.SubtotalTxbox.TabIndex = 3;
            this.SubtotalTxbox.Text = " ";
            // 
            // AgregarBtn
            // 
            this.AgregarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AgregarBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.AgregarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarBtn.Location = new System.Drawing.Point(579, 329);
            this.AgregarBtn.Name = "AgregarBtn";
            this.AgregarBtn.Size = new System.Drawing.Size(75, 32);
            this.AgregarBtn.TabIndex = 4;
            this.AgregarBtn.Text = "Agregar";
            this.AgregarBtn.UseVisualStyleBackColor = false;
            this.AgregarBtn.Click += new System.EventHandler(this.AgregarBtn_Click);
            // 
            // salirBtn
            // 
            this.salirBtn.BackColor = System.Drawing.Color.White;
            this.salirBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.salirBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salirBtn.Location = new System.Drawing.Point(487, 329);
            this.salirBtn.Name = "salirBtn";
            this.salirBtn.Size = new System.Drawing.Size(75, 32);
            this.salirBtn.TabIndex = 5;
            this.salirBtn.Text = "Salir";
            this.salirBtn.UseVisualStyleBackColor = false;
            this.salirBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Subtotal";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 302);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // AgregarMaterialesNecesariosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(666, 373);
            this.Controls.Add(this.salirBtn);
            this.Controls.Add(this.AgregarBtn);
            this.Controls.Add(this.SubtotalTxbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cantidadTxBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.materialesDisponiblesDGV);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarMaterialesNecesariosView";
            this.Text = "Agregar materiales";
            ((System.ComponentModel.ISupportInitialize)(this.materialesDisponiblesDGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView materialesDisponiblesDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cantidadTxBox;
        private System.Windows.Forms.TextBox SubtotalTxbox;
        private System.Windows.Forms.Button AgregarBtn;
        private System.Windows.Forms.Button salirBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMaterialCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCol;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}