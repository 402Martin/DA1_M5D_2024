namespace Entities;

public class Teacher: Person
{
    public string TeacherNumber { get; }

    public Teacher() : base()
    {
        Random random = new Random();
        TeacherNumber = random.Next(100000, 999999).ToString();
    }
}