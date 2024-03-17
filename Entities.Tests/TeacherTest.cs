namespace Entities.Tests;

[TestClass]
public class TeacherTest
{
    [TestMethod]
    public void CreateTeacher()
    {
        string name = "martin";
        string lastName = "rado";
        Teacher teacher = new Teacher();

        Assert.IsNotNull(teacher.TeacherNumber);
    }
    
}