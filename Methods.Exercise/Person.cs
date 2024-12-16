using System.Security.Cryptography;

namespace Methods.Exercise
{
    public class Person
    {
        public Person()
        {
            
        }
        // Costructor
        public Person(string firstName, string lastName, DateOnly dateofBirth, string _taxNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            DateofBirth = dateofBirth;
        }

        public Person(string firstName, string lastName, string taxNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            _taxNumber = taxNumber;
        }
       

        // Properties/ Data Members
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly DateofBirth { get; set; }

        // Fields - cannot interact with this cause it's private
        private string _taxNumber;
        protected string _idNumber = "N/A";

        public void PrintFullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }

        public void GenerateTaxCode()
        {
            if(string.IsNullOrEmpty(_taxNumber))
            {
                _taxNumber = RandomNumberGenerator.GetInt32(100000, 9999999).ToString();
            }
            else
            {
                Console.WriteLine("Tax number already exists");
            } 
        }

        public string GetTaxNumber()
        {
            return _taxNumber;
        }

        public string GetTeacherIdNum()
        {
            return _idNumber;
        }
    }
}
