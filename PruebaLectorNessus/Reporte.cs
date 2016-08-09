using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaLectorNessus
{
    class Reporte
    {
        // ----------------------------------------------------
        // Atributos
        // ----------------------------------------------------
        public string nombre;
        public List<Host> hosts;
        // ----------------------------------------------------
        // Constructor
        // ----------------------------------------------------
        public Reporte()
        {
            hosts = new List<Host>();
        }

        // ----------------------------------------------------
        // Métodos
        // ----------------------------------------------------
    }
}
