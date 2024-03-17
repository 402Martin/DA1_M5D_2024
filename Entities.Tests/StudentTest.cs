namespace Entities.Tests;

[TestClass]
public class StudentTest
{
    [TestMethod]
    public void CreateStudent()
    {
        // Arrange
        string name = "martin";
        string lastName = "rado";
        // Act 
        Student student = new Student(name,lastName);
        // Assert
        Assert.AreEqual(name,student.Name);
        Assert.AreEqual(lastName,student.LastName);
    }

    [TestMethod]
    public void CreateStudentWithStudentNumber()
    {
        
        // Arrange
        string name = "martin";
        string lastName = "rado";
        // Act 
        Student student = new Student(name,lastName);
        // Assert
        Assert.IsNotNull(student, student.StudentNumber);
        
    }
    
    
    [TestMethod]
    public void GetOccupation()
    {
        string name = "martin";
        string lastName = "rado";
        Student student = new Student(name, lastName);
        string expectedOccupation ="student";
        string occupation = student.getOccupation();
        Assert.AreEqual(expectedOccupation, occupation);
    }
    
    
}