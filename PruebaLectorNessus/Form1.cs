﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaLectorNessus
{
    public partial class Form1 : Form
    {

        // ----------------------------------------------------
        // Constantes
        // ----------------------------------------------------

        const string REPORT_NAME_TAG = "<Report name=\"";

        const string REPORT_END_TAG = "</Report>";

        const string REPORT_HOST_TAG = "<ReportHost";

        const string HOST_PROPERTIES_END_TAG = "</HostProperties>";

        const string HOST_END_TAG = "<tag name=\"HOST_END\">";

        const string HOST_START_TAG = "<tag name=\"HOST_START\">";

        const string HOST_OS_TAG = "<tag name=\"operating-system\">";

        const string HOST_MAC_TAG = "<tag name=\"mac-address\">";

        const string HOST_IP_TAG = "<tag name=\"host-ip\">";

        const string HOST_NETBIOS_TAG = "<tag name=\"netbios-name\">";

        const string END_TAG = "</";

        // ----------------------------------------------------
        // Atributos
        // ----------------------------------------------------

        private Reporte reporte;
        
        // ----------------------------------------------------
        // Constructor
        // ----------------------------------------------------

        /// <summary>
        /// Método constructor.
        /// Inicializa el formulario y la lista de hosts;
        /// </summary>
        public Form1()
        {
            InitializeComponent();           
        }

        // ----------------------------------------------------
        // Métodos
        // ----------------------------------------------------

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            // Show the open File dialog. If the user clicks OK, load the
            // picture that the user chose.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                reporte = new Reporte();
                LeerArchivo(openFileDialog1.FileName);
                imprimirReporte();            
            }
        }

        /// <summary>
        /// Lee el archivo línea por línea y extrae la información correspondiente.
        /// Crea un objeto de tipo reporte, un objeto de tipo Host por cada host del 
        /// reporte, y un objeto de tipo vulnerabilidad por cada report item del host.
        /// </summary>
        /// <param name="fileName"></param>
        private void LeerArchivo(string fileName)
        {
            Console.WriteLine("Leyendo archivo...");

            String[] lineas = File.ReadAllLines(fileName);          
            int numLinea = 0;
            string reportName = "";

            // Iterar hasta que aparezca el tag "<Report name"
            while (!lineas[numLinea].Contains(REPORT_NAME_TAG))
                numLinea++;

            // Leer el nombre del reporte.
            // <Report name="TG" xmlns:cm="http://www.nessus.org/cm">
            reportName = Regex.Split(lineas[numLinea], REPORT_NAME_TAG)[1].Split('"')[0];
            reporte.nombre = reportName;                    

            // Iterar hasta el final del reporte: mientras la línea no contenga "</Report>":
            while (!lineas[numLinea].Contains(REPORT_END_TAG))
            {
                // Cuando encuentra un ReportHost, lee su información.
                if (lineas[numLinea].Contains(REPORT_HOST_TAG))
                {
                    Host host = new Host();
                    string hostname = "";
                    string hostEnd = "";
                    string hostStart = "";
                    string hostIp = "";
                    string operativeSystem = "";
                    string mac = "";
                    string netbiosName = "";


                    // Obtiene el nombre del host.
                    hostname = Regex.Split(lineas[numLinea], "name=\"")[1].Split('"')[0];  //<ReportHost name="10.1.4.180"><HostProperties>                    
                    numLinea ++;

                    // Leer las propiedades del host
                    while (!lineas[numLinea].Contains(HOST_PROPERTIES_END_TAG))
                    {
                        // Obtener el HOST_END
                        if (lineas[numLinea].Contains(HOST_END_TAG)) 
                        {
                            // <tag name="HOST_END">Thu Jul 28 14:46:10 2016</tag>
                            hostEnd = Regex.Split(lineas[numLinea], HOST_END_TAG)[1];
                            hostEnd = Regex.Split(hostEnd , END_TAG)[0];                           
                        }

                        // Obtener el HOST_START
                        if (lineas[numLinea].Contains(HOST_START_TAG))
                        {
                            // <tag name="HOST_START">Thu Jul 28 14:46:10 2016</tag>
                            hostStart = Regex.Split(lineas[numLinea], HOST_START_TAG)[1];
                            hostStart = Regex.Split(hostStart, END_TAG)[0];
                        }

                        // Obtener el host-ip
                        if (lineas[numLinea].Contains(HOST_IP_TAG))
                        {
                            // <tag name="host-ip">10.1.4.203</tag>
                            hostIp = Regex.Split(lineas[numLinea], HOST_IP_TAG)[1];
                            hostIp = Regex.Split(hostIp, END_TAG)[0];
                        }

                        // Obtener el netbios_name
                        if (lineas[numLinea].Contains(HOST_NETBIOS_TAG))
                        {
                            // <tag name = "netbios-name">HMERCADO</tag>
                            netbiosName = Regex.Split(lineas[numLinea], HOST_NETBIOS_TAG)[1];
                            netbiosName = Regex.Split(netbiosName, END_TAG)[0];
                        }
                        /** Obtiene el sistema operativo.
                         *
                         *   Eje 1:
                         *   <tag name="operating-system">AIX 4.3.2
                         *   AIX 5.2
                         *   CatalystOS 6.3
                         *   VAX / VMS 7.1 </tag > 
                         *
                         *   Eje 2:
                         *   <tag name="operating-system">RICOH Printer</tag> 
                         */
                        if (lineas[numLinea].Contains(HOST_OS_TAG))
                        {
                            while(true)  // Recorre todas las líneas del campo
                            {
                                string os = "";
                                // Existen diferentes casos. 
                                // 1. El tag de inicio y el tag de final están en la misma línea
                                // 2. Únicamente el tag de inicio está en la línea.
                                // 3. Únicamente el tag de final está en la línea.
                                // 4. La línea no tiene tags.

                                // 1. Eje: <tag name="operating-system">RICOH Printer</tag>
                                if (lineas[numLinea].Contains(HOST_OS_TAG) && lineas[numLinea].Contains(END_TAG))
                                {
                                    os = Regex.Split(lineas[numLinea], HOST_OS_TAG)[1];
                                    os = Regex.Split(os, END_TAG)[0];
                                    operativeSystem = operativeSystem + os;
                                    break; // Termina el ciclo cuando encuentra el tag de cierre: "</"
                                }

                                // 3. Eje: VAX / VMS 7.1 </tag>
                                else if (lineas[numLinea].Contains(END_TAG)) 
                                {
                                    os = Regex.Split(lineas[numLinea], END_TAG)[0];
                                    operativeSystem = operativeSystem + " " + os;
                                    break; // Termina el ciclo cuando encuentra el tag de cierre: "</"
                                }

                                // 2. Eje: <tag name="operating-system">AIX 4.3.2
                                else if (lineas[numLinea].Contains(HOST_OS_TAG))
                                {
                                    os = Regex.Split(lineas[numLinea], HOST_OS_TAG)[1];
                                    operativeSystem = operativeSystem +  os;
                                }

                                // 4. Eje: AIX 5.2
                                else
                                    operativeSystem = operativeSystem + " " + lineas[numLinea];                                

                                numLinea++;
                            }
                        }

                        /** Obtiene la dirección mac.
                         *
                         *   Eje 1:
                         *   <tag name="mac-address">00:0c:29:71:87:10</tag>
                         *
                         *   Eje 2:
                         *   <tag name="mac-address">00:00:00:00:00:00
                         *   00:22:57:b4:91:75
                         *   74820 00:0e:11:14:e9:2e</tag> 
                         */
                        if (lineas[numLinea].Contains(HOST_MAC_TAG))
                        {

                            while (true) // Recorre todas las líneas del campo
                            {
                                // Existen diferentes casos. 
                                // 1. El tag de inicio y el tag de final están en la misma línea
                                // 2. Únicamente el tag de final está en la línea.
                                // 3. Únicamente el tag de inicio está en la línea.
                                // 4. La línea no tiene tags.
                                string temp = "";

                                // 1. Eje: <tag name="mac-address">00:0c:29:71:87:10</tag>
                                if (lineas[numLinea].Contains(HOST_MAC_TAG) && lineas[numLinea].Contains(END_TAG))
                                {
                                    temp = Regex.Split(lineas[numLinea], HOST_MAC_TAG)[1];
                                    temp = Regex.Split(temp, END_TAG)[0];
                                    mac = mac + temp;
                                    break; // Termina el ciclo cuando encuentra el tag de cierre: "</"
                                }

                                // 2. Eje: 74820 00:0e:11:14:e9:2e</tag>
                                else if(lineas[numLinea].Contains(END_TAG))
                                {
                                    temp = Regex.Split(lineas[numLinea], END_TAG)[0];
                                    mac = mac + " " + temp;
                                    break; // Termina el ciclo cuando encuentra el tag de cierre: "</"
                                }

                                // 3. Eje: <tag name="mac-address">00:00:00:00:00:00
                                else if(lineas[numLinea].Contains(HOST_MAC_TAG))
                                {
                                    temp = Regex.Split(lineas[numLinea], HOST_MAC_TAG)[1];
                                    mac = mac + temp;
                                }

                                // 4. Eje: 00:22:57:b4:91:75
                                else
                                    mac = mac + " " + lineas[numLinea];

                                numLinea++;
                            }

                        }
                       
                        numLinea++;
                    }

                    // Agregar la información al objeto host y lo agrega a la lista de hosts
                    host.hostname = hostname;
                    host.hostEnd = hostEnd;
                    host.hostStart = hostStart;
                    host.operativeSystem = operativeSystem;
                    host.hostIp = hostIp;
                    host.mac = mac;
                    host.netbiosName = netbiosName;
                    reporte.hosts.Add(host);

                    /* Imprimir la información en la consola. 
                    Console.WriteLine("Línea: " + numLinea + " --- hostname:" + hostname + " ---");
                    Console.WriteLine("Línea: " + numLinea + " HOST_END: " + hostEnd);
                    Console.WriteLine("Línea: " + numLinea + " HOST_START: " + hostStart);
                    Console.WriteLine("Línea: " + numLinea + " OS: " + operativeSystem);
                    Console.WriteLine("Línea: " + numLinea + " HOST_IP: " + hostIp);
                    Console.WriteLine("Línea: " + numLinea + " MAC: " + mac);
                    Console.WriteLine("Línea: " + numLinea + " NETBIOS_NAME: " + netbiosName);
                    // Console.WriteLine("Linea: " + numLinea + " "+ lineas[numLinea]); */
                }
                numLinea++;
            }
            //Console.WriteLine("Línea: " + numLinea + " " + lineas[numLinea]);
            Console.WriteLine("Fin Lectura.");
            
        }

        private void imprimirReporte()
        {
            Console.WriteLine("Reporte: " + reporte.nombre); 
                
            foreach(Host host in reporte.hosts)
            {
                Console.WriteLine("--- hostname:" + host.hostname + " ---");
                Console.WriteLine("HOST_START: " + host.hostStart);
                Console.WriteLine("HOST_END: " + host.hostEnd);               
                Console.WriteLine("OS: " + host.operativeSystem);
                Console.WriteLine("HOST_IP: " + host.hostIp);
                Console.WriteLine("MAC: " + host.mac);
                Console.WriteLine("NETBIOS_NAME: " + host.netbiosName);
            }

            Console.WriteLine("*** Fin Reporte ***");
        }
            
    }
}
