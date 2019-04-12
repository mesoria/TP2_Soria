using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Soria
{
    public class Producto
    {
        int id;
        string nombre;
        int precioVenta;
        int pricioCompra;
        Marca marca;
        DateTime vencimiento;
        SubProducto productito;
    }
}
