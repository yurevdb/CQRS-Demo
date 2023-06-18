namespace Domain;

public class Person
{
    public string FirsName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Initials => $"{FirsName.FirstOrDefault()}{LastName.FirstOrDefault()}";
    public Person() { }
    public Person(string firstname, string lastname) {
        FirsName = firstname; 
        LastName = lastname; 
    }
}
