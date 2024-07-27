

namespace PolimorfismoQ32024
{
    public class Inmueble
    {

        public string TipoInmueble { get; set; }   
        public string Ubicacion {  get; set; }
        public double AreaTerreno { get; set; }
        public double Precio { get; set; }

        public void Vender()
        {
            Console.WriteLine($"{TipoInmueble} con un área {AreaTerreno} con ubicación en {Ubicacion} ha sido vendida por el precio de L{Precio}");
        }
        public void Vender(string Cliente)
        {
            Console.WriteLine($"{TipoInmueble} con un área {AreaTerreno} con ubicación en {Ubicacion} ha sido vendida por el precio de L{Precio} al cliente {Cliente}");
        }

        public void Vender(double Descuento)
        {
            Console.WriteLine($"{TipoInmueble} con un área {AreaTerreno} con ubicación en {Ubicacion} ha sido vendida por el precio de L{Precio} con un descuento de L{Descuento}");
        }

        public void Vender(String Cliente, double Descuento) 
        {
            Console.WriteLine($"{TipoInmueble} con un área {AreaTerreno} con ubicación en {Ubicacion} ha sido vendida por el precio de L{Precio} al cliente {Cliente} con un descuento de L{Descuento}");
        }


    }
}
