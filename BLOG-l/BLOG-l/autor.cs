using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLOG_l
{
    class autor:blog
    {

        public autor(string _titulo, string _contenido, string[] _etiquetas)
            : base(_titulo, _contenido, _etiquetas)
        { 

        }



        
        private DateTime fechapublicacion;
        string nombreautor;

    }
}
