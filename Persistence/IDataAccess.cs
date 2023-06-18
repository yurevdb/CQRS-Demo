using Domain;

namespace Persistence;
public interface IDataAccess
{
    Task<IEnumerable<Person>> GetPeople();
}
