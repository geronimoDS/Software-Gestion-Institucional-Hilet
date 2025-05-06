using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Gestion_Instituto.Clases
{
    public abstract class Identidad
    {
        private string Nombre;// { get; set; }
        private string Apellido; // { get; set; }
        private int DNI { get; set; }
        private int Edad { get; set; }
        private int Telefono { get; set; }
        private int Tel_Opcional { get; set; }
        private string Mail { get; set; }
        private string Calle { get; set; }
        private int Numero_Calle { get; set; }

        protected Identidad(string nombre, string apellido, int dNI, int edad,
            int telefono, int tel_Opcional, string mail,
            string calle, int numero_Calle)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dNI;
            Edad = edad;
            Telefono = telefono;
            Tel_Opcional = tel_Opcional;
            Mail = mail;
            Calle = calle;
            Numero_Calle = numero_Calle;
        }

        public Identidad()
        {
            /* Nombre = nombre;
             Apellido = apellido;*/
        }
    }

}
