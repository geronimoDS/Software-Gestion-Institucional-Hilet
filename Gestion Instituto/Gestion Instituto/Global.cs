using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Instituto
{
    public enum NivelUsuario { ADMIN, PERSONAL, PROFESOR, ALUMNO }

    internal static class Global
    {

        // u15
        //public static string CADENA_CONEXION = "Data Source = ****; Database=****; User Id = ****; Password=****; TrustServerCertificate = True";


        public static NivelUsuario Permiso { get; set; }
        public static int ID_Login { get; set; } // ID_Login de la tabla Usuarios
        public static int ID_Persona { get; set; } // ID del alumno o del personal


        public static int AlumnoCarrera { get; set; } // ID de la carrera del alumno logeado
        public static int AlumnoCursada { get; set; } // Año de cursada del alumno logeado

    }
}
