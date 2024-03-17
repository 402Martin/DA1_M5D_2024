namespace Entities.Tests;

[TestClass]
public class TeacherTest
{
    [TestMethod]
    public void CreateTeacher()
    {
        string name = "martin";
        string lastName = "rado";
        string subject = "subject";
        Teacher teacher = new Teacher(subject)
        {
            Name = name,
            LastName = lastName
        };

        Assert.IsNotNull(teacher.TeacherNumber);
    }

    [TestMethod]
    public void GetOccupation()
    {
        string name = "martin";
        string lastName = "rado";
        string subject = "subject";
        Student student1 = new Student(name, lastName);
        Student student2 = new Student(name, lastName);
        List<Student> students = new List<Student>();
        students.Add(student1);
        students.Add(student2);
        Teacher teacher = new Teacher(subject, students)
        {
            Name = name,
            LastName = lastName
        };

        string expectedOccupation ="Teacher";
        string occupation = teacher.getOccupation();
        Assert.AreEqual(expectedOccupation, occupation);
    }
    
    [TestMethod]
    public void CreateStudents()
    {
        string name = "martin";
        string lastName = "rado";
        string subject = "subject";
        Student student1 = new Student(name, lastName);
        Student student2 = new Student(name, lastName);
        List<Student> students = new List<Student>();
        students.Add(student1);
        students.Add(student2);
        Teacher teacher = new Teacher(subject, students)
        {
            Name = name,
            LastName = lastName
        };
        
        Assert.AreEqual(students, teacher.Students);

    }
}