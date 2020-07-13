namespace ProjInherits_1.NomralInherits
{
    public class EstudianteCons : PersonaCons
    {
        private string _semestre;
        private string _profesion;

        public EstudianteCons(string firstName, string lastName, string semestre, string profesion) : 
            base(firstName, lastName)
        {
            this._semestre = semestre;
            this._profesion = profesion;
        }

        public string GetFullDataEstudent() {
            return $"Semestre: { _semestre } \nProfesion: { _profesion }";
        }

    }
}
