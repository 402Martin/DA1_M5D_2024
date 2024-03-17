using Entities;

namespace MainApp;

internal class Program
{
    public static void Main(string[] args)
    {
        Student student1 = new Student("gonza", "rodriguez");
        Student student2 = new Student("matias", "calabrese");

        List<Student> students = new List<Student>([student1, student2]);
        Teacher teacher = new Teacher("DA1", students)
        {
            Name = "martin",
            LastName = "rado",
        };

        student1.Name = "Gonzalo";
        student1.DateOfBirth = new DateTime(2024, 11, 28);
        student1.LastName = "Rodriguez";
        
        Student std = teacher.Students.Find(x => x.Name == "gonza");
        Console.WriteLine("student", std);
        Student stdFind = teacher.Students.Find(x => x.Name == "Gonzalo");
        Console.WriteLine("student", stdFind);
    }
}