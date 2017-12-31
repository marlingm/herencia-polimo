using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_in
{
    class Program
    {
        static void Main(string[] args)
        {

            Estudiante es = new Estudiante();
            Curso Cur = new Curso();

            Mostrar.mostrarr(es);
            Mostrar.mostrarr(Cur);
           

          
            Console.ReadKey();
        }


    }
}
