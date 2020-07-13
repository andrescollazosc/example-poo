namespace ProjPolimorfismo
{
    public class Estudiante : Persona
    {
        public string Semestre { get; set; }

        public override string GetFullName(string firstName, string lastName) {
            return $"Nombres: { firstName } \nApeellidos: { lastName }";
        }


    }
}
