using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaLectorNessus
{
    /// <summary>
    /// Representa un host escaneado por nessus. Contiene un hostname, una dirección ip,
    /// el o los sistemas operativos, la o las direcciones mac, el netbios name,  la fecha de inicio 
    /// del escaneo y la fecha de final. Tiene asociada una lista de vulnerabilidades.
    /// </summary>
    class Host
    {
        // ----------------------------------------------------
        // Atributos
        // ----------------------------------------------------

        public string hostname;
        public string hostEnd;
        public string hostStart;
        public string hostIp;
        public string operativeSystem;
        public string mac;
        public string netbiosName;

        public List<Vulnerabilidad> vulnerabilidades;

        // ----------------------------------------------------
        // Constructor
        // ----------------------------------------------------

        public Host()
        {
            vulnerabilidades = new List<Vulnerabilidad>();
        }
    }
}

