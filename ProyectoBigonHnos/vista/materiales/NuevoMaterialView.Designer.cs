namespace ProyectoBigonHnos.vista.materiales
{
    partial class NuevoMaterialView
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxStockDisponible = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tboxMinimo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(656, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(563, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descripcion";
            // 
            // tboxDescripcion
            // 
            this.tboxDescripcion.Location = new System.Drawing.Point(87, 84);
            this.tboxDescripcion.Name = "tboxDescripcion";
            this.tboxDescripcion.Size = new System.Drawing.Size(100, 20);
            this.tboxDescripcion.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio";
            // 
            // tboxPrecio
            // 
            this.tboxPrecio.Location = new System.Drawing.Point(87, 128);
            this.tboxPrecio.Name = "tboxPrecio";
            this.tboxPrecio.Size = new System.Drawing.Size(100, 20);
            this.tboxPrecio.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad";
            // 
            // tboxCantidad
            // 
            this.tboxCantidad.Location = new System.Drawing.Point(87, 185);
            this.tboxCantidad.Name = "tboxCantidad";
            this.tboxCantidad.Size = new System.Drawing.Size(100, 20);
            this.tboxCantidad.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Stock disponible";
            // 
            // tboxStockDisponible
            // 
            this.tboxStockDisponible.Location = new System.Drawing.Point(87, 236);
            this.tboxStockDisponible.Name = "tboxStockDisponible";
            this.tboxStockDisponible.Size = new System.Drawing.Size(100, 20);
            this.tboxStockDisponible.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Stock Minimo";
            // 
            // tboxMinimo
            // 
            this.tboxMinimo.Location = new System.Drawing.Point(87, 282);
            this.tboxMinimo.Name = "tboxMinimo";
            this.tboxMinimo.Size = new System.Drawing.Size(100, 20);
            this.tboxMinimo.TabIndex = 5;
            // 
            // NuevoMaterialView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tboxMinimo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tboxStockDisponible);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tboxCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tboxPrecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "NuevoMaterialView";
            this.Text = "NuevoMaterialView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboxStockDisponible;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tboxMinimo;
    }
}