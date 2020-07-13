using System;

namespace ProjPolimorfismo
{

    public class Pofersor : Persona
    {
        public override string GetFullName(string firstName, string lastName)
        {            
            return string.IsNullOrEmpty(firstName) ? "Me envio algo vacio" : $" { firstName } ";
        }

        // Tengalo en considereación 
        public override string GetAge()
        {
            return "Yo tengo muchos años";
        }

    }
}
