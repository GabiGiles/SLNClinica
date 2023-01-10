using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsClinica.Models.BASE
{
    public abstract class Persona
    {
        public Persona() { }
        public Persona( string nombre, string apellido)
        {
            Apellido = apellido;
            Nombre = nombre;
        }
    
        public string Apellido { get; set; }
        public string Nombre { get; set; }
    }
}
