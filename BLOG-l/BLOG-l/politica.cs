using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLOG_l
{
    class politica:blog
    {


        public politica(string titulo, string contenido,string etiquetas)
            : base(titulo, contenido,etiquetas)
        {


        }
        public string tipo_politica { get; set; }
    }
    
    }
