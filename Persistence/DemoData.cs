using Domain;

namespace Persistence;

public class DemoData : IDataAccess
{
    private readonly IList<Person> people;
    public DemoData()
    {
        people = new List<Person>
        {
            new Person("Yuré", "Vanderbruggen"),
            new Person("John", "Doe")
        };
    }

	public Task AddPerson(Person person)
	{
        return Task.Run(() => people.Add(person));
	}

	public Task<IEnumerable<Person>> GetPeople()
    {
        return Task.FromResult<IEnumerable<Person>>(people);
    }
}
