using System;

namespace TiendaDeProductos
{
    class Pagar : Efectivo, Tarjeta
    {
        private double costo;
        private double pago;
        private string numero;
        private string titular;
        private string fechadevencimiento;
        private double monto;
        private string cv;
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

        public string Numero
        {
            get
            {
                return numero;
            }
            set
            {


                if (value == "")
                {
                    numero = "2452124";
                }
                else
                {
                    numero = value;
                }

            }
        }


        public string Cv
        {
            get
            {
                return cv;
            }
            set
            {
                if (value== "")
                {
                    cv = "001";
                }
                else
                {
                    cv = value;
                }
            }
          }
        public string Titular
        {
            get
            {
                return titular;
            }
                set
            {
                if(value=="")
                {
                    titular="Mario Hugo";
                }
                else
                {
                    titular = value;
                }
            }
        }
        public string FechaVencimiento
        {
            get
            {
                return fechadevencimiento;
            }
            set
            {
                if(value=="")
                {
                    fechadevencimiento = "16/07/2018";
                }
                else
                {
                    fechadevencimiento = value;
                }
            }
         }
        public double Monto
        {
            get
            {
                return monto;
            }
            set
            {
                if(value<=0)
                {
                    monto = 1000;

                }
                else
                {
                    monto = value;
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

        public string Validar()
        {
            string [] fecha = FechaVencimiento.Split('/'); 
            if(int.Parse(fecha[2])<2018 )
            {
                string erroneo = ("La tarjeta está vencida");
                return erroneo;
            }
            if (Numero.Length<16)
            {
                string tarjetaerror = ("El número de tu tarjeta está incompleto");
                return tarjetaerror;
            }
            if (Cv.Length!=3)
            {
                string cverror = ("Cv incorrecto");
                return cverror;
            }
            if(Pago<Monto)
            {
                string errormonto = ("Fondos insuficientes");
                return errormonto;
            }
            return "Pago validado";
 
        }

        public Pagar(double Pago, double Costo)
        {
            this.Pago = Pago;
            this.Costo = Costo;

        }
        public Pagar(double Monto)
        {
            this.Monto = Monto;
        }

    }
}
