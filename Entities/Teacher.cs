namespace Entities;

public class Teacher: Person
{
    public string TeacherNumber { get; }
    public string Subject;
    public List<Student> Students = new List<Student>();

    public Teacher(string subject) : base()
    {
        Random random = new Random();
        TeacherNumber = random.Next(100000, 999999).ToString();
        Subject = subject;
    }

    public Teacher(string subject, List<Student> students): this(subject)
    {
        Students = students;
    }

    public override string getOccupation()
    {
        return "Teacher";
    }
}