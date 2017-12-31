using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_in
{
    class Curso:Imetodos

    {

        ListaDatos<Curso> cursos = new ListaDatos<Curso>();
       

       

        public void agregar()
        {


            for (int i = 1; i <= 5; i++)
            {
                Curso curso = new Curso();
                curso.NombreCurso = "Curso " + i;

                cursos.agregar(curso);
            }

        }

       
        public void mostrar()
        {
            foreach (var item in cursos.lista)
            {
                Console.WriteLine(item.NombreCurso);
            }


        }


        
        public string NombreCurso { get; set; }
    }
}
