using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Soria
{
    public class Compartimiento
    {
        //int id;
        Cliente cliente;
        List<Producto> listaDeProducto = new List<Producto>();
        int capacidad;
        bool full;
    }
}
