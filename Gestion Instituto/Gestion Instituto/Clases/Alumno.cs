using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Instituto.Clases
{
    internal class Alumno : Identidad
    {

        public DateTime FechaInscripcion;// { get; }

        public Alumno(DateTime fechaInscripcion)
        {
            FechaInscripcion = fechaInscripcion;
        }
        public Alumno(string nombre, string apellido, int dNI,
            int edad, int telefono, int tel_Opcional, string mail,
            string calle, int numero_Calle, DateTime fechaInscripcion) : base( nombre,  apellido, 
                 dNI,  edad , telefono,  tel_Opcional, mail,
             calle,numero_Calle)
        {
            FechaInscripcion = fechaInscripcion;
        }

    }
}
