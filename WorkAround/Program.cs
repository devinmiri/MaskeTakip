using System;
using Business;
using Business.Concrete;
using Entities.Concrete;

namespace WorkAround;

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person()
        {
            NationalId = 19275507212,
            FirstName = "KAMAL",
            LastName = "DENIZ",
            DateOfBirthDay = 30,
            DateOfBirthMonth = 11,
            DateOfBirthYear = 1985

        };
        // person.NationalId = 123456789;
        // person.FirstName = "John";
        // person.LastName = "Doe";
        // person.DateOfBirthYear = 1985;

        PttManager pttManager1 = new(new PersonManager());
        PttManager pttManager2 = new(new ForeignerManager());
        pttManager1.GiveMask(person);
        pttManager2.GiveMask(person);

    }
}

