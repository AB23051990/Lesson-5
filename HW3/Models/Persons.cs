using HW3.Repositories;

namespace HW3.Controllers.Models
{
    public class Persons
    {
        private long _id;
        private string _name;
        internal object Person;
        internal int id;

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
    public interface IPersonsManager
    {
        IReadOnlyList<Persons> Test();

        bool ContainsType(int id);
    }

    public class PersonsManager : IPersonsManager
    {
        private readonly IPersonsRepository _repository;
        private IReadOnlyList<Persons> _index;
        public PersonsManager(IPersonsRepository repository)
        {
            _repository = repository;
        }
        public IReadOnlyList<Persons> Test()
        {
            if (_index is null)
            {
                _index = _repository.Test();
            }
            return _index;
        }

        public bool ContainsType(int id)
        {
            foreach (Persons paymentType in _index)
            {
                if (paymentType.Id == id)
                {
                    return true;
                }
            }
            return false;
        }
    }

}

