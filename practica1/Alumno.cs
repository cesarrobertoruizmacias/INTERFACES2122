using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_de_Consola
{
     /// <summary>
     /// clase que representa a un alumno
     /// </summary>
   public class Alumno
    {
        private string cve_unica;
        private string nombres;
        private string apellidos;
         /// <summary>
         /// constructor de la clase
         /// </summary>
        public Alumno() { }
         
        /// <summary>
        /// constructor de la clase que asigna informacion inicial
        /// </summary>
        /// <param name="cve_unica">clave unica</param>
        /// <param name="nombres">nombre del alumno</param>
        /// <param name="apellidos">apellidos del alumno </param>
        public Alumno(string cve_unica,string nombres, string apellidos)
        {
            cve_unica = cve_unica;
            nombres = nombres;
            apellidos = apellidos;

        }
        /// <summary>
        /// obtiene la informacion del alumno en una sola variable
        /// </summary>
        /// <returns>cadena cn informacion del alumno</returns>
        public string obtenerinformacion()
        {
            string informacion = "";
            informacion = cve_unica + " - " + nombres + " " + apellidos;
            return informacion;
        }
    }
}
