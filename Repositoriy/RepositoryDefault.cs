using MVCTest.Data.Context;
using MVCTest.Models;

namespace MVCTest.Repositoriy
{
    public class RepositoryDefault
    {
        private readonly MVCTestContext _context;

        public RepositoryDefault(MVCTestContext context)
        {
            _context = context;
        }

        public IEnumerable<Person> GetAll()
        {
            return _context.Person.ToList();
        }

        public void Add(Person person)
        {
            _context.Add(person);
            _context.SaveChanges();
        }
    }
}