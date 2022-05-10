
/*
namespace HW3.DAL.Repository
{
    public class PersonsRepository : IPersonsRepository
    {
        private readonly UserDbContext _context;
        public PersonsRepository(UserDbContext context)
        {
            _context = context;
        }
        public bool Add(Persons entity)
        {
            try
            {
                _context.Add(entity);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public IEnumerable<Persons> Get()
        {
            
            return _context.Person.Where(x => x.IsDeleted == false).ToList();
        }
        public bool Update(Persons entity)
        {
            // skipped try/catch
            return Commit();
        }
        public bool Delete(int id)
        {            
            return Commit();
        }
        private bool Commit()
        {
            int count = _context.SaveChanges();
            return count > 0;
        }
    }
}
*/