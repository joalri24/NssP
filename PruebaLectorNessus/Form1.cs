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
                    Console.WriteLine("Linea: " + numLinea + " " + lineas[numLinea]);
                }
                numLinea++;
            }
        }
    }
}
