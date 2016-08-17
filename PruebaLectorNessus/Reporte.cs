using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaLectorNessus
{
    /// <summary>
    /// Representa un reporte de Nessus. Tiene un nombre que se encuentra del 
    /// del campo correspondiente del archivo y tiene una lista de host asociada.
    /// </summary>
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
    }
}
