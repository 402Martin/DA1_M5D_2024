namespace Entities;

public class Teacher: Person
{
    public string TeacherNumber { get; }
    public string Subject; 

    public Teacher(string subject) : base()
    {
        Random random = new Random();
        TeacherNumber = random.Next(100000, 999999).ToString();
        Subject = subject;
    }
    
}