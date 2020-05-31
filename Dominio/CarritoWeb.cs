using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class CarritoWeb
    {
        public List<Articulo> listadoCarritoWeb { get; set; }

        public CarritoWeb()
        {
            listadoCarritoWeb = new List<Articulo>();
        }
    }
}
