using System.Collections.Generic;
using System.Linq;

public class Family
{
    private List<Person> people;

    public Family()
    {
        Peoples = new List<Person>();
    }
    public List<Person> Peoples
    {
        get { return this.people; }
        set { this.people = value; }
    }

    public void AddMember(Person member)
    {
        this.Peoples.Add(member);
    }

    public Person GetOldestMember()
    {
        return Peoples.OrderByDescending(x => x.age).FirstOrDefault();
    }
}