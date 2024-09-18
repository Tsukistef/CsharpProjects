
//Calculator console app

using System.Numerics;

int choice = 0;
int num1 = 0, num2 = 0;


while (choice != -1)
{
    Console.WriteLine("\nPlease select operation to perform. Type -1 to exit");
    Console.WriteLine("1. Add");
    Console.WriteLine("2. Subtract");
    Console.WriteLine("3. Multiply");
    Console.WriteLine("4. Divide");
    Console.WriteLine("5. Fibonacci");

    try     // Will handle any invalid input
    {

        choice = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        if (choice == -1)
        {
            Console.WriteLine("Exiting the program");
            break;
        }
        if (choice > 5 || choice < 1)       // handles out of range input
        {
            Console.WriteLine("Input out of range, try again");
            continue;
        }
        else
        {
            Console.WriteLine("Enter the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            num2 = Convert.ToInt32(Console.ReadLine());

            int AddNum(int num1, int num2)
            {
                return num1 + num2;
            }

            int SubtractNum(int num1, int num2)
            {
                return num1 - num2;
            }

            int MultiplyNum(int num1, int num2)
            {
                return num1 * num2;
            }

            int DivideNum(int num1, int num2)
            {
                return num1 / num2;
            }

            int Fibonacci(int num1, int num2)
            {
                int result = 0;
                for (int i = 0; i < 5; i++)
                {
                    result = num1 + num2;
                    num1 = result;
                    num2 = result + num1;
                    Console.WriteLine($"Result {i}: {num1}, {num2}");
                }

                return num2;
            }


            switch (choice)
            {
                case 1:
                    Console.WriteLine("Result: " + AddNum(num1, num2));
                    break;

                case 2:
                    Console.WriteLine("Result: " + SubtractNum(num1, num2));
                    break;

                case 3:
                    Console.WriteLine("Result: " + MultiplyNum(num1, num2));
                    break;

                case 4:
                    Console.WriteLine("Result: " + DivideNum(num1, num2));
                    break;

                case 5:
                    Console.WriteLine("Result: " + Fibonacci(num1, num2));
                    break;

            }
        }
    }
    catch (DivideByZeroException e)
    {
        Console.WriteLine(e.Message);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
        Console.WriteLine("\nInvalid Input, try again");
    }
}

