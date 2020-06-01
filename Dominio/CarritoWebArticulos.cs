using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class CarritoWebArticulos
    {
            public List<Articulo> listadoCarritoWeb { get; set; }

            public CarritoWebArticulos()
            {
                listadoCarritoWeb = new List<Articulo>();
            }
        
    }
}
