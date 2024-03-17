namespace Entities.Tests;

[TestClass]
public class PersonTest
{
    [TestMethod]
    public void CreatePersonWithoutDateOfBirth()
    {
        // Arrange
        string name = "name";
        string lastName = "lastName";
        // Act
        Person person = new Person(name, lastName);
        // Assert

        Assert.AreEqual(name, person.Name);
        Assert.AreEqual(lastName, person.LastName);
    }
    
    
    [TestMethod]
    public void CreatePersonWithDateOfBirth()
    {
        // Arrange
        string name = "name";
        string lastName = "lastName";
        DateTime dateOfBirth = new DateTime(2000, 11, 28);
        // Act
        Person person = new Person(name, lastName, dateOfBirth);
        // Assert
        Assert.AreEqual(dateOfBirth, person.DateOfBirth);
    }

    [TestMethod]
    public void GetAgeWithoutDateOfBirth()
    {
        // Arrange
        string name = "name";
        string lastName = "lastName";
        Person person = new Person(name, lastName);
        // Act
        int? age = person.Age;
        // Arrange 
        Assert.IsNull(age);
    }
    
    
    [TestMethod]
    public void GetAgeWithDateOfBirth()
    {
        // Arrange
        string name = "name";
        string lastName = "lastName";
        DateTime dob = new DateTime(2000, 11, 28);
        Person person = new Person(name, lastName,dob);
        int expectedAge = 23;
        // Act
        int? age = person.Age;
        // Arrange 
        Assert.AreEqual(expectedAge, age);
    }
}