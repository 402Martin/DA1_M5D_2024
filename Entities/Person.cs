namespace Entities;

public class Person
{
    public string Name;
    public string LastName;
    public DateTime? DateOfBirth = null;

    public Person(string name, string lastName, DateTime dateOfBirth)
    {
        Name = name;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
    }

    public Person(string name, string lastName)
    {
        Name = name;
        LastName = lastName;
    }

    public Person()
    {
    }

    public int? Age {
        get
        {
            if (!DateOfBirth.HasValue) return null;
            DateTime today = DateTime.Now;
            int age = today.Year - DateOfBirth.Value.Year;
            if (DateOfBirth < today.AddYears(-age))
                return age;
            return (age - 1);
        }
    }

    public virtual string getOccupation()
    {
        return "not employed";
    }



}