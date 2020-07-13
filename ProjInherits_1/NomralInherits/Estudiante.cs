using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjInherits_1.NomralInherits
{
    public class Estudiante : Persona
    {
        public string Semestre { get; set; }
        public string Profesion { get; set; }

        public string GetDataEsdutend()
        {
            return $"Nombres: { GetFullName() } \nSemestre: { Semestre } \nProfession: { Profesion }";
        }

    }
}
