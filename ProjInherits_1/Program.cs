using ProjInherits_1.MultipleInherits;
using ProjInherits_1.NomralInherits;
using System;

namespace ProjInherits_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante = new Estudiante();

            estudiante.FirstName = "Alejandro";
            estudiante.LastName = "Martinez";
            estudiante.Semestre = "Octavo";
            estudiante.Profesion = "Ing sistemas";

            Console.WriteLine(estudiante.GetDataEsdutend());
            Console.WriteLine("=============================");

            Profesor profesor = new Profesor();
            profesor.FirstName = "Edgar";
            profesor.LastName= "Arciniegas";
            profesor.Experiencia = 15;

            Console.WriteLine(profesor.GetDataProfesor());


            Console.WriteLine("=============================");
            Console.WriteLine("Herencia por constructor");
            EstudianteCons est = new EstudianteCons("Andres", "Collazos", "Culminado", "Ing sistemas");

            Console.WriteLine(est.GetFullName());
            Console.WriteLine(est.GetFullDataEstudent());


            // =================
            


            Console.ReadLine();
        }
    }
}
