namespace assignment1
{
    internal class Program
    {

        // Main menu of the application
        static string MainMenu()
        {
            Console.WriteLine("----------Main Menu----------");
            Console.WriteLine();
            Console.WriteLine("1 --> Display Information");
            Console.WriteLine("2 --> Date and Time Operations");
            Console.WriteLine("3 --> Text Operations");
            Console.WriteLine("4 --> Exit");
            Console.WriteLine();
            Console.WriteLine("Enter 1, 2, 3, or 4: ");

            return Console.ReadLine(); //collects data

        }

        //sub menu for the second option (Date and Time)
        static string Opt2SubMenu()
        {
            Console.WriteLine("------Option 2 Sub Menu-------");
            Console.WriteLine();
            Console.WriteLine("1 --> Display current Date and Time");
            Console.WriteLine("2 --> Add Days to Current Date");
            Console.WriteLine("3 --> Calculate Age from Birthdate");
            Console.WriteLine("4 --> Return to Main Menu");
            Console.WriteLine();
            Console.WriteLine("Enter 1, 2, 3, or 4: ");

            return Console.ReadLine(); //collects data
        }

        // sub menu for the third option (Date and Time)
        static string Opt3SubMenu()
        {
            Console.WriteLine("------Option 3 Sub Menu------");
            Console.WriteLine();
            Console.WriteLine("1 --> Reverse Text");
            Console.WriteLine("2 --> Convert to Uppercase");
            Console.WriteLine("3 --> Convert to Lowercase");
            Console.WriteLine("4 --> Return to Main Menu");
            Console.WriteLine();
            Console.WriteLine("Enter 1, 2, 3, or 4: ");

            return Console.ReadLine(); //collects data
        }

        // Menu Options
        static void Main(string[] args)
        {
            while (true)
            {
                var choice = MainMenu();

                if (choice == "1") // Display Information
                {
                    Console.WriteLine(); // for better readability
                    Console.WriteLine("Name: Rojan Jafarnezhad");
                    Console.WriteLine("School: George Brown College");
                    Console.WriteLine("Major: Computer Programming");
                    Console.WriteLine();
                }
                else if (choice == "2") { DateAndTime(); } //calls option 2
                else if (choice == "3") { TextOperation(); } //calls option 3
                else if (choice == "4")
                {
                    Console.WriteLine("Exiting..."); break; //exits the program
                }
                else { Console.WriteLine("Bad input! Try again!"); }
            }
        }


        //--------------------------
        // Option 2:
        private static void DateAndTime()
        {
            while (true)
            {
                var choice = Opt2SubMenu();

                if (choice == "1" || choice == "2")
                {
                    if (choice == "1")
                    {
                        string localDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss tt");

                        Console.WriteLine();
                        Console.WriteLine($"\tCurrent Date and Time: {localDateTime}");
                        Console.WriteLine();
                    }
                    else if (choice == "2")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Enter the number of days: ");

                        int days;

                        while (!int.TryParse(Console.ReadLine(), out days)) 
                            //this makes sure the wrong input doesnt break the program
                        {
                            Console.WriteLine();
                            Console.WriteLine("Invalid input! Please enter a valid number: ");
                        }

                        DateTime today = DateTime.Now;
                        DateTime answer = today.AddDays(days);

                        Console.WriteLine();
                        Console.WriteLine($"\t{days} days from today: {answer}");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input. Enter a valid number.");
                    }
                }
                else if (choice == "3")
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter your birth Year: ");

                    int birthYear;

                    while (!int.TryParse(Console.ReadLine(), out birthYear) || birthYear > DateTime.Now.Year)
                            //this makes sure the wrong input doesnt break the program
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid Input. Please enter a valid year: ");
                    }

                    DateTime today = DateTime.Today;
                    int age = today.Year - birthYear;

                    Console.WriteLine($"\tYou are {age} years old.");
                    Console.WriteLine();
                }
                else if (choice == "4")
                {
                    return;
                }
                else { Console.WriteLine("Bad Input!"); }
            }
        }


        // Option 3:
        private static void TextOperation()
        {
            while (true)
            {
                var choice = Opt3SubMenu();

                if (choice == "1")
                {
                    Console.WriteLine();
                    Console.WriteLine("Type in your text and enter to reverse it: ");

                    string text = Console.ReadLine();

                    if (string.IsNullOrEmpty(text))
                            //this makes sure an empty input doesnt break the program
                    {
                        Console.WriteLine("Input cannot be empty!");
                    }
                    else
                    {
                        string reverse = string.Empty;

                        for (int i = text.Length - 1; i >= 0; i--)
                        {
                            reverse += text[i];
                        }

                        Console.WriteLine();
                        Console.WriteLine($"\t{reverse}");
                        Console.WriteLine();
                    }
                }
                else if (choice == "2")
                {
                    Console.WriteLine();
                    Console.WriteLine("Type in your text and enter to convert the letters into UpperCase: ");

                    string originalString = Console.ReadLine();
                    string upperCaseString = originalString.ToUpper();

                    Console.WriteLine();
                    Console.WriteLine($"\t{upperCaseString}");
                    Console.WriteLine();
                }
                else if (choice == "3")
                {
                    Console.WriteLine();
                    Console.WriteLine("Type in your text and enter to convert the letters into LpperCase: ");

                    string originalString = Console.ReadLine();
                    string lowerCaseString = originalString.ToLower();

                    Console.WriteLine();
                    Console.WriteLine($"\t{lowerCaseString}");
                    Console.WriteLine();
                }
                else if (choice == "4")
                {
                    return;
                }
                else { Console.WriteLine("Bad Input!"); }
            }
        }
    }
}

