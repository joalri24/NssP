using System;
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

        const string REPORT_NAME_TAG = "<Report name";

        const string REPORT_END_TAG = "</Report>";

        const string REPORT_HOST_TAG = "<ReportHost";

        const string HOST_PROPERTIES_END_TAG = "</HostProperties>";

        const string HOST_END_TAG = "<tag name=\"HOST_END\">";

        const string END_TAG = "</";

        // ----------------------------------------------------
        // Atributos
        // ----------------------------------------------------

        // ----------------------------------------------------
        // Constructor
        // ----------------------------------------------------

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
                LeerArchivo(openFileDialog1.FileName);
                
            }
        }

        /// <summary>
        /// Lee el archivo. Cada línea es un campo 
        /// </summary>
        /// <param name="fileName"></param>
        private void LeerArchivo(string fileName)
        {
            String[] lineas = File.ReadAllLines(fileName);
            /**foreach (string linea in lineas)
            {

                string[] datos = linea.Split('>');
                string campo = datos[0];
                string contenido = datos[1];
                contenido = Regex.Split(contenido, "</")[0];
                //Console.WriteLine(campo);
                //Console.WriteLine(contenido);
            }*/

            // Iterar hasta que aparezca el tag "<Report name"
            int numLinea = 0;
            while (!lineas[numLinea].Contains(REPORT_NAME_TAG))
                numLinea++;

            Console.WriteLine("Linea: " + numLinea + " " + lineas[numLinea]);


            // Iterar hasta el final del reporte. Mientrás la línea no contenga "</Report":
            while (!lineas[numLinea].Contains(REPORT_END_TAG))
            {
                // Cuando encuentra un ReportHost, lee su información.
                if (lineas[numLinea].Contains(REPORT_HOST_TAG))
                {
                    string hostname = "";
                    string hostEnd = "";


                    // Obtiene el nombre del host.
                    hostname = Regex.Split(lineas[numLinea], "name=\"")[1].Split('"')[0];  //<ReportHost name="10.1.4.180"><HostProperties>
                    Console.WriteLine("Linea: " + numLinea + " --- hostname:" + hostname + " ---");
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
                            Console.WriteLine("Linea: " + numLinea + " HOST_END: " + hostEnd);
                        }
                        numLinea ++;
                    }
                    Console.WriteLine("Linea: " + numLinea + " " + lineas[numLinea]);
                    // if tag name leer la linea.
                    // Leer las siguientes lineas con un while (incluyendo la actual) si tiene </tag> salir del ciclo con break
                    // Console.WriteLine("Linea: " + numLinea + " "+ lineas[numLinea]);
                }
                numLinea++;
            }
            Console.WriteLine("Linea: " + numLinea + " " + lineas[numLinea]);
        }
    }
}
