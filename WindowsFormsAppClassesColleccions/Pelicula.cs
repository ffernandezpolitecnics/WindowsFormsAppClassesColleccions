using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppClassesColleccions
{
    public class Pelicula : IEquatable<Pelicula>
    {
        public String titulo { get; set; }
        public String director { get; set; }
        public int anoEstreno { get; set; }
        public List<String> temas { get; set; }

        public Pelicula()
        {
            this.temas = new List<string>();
        }

        public bool Equals(Pelicula other)
        {
            bool igual = false;

            if (this.titulo.Equals(other.titulo))
            {
                igual = true;
            }

            return igual;
        }
    }
}
