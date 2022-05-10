namespace HW3.Controllers.Models
{
    public class Persons
    {
        private long _id;
        private string _name;
        internal object Person;

        public long Id
        {
            get => _id;
            set => _id = value;
        }
        public string Name
        {
            get => _name;
            set => _name = value;
        }        

        internal Persons(long id, string name)
        {
            _id = id;
            _name = name;            
        }

        internal Persons() { }
    }
    public class PersonsFactory
    {
        public Persons Create(long id, string name) => new Persons(id, name);
    }
}
