
using Entities;

string name = "Martin";
string lastName = "Radovitzky";
DateTime dateOfBirth = new DateTime(2000, 11, 28);

// different ways to create the Person instance with constructors
Person person = new Person(name,lastName);
Person personWithAge = new Person(name,lastName, dateOfBirth);

// with newer declarations:
Person personInitializer = new Person
{
    Name = name,
    LastName = lastName,
    DateOfBirth = dateOfBirth
};




