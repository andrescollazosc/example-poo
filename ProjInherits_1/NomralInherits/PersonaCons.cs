namespace ProjInherits_1.NomralInherits
{
    public class PersonaCons
    {
        private string _firstName;
        private string _lastName;

        public PersonaCons(string firstName, string lastName)
        {
            this._firstName = firstName;
            this._lastName = lastName;
        }

        public string GetFullName() {
            return $"{ _firstName } { _lastName }";
        }
    }
}
