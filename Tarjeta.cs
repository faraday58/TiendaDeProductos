
namespace TiendaDeProductos
{
    public interface Tarjeta
    {
        string Numero
        {
            get;
            set;
        }
        
        string Cv { get; set; }
        string Titular { get; set; }
        string FechaVencimiento { get; set; }
        
        double Monto { get; set; }
        void Validar();
    }
}
