using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Soria
{
    public class Deposito
    {
        string nombre;
        string telefono;
        string direccion;
        CodigoPostal  cp;
        List<Empleado> listaDeEmpleados = new List<Empleado>();
        List<Cliente>  listaDeClientes  = new List<Cliente>();
        List<Sector>   listaDeSectores = new List<Sector>();
        List<Pasillo>  listaDePasillos  = new List<Pasillo>();
        List<Compartimiento> listaDeCompartimientos = new List<Compartimiento>();
    }
}
