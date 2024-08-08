// See https://aka.ms/new-console-template for more information
Console.WriteLine("What's your name?");
string name = Console.ReadLine();
Console.WriteLine("Hello {0}", name);
Console.WriteLine("Are you a paid employee?");
var isPaid = Console.ReadLine().ToLower() == "yes" ? true : false;
Console.WriteLine(isPaid);
