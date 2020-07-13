using System;

namespace ProjPolimorfismo
{
    public abstract class Persona
    {

        public abstract string GetFullName(string firstName, string lastName);

        // Tengalo en considereación 
        public virtual string GetAge() {
            return "";
        }

        public void GetIdentificacion() {
            Console.WriteLine("106168685");
        }


    }
}
