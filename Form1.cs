﻿using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace TiendaDeProductos
{
    public partial class Form1 : Form
    {
        ArrayList produtos;
        private int indice;


        public Form1()
        {
            produtos = new ArrayList();
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            produtos.Add( new Producto(txtbNombre.Text, byte.Parse( txtbCantidad.Text) ) );
            Producto miProducto = (Producto)produtos[indice++];
            txtbNombre.Text = miProducto.Nombre;
            txtbCantidad.Text = miProducto.Cantidad.ToString();
            txtbClave.Text = miProducto.Clave;
            txtbPrecio.Text =  String.Format("{0:0.00}"  , miProducto.Precio);
            txtbExistencia.Text = miProducto.CantidadExistencia.ToString();
        }

        
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if ( indice  < produtos.Count)
            {
                Producto miProducto = (Producto)produtos[indice++];
                txtbNombre.Text = miProducto.Nombre;
                txtbCantidad.Text = miProducto.Cantidad.ToString();
                txtbClave.Text = miProducto.Clave;
                txtbPrecio.Text = String.Format("{0:0.00}", miProducto.Precio);
                txtbExistencia.Text = miProducto.CantidadExistencia.ToString();
            }
            else
            {
                indice = 0;
            }


        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if( rdbEfectivo.Checked)
            {
                double costo = double.Parse(txtbPrecio.Text )* byte.Parse(txtbCantidad.Text);
                PagoEfectivo pagoEfectivo = new PagoEfectivo(costo);
                pagoEfectivo.Show();
               

            }
            else if( rdbTarjeta.Checked)
            {

            }else
            {
                MessageBox.Show("Debe de seleccionar una forma de pago");
            }
        }
    }
}
