namespace Entities;

public class Student: Person
{
    public string StudentNumber { get; }
    

    public Student(string name, string lastName): base(name,lastName)
    {
        Random random = new Random();
        StudentNumber = random.Next(100000, 999999).ToString();
    }

    public override string getOccupation()
    {
        return "student";
    }
}