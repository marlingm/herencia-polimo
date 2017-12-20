using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLOG_l
{
    class registro:login
    {



        public registro(string user, string password):base(user,password)
        {
        }



        public int edad { get; set; }
        public string profesion { get; set; }
        public int telefono { get; set; }

    }
}
