using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TiendaDeProductos
{
    public partial class PagoEfectivo : Form
    {
        private double costo;

        public PagoEfectivo(double costo)
        {
            this.costo = costo;
            InitializeComponent();
            lbCosto.Text = costo.ToString();
        }
        
        //Todo Evento o método que maneja o dispara la acción
        //tiene una firma:  La firma es los argumentos que contiene
        //Los argumentos nunca pueden cambiar de tipo
        private void txtbPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == 13)
            {
                try
                {
                    Pagar pagar = new Pagar(double.Parse(txtbPago.Text), costo);



                    lbCambio.Text = pagar.Cambio().ToString();
                }
                catch
                {

                }
                
            }
        }
    }
}
