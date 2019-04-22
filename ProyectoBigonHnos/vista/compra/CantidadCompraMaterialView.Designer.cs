namespace ProyectoBigonHnos.vista.compra
{
    partial class CantidadCompraMaterialView
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
            this.ConfirmarBtn = new System.Windows.Forms.Button();
            this.cantidadTxtBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConfirmarBtn
            // 
            this.ConfirmarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ConfirmarBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ConfirmarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmarBtn.Location = new System.Drawing.Point(137, 92);
            this.ConfirmarBtn.Name = "ConfirmarBtn";
            this.ConfirmarBtn.Size = new System.Drawing.Size(75, 32);
            this.ConfirmarBtn.TabIndex = 2;
            this.ConfirmarBtn.Text = "Confirmar";
            this.ConfirmarBtn.UseVisualStyleBackColor = false;
            this.ConfirmarBtn.Click += new System.EventHandler(this.ConfirmarBtn_Click);
            // 
            // cantidadTxtBx
            // 
            this.cantidadTxtBx.Location = new System.Drawing.Point(25, 52);
            this.cantidadTxtBx.Name = "cantidadTxtBx";
            this.cantidadTxtBx.Size = new System.Drawing.Size(187, 20);
            this.cantidadTxtBx.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese la cantidad a comprar";
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.BackColor = System.Drawing.SystemColors.Control;
            this.CancelarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CancelarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelarBtn.Location = new System.Drawing.Point(25, 92);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(75, 32);
            this.CancelarBtn.TabIndex = 1;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = false;
            // 
            // CantidadCompraMaterialView
            // 
            this.AcceptButton = this.ConfirmarBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelarBtn;
            this.ClientSize = new System.Drawing.Size(236, 142);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cantidadTxtBx);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.ConfirmarBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CantidadCompraMaterialView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cantidad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConfirmarBtn;
        private System.Windows.Forms.TextBox cantidadTxtBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelarBtn;
    }
}