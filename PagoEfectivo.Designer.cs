namespace TiendaDeProductos
{
    partial class PagoEfectivo
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
            this.txtbPago = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCambio = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCosto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbPago
            // 
            this.txtbPago.Location = new System.Drawing.Point(106, 58);
            this.txtbPago.Name = "txtbPago";
            this.txtbPago.Size = new System.Drawing.Size(161, 20);
            this.txtbPago.TabIndex = 0;
            this.txtbPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbPago_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pago";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cambio";
            // 
            // lbCambio
            // 
            this.lbCambio.AutoSize = true;
            this.lbCambio.Location = new System.Drawing.Point(103, 126);
            this.lbCambio.Name = "lbCambio";
            this.lbCambio.Size = new System.Drawing.Size(0, 13);
            this.lbCambio.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Costo";
            // 
            // lbCosto
            // 
            this.lbCosto.AutoSize = true;
            this.lbCosto.Location = new System.Drawing.Point(103, 25);
            this.lbCosto.Name = "lbCosto";
            this.lbCosto.Size = new System.Drawing.Size(0, 13);
            this.lbCosto.TabIndex = 2;
            // 
            // PagoEfectivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 176);
            this.Controls.Add(this.lbCosto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbCambio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbPago);
            this.Name = "PagoEfectivo";
            this.Text = "PagoEfectivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCambio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCosto;
    }
}