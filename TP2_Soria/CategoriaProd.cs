using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Soria
{
    public class SubProducto : Producto
    {
        string categoria;
        string descripcion;
        bool perecedero;
        DateTime dueDate;
        int temperaturaDeConcervación;
    }
}
