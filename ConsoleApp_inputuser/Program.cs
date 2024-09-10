//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("What's your name?");
//string name = Console.ReadLine();
//Console.WriteLine("Hello {0}", name);
//Console.WriteLine("Are you a paid employee?");
//var isPaid = Console.ReadLine().ToLower() == "yes" ? true : false;
//Console.WriteLine(isPaid);

//int counter = 0;
//while (counter  10)
//{
//    Console.WriteLine(counter);
//    counter++;
//}

int sum = 0;
int counter = 0;

while (counter != -1)
{
    Console.WriteLine("Enter a number: ");
    counter = int.Parse(Console.ReadLine());
    sum += counter;
    if (counter == -1)
    {
        sum +=1;
        Console.WriteLine(sum);
    }
}