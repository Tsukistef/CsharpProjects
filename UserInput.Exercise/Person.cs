using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput.Exercise
{
    internal partial class Person
    {
        public Person(DateOnly dob) 
        {
            DateOfBirth = dob;
            _age = DateTime.Now.Year - DateOfBirth.Year;
        }

        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public DateOnly DateOfBirth { get; init; } // init is used because it is not set by the user
        public decimal Salary { get; set; }
        public char Gender { get; set; }
        public bool IsWorking { get; set; }

        private readonly int _age; // it is readonly because it is calculated and not set by the user

        public int GetNumberOfWorkingYearsRemaining()
        {
            return Constants.RetirementAge - _age; //this will return the number of years left until retirement
        }
        public DateOnly GetEstimatedRetirementDate()
        {
            return DateOnly.FromDateTime(DateTime.Now.AddYears(GetNumberOfWorkingYearsRemaining()));
        }

        public int GetAge()
        {
            return DateTime.Now.Year - DateOfBirth.Year;
        }
    }
}
