using Application;

namespace Persistence;
public interface IDataAccess
{
    Task<IEnumerable<Person>> GetPeople();
}
