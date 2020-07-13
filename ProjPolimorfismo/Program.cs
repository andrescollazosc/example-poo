using System;

namespace ProjPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona per = new Estudiante();
            Console.WriteLine(per.GetFullName("Alejandro", "Martinez"));


            Persona profe = new Pofersor();
            Console.WriteLine(profe.GetFullName("", ""));
            Console.WriteLine(profe.GetAge());
            profe.GetIdentificacion();

            Console.ReadLine();
        }
    }
}
