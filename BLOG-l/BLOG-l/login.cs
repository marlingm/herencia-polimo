using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLOG_l
{
    class login
    {

        private int id_usuario;
        private string user;
        private string password;


        public login (string user, string password, int id_usuario)
        {

            this.USER = user;
            this.Password = password;
            this.Id_usuario = id_usuario;





        }

        public login (string user, string password)
        {
            
            this.user = user;
            this.password = password;
        }



        public string USER { get; set; }

        public string Password { get; set; }

        public int Id_usuario { get; set; }
    }
}

