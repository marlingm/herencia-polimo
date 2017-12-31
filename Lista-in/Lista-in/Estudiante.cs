using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_in
{
    class Estudiante:Imetodos


    {


        ListaDatos<Estudiante> estudiantes = new ListaDatos<Estudiante>();
       
        public void agregar()
        {
           
            for (int i = 1; i <= 5; i++)
            {
                Estudiante estudiante = new Estudiante();
                estudiante.NombreEstudiante = "Estudiante " + i;

                estudiantes.agregar(estudiante);
            }


        }

       

        public void mostrar()
        {
            foreach (var item in estudiantes.lista)
            {
                Console.WriteLine(item.NombreEstudiante);
            }

        }
        
      
        
        public string NombreEstudiante { get; set; }
    }
}
