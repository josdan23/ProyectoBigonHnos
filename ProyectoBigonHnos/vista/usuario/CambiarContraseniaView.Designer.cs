namespace ProyectoBigonHnos.vista.usuario
{
    partial class CambiarContraseniaView
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
            this.nuevaTxb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.repetirTxb = new System.Windows.Forms.TextBox();
            this.aceptarBtn = new System.Windows.Forms.Button();
            this.salirBtn = new System.Windows.Forms.Button();
            this.msgLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nueva contraseña";
            // 
            // nuevaTxb
            // 
            this.nuevaTxb.Location = new System.Drawing.Point(122, 40);
            this.nuevaTxb.Name = "nuevaTxb";
            this.nuevaTxb.Size = new System.Drawing.Size(184, 20);
            this.nuevaTxb.TabIndex = 1;
            this.nuevaTxb.UseSystemPasswordChar = true;
            this.nuevaTxb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nuevaTxb_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Reptir contraseña";
            // 
            // repetirTxb
            // 
            this.repetirTxb.Location = new System.Drawing.Point(122, 83);
            this.repetirTxb.Name = "repetirTxb";
            this.repetirTxb.Size = new System.Drawing.Size(184, 20);
            this.repetirTxb.TabIndex = 2;
            this.repetirTxb.UseSystemPasswordChar = true;
            this.repetirTxb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.repetirTxb_KeyUp);
            // 
            // aceptarBtn
            // 
            this.aceptarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.aceptarBtn.Location = new System.Drawing.Point(231, 137);
            this.aceptarBtn.Name = "aceptarBtn";
            this.aceptarBtn.Size = new System.Drawing.Size(75, 23);
            this.aceptarBtn.TabIndex = 3;
            this.aceptarBtn.Text = "Aceptar";
            this.aceptarBtn.UseVisualStyleBackColor = true;
            this.aceptarBtn.Click += new System.EventHandler(this.aceptarBtn_Click);
            // 
            // salirBtn
            // 
            this.salirBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.salirBtn.Location = new System.Drawing.Point(147, 137);
            this.salirBtn.Name = "salirBtn";
            this.salirBtn.Size = new System.Drawing.Size(75, 23);
            this.salirBtn.TabIndex = 4;
            this.salirBtn.Text = "Salir";
            this.salirBtn.UseVisualStyleBackColor = true;
            // 
            // msgLbl
            // 
            this.msgLbl.AutoSize = true;
            this.msgLbl.ForeColor = System.Drawing.Color.Maroon;
            this.msgLbl.Location = new System.Drawing.Point(123, 110);
            this.msgLbl.Name = "msgLbl";
            this.msgLbl.Size = new System.Drawing.Size(91, 13);
            this.msgLbl.TabIndex = 0;
            this.msgLbl.Text = "Reptir contraseña";
            this.msgLbl.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoBigonHnos.Properties.Resources.ic_error_outline_48px;
            this.pictureBox1.Location = new System.Drawing.Point(22, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // CambiarContraseniaView
            // 
            this.AcceptButton = this.aceptarBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.salirBtn;
            this.ClientSize = new System.Drawing.Size(330, 173);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.salirBtn);
            this.Controls.Add(this.aceptarBtn);
            this.Controls.Add(this.repetirTxb);
            this.Controls.Add(this.msgLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nuevaTxb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CambiarContraseniaView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cambiar contraseña";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nuevaTxb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox repetirTxb;
        private System.Windows.Forms.Button aceptarBtn;
        private System.Windows.Forms.Button salirBtn;
        private System.Windows.Forms.Label msgLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}