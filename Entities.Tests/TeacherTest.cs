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
    
}