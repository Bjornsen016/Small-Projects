using System;

namespace MovieDatabase
{
    public class Actor
    {
        public string FirstName;
        public string LastName;
        public DateTime DateOfBirth;
        public int Age => DateTime.Today.Year - DateOfBirth.Year;

    }
}