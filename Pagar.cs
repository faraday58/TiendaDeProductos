using System;

namespace TiendaDeProductos
{
    class Pagar : Efectivo
    {
        private double costo;
        private double pago;

        public double Pago
        {
            get
            {
                return pago;
            }
            set
            {
                if(value > 0)
                {
                    pago = value;
                }
                else
                {
                    pago = 10;
                }
            }
        }


        public double Costo {
            get
            {
                return costo;
            }
            set {
                if( value > 0)
                {
                    costo = value;
                }
                else
                {
                    costo = 10;
                }
            }
        }

        public double Cambio()
        {
            if (Pago >= Costo)
            {
                return Pago - Costo;
            }                
            else
            {
                return -1;
            }              
            
        }

        public Pagar(double Pago, double Costo)
        {
            this.Pago = Pago;
            this.Costo = Costo;

        }

    }
}
