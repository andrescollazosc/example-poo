using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjInherits_1.NomralInherits
{
    public class Persona
    {
        // Atributos
        private string firstName;

        public string FirstName { 
            get { 
                return firstName; 
            } 
            
            set {
                firstName = value;
            } 
        }

        public string LastName { get; set; }

        public string GetFullName() {
            return $"{ FirstName } { LastName }";
        }

    }
}
