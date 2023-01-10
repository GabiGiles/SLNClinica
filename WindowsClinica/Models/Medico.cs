using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WindowsClinica.Models.BASE;//agregar
namespace WindowsClinica.Models
{
    public class Medico:Persona
    {
        #region zona de contructores

        //constructor por defecto
        public Medico() { }

        //constructor con parámetros
        public Medico(string Nombre, string apellido, int prmMatricula):base(Nombre, apellido)
        { 
            Matricula = prmMatricula;
        }
        #endregion

        #region propiedades autoimplementadas
           
            public int Matricula { get; set; }
        #endregion
    }

}
