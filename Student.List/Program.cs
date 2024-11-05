// An app that asks how many entries for each array, then ask for the entries, which will be student and scores,
// Once the arrays are created, it will print each student's grade.

using System.Reflection.Metadata.Ecma335;


try
{
    int input = 0;
    Console.WriteLine("Enter -1 to exit, or any other number to continue: ");
    input = Convert.ToInt32(Console.ReadLine());
    if (input == -1)
    {
        return;
    }

    int numEntries = 0;

    Console.WriteLine("How many entries do you want? ");
    numEntries = Convert.ToInt32(Console.ReadLine());

    string[] names = new string[numEntries];
    int[] grades = new int[numEntries];

    for (int i = 0; i < numEntries; i++)
    {
        Console.WriteLine("Enter student's name:");
        names[i] = Console.ReadLine();
        Console.WriteLine("Enter Student's grade: ");
        grades[i] = Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine("Student's grades:");

    for (int i = 0; i < numEntries; i++)
    {
        Console.WriteLine($" Student Name: {names[i]}\n Grade: {grades[i]}");
    }
            
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

