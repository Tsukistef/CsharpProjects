namespace ConsoleApp.CallCenterAid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Credentials
            Console.WriteLine("Enter your Agent name: ");
            string nameAgent = Console.ReadLine();
            Console.WriteLine("Enter your company name: ");
            string callCentreName = Console.ReadLine();

            while (true) // this will reset and ask all the questions again until the program is exited
            {
                Console.WriteLine("------------------------------------");

                while (true) // Introduction
                {
                    Console.WriteLine("\nPlease choose from one of the following options:\n1.Inbound\n2.Outbound");
                    string dialType = Console.ReadLine();
                    switch (dialType)
                    {
                        case "1":
                            Console.WriteLine("Inbound:");
                            Console.WriteLine($"Hi, My name is {nameAgent} at {callCentreName}. Can I take your reference number?");
                            break;
                        case "2":
                            Console.WriteLine("Outbound:");
                            Console.WriteLine($"Hi, My name is {nameAgent} and I am calling from {callCentreName}. am I speaking to <Name>?");
                            break;
                        default:
                            Console.WriteLine("Wrong input. Please try again.");
                            continue;
                    }
                    break;
                }

                Console.WriteLine("------------------------------------");

                // Identifying the right person, if not program terminates
                try
                {
                    Console.WriteLine("Is the person: \n1. A Customer\n2. A third party\n3. An Unauthorised person");
                    int rightPerson = Convert.ToInt32(Console.ReadLine());

                    if (rightPerson == 1)
                    {
                        Console.WriteLine("\nAsk the customer to confirm:\n- Full Name including initials\n- Full Address with town and postcode\n- Date Of Birth\n\nHave they confirmed ALL? (y/n)");
                        bool IsAuthorised = ConvertToBoolean(Console.ReadLine());
                        if (IsAuthorised == false)
                        {
                            Console.WriteLine("Name & Address must be always confirmed.\nIf customer cannot confirm DOB, then ask customer to either confirm telephone number or email.");
                            Console.WriteLine("Continue? (y/n)");
                            bool passIdentification = ConvertToBoolean(Console.ReadLine());;
                            if (passIdentification == false)
                            {
                                Console.WriteLine("I am sorry unfortunately I am unable to continue as you have not confirmed all the data.");
                                return;
                            }
                        }
                    }
                    else if (rightPerson == 2)
                    {
                        Console.WriteLine("------------------------------------");
                        Console.WriteLine("\nCheck the authorisation on the 'comment box' in Caseflow'please.\nAsk to confirm their 'Full Name' and 'Relationship' to the customer\n");
                        Console.WriteLine("\nAsk the third party to confirm customer's:\n- Full Name including initials\n- Full Address with town and postcode\n- Date Of Birth\n\nHave they confirmed ALL? (y/n)");
                        bool IsAuthorised = ConvertToBoolean(Console.ReadLine());;
                        if (IsAuthorised == false)
                        {
                            Console.WriteLine("\nWhich data they cannot confirm?\n1.Name or Address\n2.DOB\n3.All three\n");
                            int wrongData = Convert.ToInt32(Console.ReadLine());

                            if (wrongData == 1)
                            {
                                Console.WriteLine("Name & Address must be always confirmed. Unfortunately you cannot proceed with the call.");
                                continue;
                            }
                            else if (wrongData == 2)
                            {
                                Console.WriteLine("If third party doesn't want to confirm or doesn't know customer's DOB, then ask them to either confirm a telephone number or email on file.");
                                Console.WriteLine("If they provide a completely wrong date of birth, you cannot proceed with the call.");
                            }
                            else
                            {
                                Console.WriteLine("I am very sorry but unfortunately I cannot proceed with the call. Is the customer there? y/n");
                                bool isCustomer = ConvertToBoolean(Console.ReadLine());;
                                if (isCustomer == false)
                                {
                                    Console.WriteLine("I am sorry unfortunately I am unable to continue as you are not authorised to talk on their behalf. Thank you for calling");
                                    return;
                                }
                            }
                        }

                        Console.WriteLine("\nDid you ask to confirm ALL Security Check and Data cleanse? (y/n)");
                        bool passIdentification = ConvertToBoolean(Console.ReadLine());;
                        if (passIdentification == false)
                        {
                            Console.WriteLine("I am sorry unfortunately I am unable to continue as you have not confirmed all the data.");
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("I am sorry unfortunately I need to talk to the customer directly, please advise the customer to call us back.");
                        continue;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid input, select true or false.");
                    continue;
                }

                while (true)
                {
                    try
                    {
                        Console.WriteLine("------------------------------------");
                        Console.WriteLine("First contact? y/n");
                        bool firstContact = ConvertToBoolean(Console.ReadLine());;
                        Console.WriteLine("Is the customer contacting us to make a payment? y/n");
                        bool payBill = ConvertToBoolean(Console.ReadLine());;

                        if (firstContact || payBill)
                        {
                            try
                            {
                                Console.WriteLine("------------------------------------");
                                Console.WriteLine("\nAre you calling to pay today? (y/n)");
                                bool clearBalance = ConvertToBoolean(Console.ReadLine());;
                                if (clearBalance)
                                {
                                    while (true) // Affordability
                                    {
                                        Console.WriteLine("\nJust to make sure that this is affordable for you and we are not putting you in any financial difficulties: ");
                                        Console.WriteLine("Can you confirm your source of income?\n1.Wages\n2.Benefits\n3.Savings\n4.Other");
                                        string incomeSource = Console.ReadLine(); //Income source
                                        Console.WriteLine("------------------------------------");
                                        switch (incomeSource) // Income source
                                        {
                                            case "1":
                                                Console.WriteLine("Wages - Continue with next question:"); // Wages
                                                break;
                                            case "2":
                                                Console.WriteLine("Benefits - Which benefits are you in receipt of?"); // Benefits
                                                Console.WriteLine("(If customer mentions Disability Income, ask if there is any medical circumstance they should make you aware of).");
                                                Console.WriteLine("\nDoes the customer suffer from any medical circumstances? (y/n)"); // Vulnerable trigger
                                                bool medicalCircumstances = ConvertToBoolean(Console.ReadLine());;

                                                if (medicalCircumstances == true) // Vulnerable process - Benefit trigger
                                                {
                                                    Console.WriteLine("\n**************Vulnerability Questions**************");
                                                    Console.WriteLine("Which circumstances is the customer affected with?\nType below:\n");
                                                    string medCondition = Console.ReadLine();
                                                    Console.WriteLine($"Do I have your explicit consent to note that you suffer from {medCondition}? (y/n)");
                                                    bool consent = ConvertToBoolean(Console.ReadLine());;

                                                    try
                                                    {
                                                        if (consent == true) // Permission given
                                                        {
                                                            Console.WriteLine("Thank you for that. Could I ask if your condition is affecting your ability to pay? how?");
                                                            // Additional questions to ask
                                                            Console.WriteLine("(Please transfer to CST if customer is unable to pay)");
                                                            Console.WriteLine("Are you responsible to manage your own finances?");
                                                            bool responsible = ConvertToBoolean(Console.ReadLine());;
                                                            if (responsible == false) // Not responsible
                                                            {
                                                                Console.WriteLine("Would you like to authorise somebody to talk on your behalf?\n(Add full name and relationship to third party in the comment box)");
                                                                Console.WriteLine("Ask if they would like to arrange a call back when the person will be present? (y/n)");
                                                                bool callBack = ConvertToBoolean(Console.ReadLine());;
                                                                if (callBack == true)
                                                                {
                                                                    Console.WriteLine("Thank you for your time. We will call you back.");
                                                                    return;
                                                                }
                                                            }
                                                            else // Responsible
                                                            {
                                                                Console.WriteLine("------------------------------------");
                                                                Console.WriteLine("Continue with affordability:");
                                                            }
                                                        }
                                                    }
                                                    catch (Exception e)
                                                    {
                                                        Console.WriteLine("Invalid input, select true or false.");
                                                        continue;
                                                    }
                                                    break;
                                                }
                                                break;

                                            case "3":
                                                Console.WriteLine("Savings - How do you plan to proceed when you run out of saving?");
                                                Console.WriteLine("(Please suggest Free Independent money advice and place breathing space hold if needed.)");
                                                break;
                                            case "4":
                                                Console.WriteLine("Other - Are you able to support yourself?");
                                                Console.WriteLine("(Please suggest Free Independent money advice and place breathing space hold if needed\nor complete I&E form.)");
                                                break;
                                            default:
                                                Console.WriteLine("Wrong input. Please try again.");
                                                continue;
                                        }
                                        Console.WriteLine("Are you up to date with all your priority bills? (y/n)"); // Priority Bills
                                        bool priorityBills = ConvertToBoolean(Console.ReadLine());;
                                        if (priorityBills == false)
                                        {
                                            Console.WriteLine("Which bills are you behind with? Do you have plans to pay? y/n"); // Plans in place
                                            try
                                            {
                                                bool hasPlans = ConvertToBoolean(Console.ReadLine());;
                                                if (hasPlans == true)
                                                {
                                                    Console.WriteLine("Continue with affordability:");
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("(Please suggest Free Independent money advice and place breathing space hold if needed).");
                                                    return;
                                                }
                                            }
                                            catch (Exception e)
                                            {
                                                Console.WriteLine("Invalid input, select true or false.");
                                                continue;
                                            }
                                        }

                                        Console.WriteLine("Do you have any other debts or creditors? y/n"); // Other Creditors
                                        try
                                        {
                                            bool otherDebts = ConvertToBoolean(Console.ReadLine());;
                                            if (otherDebts == true)
                                            {
                                                Console.WriteLine("Do you have any plans in place to repay them? y/n"); // Plans in place
                                                bool hasPlans = ConvertToBoolean(Console.ReadLine());;
                                                if (hasPlans == true)
                                                {
                                                    Console.WriteLine("Continue with affordability:");
                                                    Console.WriteLine("------------------------------------");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("(Please suggest Free Independent money advice and place breathing space hold if needed.)");
                                                    return;
                                                }
                                            }
                                            Console.WriteLine("------------------------------------");
                                            Console.WriteLine("What is an affordable amount for you?"); // Amount affordable
                                            int affordableAmount = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine($"Could you confirm that £{affordableAmount} is an affordable amount for you? y/n");
                                            try
                                            {
                                                bool isAffordable = ConvertToBoolean(Console.ReadLine());;
                                                if (isAffordable == true)
                                                {
                                                    Console.WriteLine("Please set up plan:\n- Confirm banking details and name on card\n- Read scripts\n- Transfer to correct recording");
                                                    Console.WriteLine("Press enter to exit.");
                                                    Console.ReadLine();
                                                    return;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("(Please suggest Free Independent money advice and place breathing space hold if needed.)\nPress enter to exit.");
                                                    Console.ReadLine();
                                                    return;
                                                }
                                            }
                                            catch (Exception e)
                                            {
                                                Console.WriteLine("Invalid input, select true or false.");
                                                continue;
                                            }
                                        }
                                        catch (Exception e)
                                        {
                                            Console.WriteLine("Invalid input, select true or false.");
                                            continue;
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("------------------------------------");
                                    Console.WriteLine("How can I help you today?");
                                    break;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Invalid input, select true or false.");
                                continue;
                            }
                            break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Invalid input, select true or false.");
                        continue;
                    }

                    // Other actions
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("Provide with a summary of the previous call, and try to secure a plan according to the circumstances.");
                    break;
                }
                Console.WriteLine("------------------------------------");
                Console.WriteLine("What does the customer want to do today?\nChoose an option\n");
                Console.WriteLine("\n1. Disputing the balance\n2. Informing you of vulnerability\n3. Informing you of financial difficulties\n4. Exit");
                try
                {
                    string choiceAlt = Console.ReadLine();

                    switch (choiceAlt)
                    {
                        case "1":
                            Console.WriteLine("Disputing the balance - Please take note on why the customer is disputing. ?Handle objection accordingly, follow client's guidelines for disputes.");
                            break;
                        case "2":
                            Console.WriteLine("Informing you of vulnerability - Continue with Vulnerability questions");
                            break;
                        case "3":
                            Console.WriteLine("Informing you of financial difficulties - Go through Income & Expenditure form and provide Free Independent Money Advice telephone numbers");
                            break;
                        case "4":
                            Console.WriteLine("(Press enter to exit.");
                            Console.ReadLine();
                            return;
                        default:
                            Console.WriteLine("Wrong input. Please try again.");
                            continue;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid input, select an option.");
                    continue;
                }
                continue;
            }
        }

        //a function to convert y or n to boolean
        static bool ConvertToBoolean(string input)
        {
            return input.ToLower() == "y";
        }
    }
}
