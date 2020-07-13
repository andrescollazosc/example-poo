namespace ProjInherits_1.NomralInherits
{
    public class Profesor : Persona
    {
        public int Experiencia { get; set; }
        public string[] Materias { get; set; }


        public string GetDataProfesor() {
            return $"{ GetFullName() } \nAños de experiencia: { Experiencia } \nMaterias: { GetMaterias() }";
        }

        private string[] GetMaterias() {
            string[] materias = new string[] { "Español", "Matematicas", "Biologia", "Sociales" };

            return materias;
        }
    }
}
