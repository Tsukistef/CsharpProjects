namespace ConsoleApp_propertyCal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create a console app that calculate the value of a property house.
            // Indexes are number of rooms, size in sqr mt, number of floors, location.
            // Define range for each index, add all of them and print result.
            int roomsNum;
            int sizeSqrMt;
            int floorsNum;
            string location = string.Empty;
            var valueTotal = 0;

            Console.WriteLine("Welcome to the Property Calculator! Please answer the following questions:");

            // Index 1: Rooms number
            while (true)    //it will break when user enters a valid input
            {
                Console.WriteLine("Enter the number of rooms:");
                bool isValidInput = int.TryParse(Console.ReadLine(), out roomsNum);

                if (isValidInput)
                {
                    if (roomsNum <= 0)
                    {
                        Console.WriteLine("Invalid number. The property must have at least one room.");
                        continue;
                    }
                    else if (roomsNum > 0)
                    {
                        for (int i = 0; i < roomsNum; i++)
                        {
                            valueTotal += 10000;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a positive number.");
                    continue;
                }
                break;
            }

            // Index 2: Square meters
            while (true)
            {
                Console.WriteLine("Enter the number of square meters:");
                bool isValidInput = int.TryParse(Console.ReadLine(), out sizeSqrMt);

                if (isValidInput) {
                    {
                        if (sizeSqrMt <= 36)
                        {
                            Console.WriteLine("Invalid number. The property must have at least 37 square meter.");
                            continue;
                        }
                        else
                        {
                            valueTotal += sizeSqrMt * 500;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a positive number.");
                    continue;
                }

                break;
            }
            
            while (true)
            {
                Console.WriteLine("Enter the numbers of floors:");
                bool isValidInput = int.TryParse(Console.ReadLine(), out floorsNum);

                if (isValidInput)
                {
                    if ( floorsNum <= 0)
                    {
                        Console.WriteLine("Invalid number. The property must have a least one floor:");
                    }
                    else
                    {
                        valueTotal += floorsNum * 500;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a positive number:");
                    continue;
                }

                break;
            }
            // Index 4: Location
            Console.WriteLine("Please enter one of the following locations:");
            while (true)
            { 
                Console.WriteLine("\n 1. North London \n 2. South London \n 3. East London \n 4. West London");
                switch (Console.ReadLine())
                {
                    case "1":
                        location = "North London";
                        valueTotal += 12000;
                        break;
                    case "2":
                        location = "South London";
                        valueTotal += 8000;
                        break;
                    case "3":
                        location = "East London";
                        valueTotal += 9500;
                        break;
                    case "4":
                        location = "West London";
                        valueTotal += 1000;
                        break;
                    default:
                        Console.WriteLine("Invalid input. You must select a number between 1 and 4. \n The property must be in one of the following locations:");
                        continue;
                }
                break;
            }

            Console.WriteLine($"The total value of the property is: £{valueTotal}");
        }
    }
}
