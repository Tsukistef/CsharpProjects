// Input from user

using System.Xml.Serialization;
using UserInput.Exercise;
using System.Globalization; // to use CultureInfo

char choice = char.MinValue;
string? firstName = String.Empty;
string lastName = String.Empty;
int age;
DateOnly dob = new DateOnly();
decimal salary;
char gender = char.MinValue;
bool working = true;

List<Person> persons = new List<Person>();

while (choice != 'E')
{
    Console.WriteLine("Please enter name: ");
    firstName = Convert.ToString(Console.ReadLine());

    Console.WriteLine("Please enter last name: ");
    lastName = Convert.ToString(Console.ReadLine());

    Console.WriteLine("Please enter your date of birth (mm/dd/yyyy): ");
    dob = DateOnly.ParseExact(Console.ReadLine(), "MM/dd/yyyy", CultureInfo.InvariantCulture);
    age = DateTime.Now.Year - dob.Year;

    Console.WriteLine("Please enter salary: ");
    salary = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("Please enter gender (M or F): ");
    gender = Convert.ToChar(Console.ReadLine());

    Console.WriteLine("Are you working? (true/false)");
    working = Convert.ToBoolean(Console.ReadLine());


    Person person = new(dob)
    {
        FirstName = firstName,
        LastName = lastName,
        DateOfBirth = dob,
        Gender = gender,
        IsWorking = working,
        Salary = salary,
    };
    persons.Add(person);
    Console.WriteLine("Press 'C' to continue or 'E' to exit: ");
    choice = Convert.ToChar(Console.ReadLine());
}
foreach (var person in persons)
{
    Console.WriteLine();
    Console.WriteLine($"Name: {person.LastName}, {person.FirstName}");
    Console.WriteLine($"Age: {person.GetAge()}");
    Console.WriteLine($"Salary: {person.Salary.ToString("C")}");
    Console.WriteLine($"Gender: {person.Gender}");
    Console.WriteLine($"Working: {person.IsWorking}");
    Console.WriteLine($"Number of working years remaining: {person.GetNumberOfWorkingYearsRemaining()}");
    Console.WriteLine($"Estimated retirement year: {person.GetEstimatedRetirementDate().Year}");
}

