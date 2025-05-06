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

        // Hilet Nat U8
        public static string CADENA_CONEXION = "Data Source = 192.168.0.100; Database = u8; User Id = u8; Password=u8; TrustServerCertificate = True";

        // Nat
        //public static string CADENA_CONEXION = "Server=(LocalDB)\\TestDB;Integrated Security=true;AttachDbFileName=C:\\Users\\nat17\\testing.mdf";


        // u15
        //public static string CADENA_CONEXION = "Data Source = 192.168.0.100; Database=u15; User Id = u15; Password=u15; TrustServerCertificate = True";

        //public static string CADENA_CONEXION = "Data Source=DESKTOP-PAV2VPF\\GERONIMODS_BDD;Initial Catalog=tp;Integrated Security=True;Encrypt=False";


        // Gonza Casa
        //public static string CADENA_CONEXION = "Data Source=DESKTOP-P0IDJCG\\SQLEXPRESS;Initial Catalog=tp_final;Integrated Security=True;Encrypt=False";

        //Notebook
        //public static string CADENA_CONEXION = "Data Source=DESKTOP-QQR2QEC\\SQLEXPRESS;Initial Catalog=tp_final;Integrated Security=True;Encrypt=False";

        //HILET GONZA U20
        //public static string CADENA_CONEXION = "Data Source = 192.168.0.100; Database=u20; User Id = u20; Password=u20; TrustServerCertificate = True";






        public static NivelUsuario Permiso { get; set; }
        public static int ID_Login { get; set; } // ID_Login de la tabla Usuarios
        public static int ID_Persona { get; set; } // ID del alumno o del personal


        public static int AlumnoCarrera { get; set; } // ID de la carrera del alumno logeado
        public static int AlumnoCursada { get; set; } // Año de cursada del alumno logeado

    }
}
