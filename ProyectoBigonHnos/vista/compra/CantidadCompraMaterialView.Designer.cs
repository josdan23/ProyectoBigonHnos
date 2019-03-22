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
            this.ConfirmarBtn.Location = new System.Drawing.Point(167, 110);
            this.ConfirmarBtn.Name = "ConfirmarBtn";
            this.ConfirmarBtn.Size = new System.Drawing.Size(75, 23);
            this.ConfirmarBtn.TabIndex = 2;
            this.ConfirmarBtn.Text = "Confirmar";
            this.ConfirmarBtn.UseVisualStyleBackColor = true;
            this.ConfirmarBtn.Click += new System.EventHandler(this.ConfirmarBtn_Click);
            // 
            // cantidadTxtBx
            // 
            this.cantidadTxtBx.Location = new System.Drawing.Point(55, 64);
            this.cantidadTxtBx.Name = "cantidadTxtBx";
            this.cantidadTxtBx.Size = new System.Drawing.Size(187, 20);
            this.cantidadTxtBx.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese la cantidad a comprar";
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarBtn.Location = new System.Drawing.Point(55, 110);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelarBtn.TabIndex = 1;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            // 
            // CantidadCompraMaterialView
            // 
            this.AcceptButton = this.ConfirmarBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelarBtn;
            this.ClientSize = new System.Drawing.Size(292, 163);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cantidadTxtBx);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.ConfirmarBtn);
            this.Name = "CantidadCompraMaterialView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CantidadCompraMaterialView";
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