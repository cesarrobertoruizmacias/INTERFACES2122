using System;
using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;
 Aplicacion_de_Consola.Clases;

namespace Aplicacion_de_Consola
{
    public class program
    {
        static void Main(string[] args)
        {

            Alumno alumno = new Alumno("22222", "jouse", "sanchez olvera");
            Alumno alumno2 = new Alumno();
            Console.WriteLine(alumno.obtenerinformacion());
            Console.Read();
                }
    }
}
