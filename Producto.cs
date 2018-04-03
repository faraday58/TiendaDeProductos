using System;
namespace TiendaDeProductos
{
    class Producto
    {
        private string nombre;
        private string clave;
        private byte cantidad;
        private byte cantidadExistencia;
        private float precio;


        public  string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                if( value == "")
                {
                    nombre = "producto sin nombre";
                }
                else
                {
                    nombre = value;
                }
            }
        }

        public string Clave
        {
            get
            {
                return clave;
            }            
        }
        
        public byte Cantidad
        {
            get
            {
                return cantidad;
            }
            set
            {
                if( value  != 0  )
                {
                    cantidad = value;
                }
                else
                {
                    cantidad = 1;
                }
            }
        }

        public byte CantidadExistencia
        {
            get
            {
                return cantidadExistencia;
            }
        }

        public float Precio
        {
            get
            {
                return precio;
            }
            set
            {
                if( value > 0 )
                {
                    precio = value;
                }
                else
                {
                    precio = 10;
                }
            }
        }


        public Producto(string Nombre, byte Cantidad  )
        {
            this.Nombre = Nombre;
            this.Cantidad = Cantidad;

            Random aleatorio = new Random();
            clave = "";
            for(int i=0; i < 10; i++)
            {
                clave = clave + aleatorio.Next(9).ToString();
            }
            cantidadExistencia = (byte)aleatorio.Next(30);
            Precio = (float)Math.Round(aleatorio.NextDouble(),2)*10;

        }

    }
}
