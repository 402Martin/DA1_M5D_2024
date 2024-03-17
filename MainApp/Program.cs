
using Entities;

string name = "Martin";
string lastName = "Radovitzky";
DateTime dateOfBirth = new DateTime(2000, 11, 28);
Person person = new Person(name,lastName);
Person personWithAge = new Person(name,lastName, dateOfBirth);

Console.WriteLine(person.Age);
Console.WriteLine(personWithAge.Age);
