using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaDeProductos
{
    public partial class Tarjetafomr : Form
    {
        double Monto;


        public Tarjetafomr(double Monto)
        {
            this.Monto = Monto;
            InitializeComponent();
            txtMonto.Text = Monto.ToString();
        }

        private void txtNumTarjeta_TextChanged(object sender, EventArgs e)
        {
            if(txtNumTarjeta.Text.Length!=16)
            {
                errorProvider1.SetError(txtNumTarjeta, "Número de tarjeta incorrecto");
                txtNumTarjeta.Focus();
                return;
            }
            errorProvider1.SetError(txtNumTarjeta, "");
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            Pagar pagotarjeta = new Pagar(Monto);
            pagotarjeta.Monto = Monto;
            pagotarjeta.Cv = txtCv.Text;
            pagotarjeta.Numero = txtNumTarjeta.Text;
            Random montoalearorio = new Random();
            pagotarjeta.Pago = montoalearorio.Next(1, 100);
            pagotarjeta.Titular = txtPropietarioTarj.Text;
            pagotarjeta.FechaVencimiento = txtFechaVencimiento.Text;
            MessageBox.Show(pagotarjeta.Validar());
          

        }
    }
}
