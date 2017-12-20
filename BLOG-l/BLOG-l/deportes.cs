using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLOG_l
{
    class deportes:blog
    {


        public deportes(string titulo, string contenido,string etiquetas)
            : base(titulo, contenido,etiquetas)
        {


        }


        public string tipo_deporte { get; set; }
    }
}
