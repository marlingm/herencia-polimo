using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLOG_l
{
    class blog
    {

        // Atributos
        private DateTime fechaCreacion;
        private DateTime fechapublicacion;
        private string titulo;
        private string contenido;
        private string[] etiquetas;
        private int likes;
        private bool liked;
        private string[] comentarios;
        private int numeroVisitas;
        private string etiquetas1;
        
        public blog(string _titulo, string _contenido, string[] _etiquetas)
        {
            this.titulo = _titulo;
            this.contenido = _contenido;
            this.etiquetas = _etiquetas;
        }

        public blog(string titulo, string contenido, string etiquetas1)
        {
            // TODO: Complete member initialization
            this.titulo = titulo;
            this.contenido = contenido;
            this.etiquetas1 = etiquetas1;
        }

        // propiedades
        public DateTime FechaCreacion
        {
            get { return fechaCreacion; }
        }



       
        public string Titulo
        {
            get { return titulo; }
        }

        public string Contenido
        {
            get { return contenido; }
        }
        public string[] Etiquetas
        {
            get
            {
                return etiquetas;
            }
        }
        public int Likes
        {
            get { return likes; }
            set { likes = value; }
        }
        public bool Liked
        {
            get { return liked; }
        }
        public string[] Comentarios
        {
            get { return comentarios; }
        }

        public int NumeroVisitas
        {
            get { return numeroVisitas; }
        }
    }
}

