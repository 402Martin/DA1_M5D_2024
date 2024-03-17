
using Entities;

string name = "Martin";
string lastName = "Radovitzky";
DateTime dateOfBirth = new DateTime(2000, 11, 28);

// Using common constructors:
// 1. Creating a Person object with only name and last name provided
Person person = new Person(name, lastName); // Using constructor with name and last name parameters
// 2. Creating a Person object with name, last name, and date of birth provided
Person personWithAge = new Person(name, lastName, dateOfBirth); // Using constructor with name, last name, and date of birth parameters

// A newer alternative declaration using object initializer syntax:
// This allows initializing object properties directly without invoking a constructor explicitly
Person personInitializer = new Person // Using object initializer syntax
{
    Name = name,
    LastName = lastName,
    DateOfBirth = dateOfBirth,
};



