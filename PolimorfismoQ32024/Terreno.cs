

namespace PolimorfismoQ32024
{
    public class Terreno : Inmueble
    {
        public Terreno() { }

        public Terreno(string TipoInmueble)
        { 
            this.TipoInmueble = TipoInmueble;
        
        }

        public Terreno(string TipoInmueble, double Precio)
        { 
            this.TipoInmueble = TipoInmueble;
            this.Precio = Precio;
        }
    }
    }
}
