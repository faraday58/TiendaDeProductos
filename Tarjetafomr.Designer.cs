namespace TiendaDeProductos
{
    partial class Tarjetafomr
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumTarjeta = new System.Windows.Forms.TextBox();
            this.txtCv = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtPropietarioTarj = new System.Windows.Forms.TextBox();
            this.txtFechaVencimiento = new System.Windows.Forms.TextBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de tarjeta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de vencimeinto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Monto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cv";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Propietario de la tarjeta";
            // 
            // txtNumTarjeta
            // 
            this.txtNumTarjeta.Location = new System.Drawing.Point(175, 41);
            this.txtNumTarjeta.Name = "txtNumTarjeta";
            this.txtNumTarjeta.Size = new System.Drawing.Size(100, 20);
            this.txtNumTarjeta.TabIndex = 5;
            this.txtNumTarjeta.TextChanged += new System.EventHandler(this.txtNumTarjeta_TextChanged);
            // 
            // txtCv
            // 
            this.txtCv.Location = new System.Drawing.Point(175, 132);
            this.txtCv.Name = "txtCv";
            this.txtCv.Size = new System.Drawing.Size(100, 20);
            this.txtCv.TabIndex = 6;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(157, 219);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 20);
            this.txtMonto.TabIndex = 7;
            // 
            // txtPropietarioTarj
            // 
            this.txtPropietarioTarj.Location = new System.Drawing.Point(175, 85);
            this.txtPropietarioTarj.Name = "txtPropietarioTarj";
            this.txtPropietarioTarj.Size = new System.Drawing.Size(100, 20);
            this.txtPropietarioTarj.TabIndex = 8;
            // 
            // txtFechaVencimiento
            // 
            this.txtFechaVencimiento.Location = new System.Drawing.Point(175, 173);
            this.txtFechaVencimiento.Name = "txtFechaVencimiento";
            this.txtFechaVencimiento.Size = new System.Drawing.Size(100, 20);
            this.txtFechaVencimiento.TabIndex = 9;
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(30, 272);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(75, 23);
            this.btnValidar.TabIndex = 10;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Tarjetafomr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 342);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.txtFechaVencimiento);
            this.Controls.Add(this.txtPropietarioTarj);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtCv);
            this.Controls.Add(this.txtNumTarjeta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Tarjetafomr";
            this.Text = "Tarjetafomr";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumTarjeta;
        private System.Windows.Forms.TextBox txtCv;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtPropietarioTarj;
        private System.Windows.Forms.TextBox txtFechaVencimiento;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}