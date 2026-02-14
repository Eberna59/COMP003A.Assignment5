namespace COMP003A.Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continueProgram = true;

            while (continueProgram)
            {
                ShowGreeting();

                Console.Write("Enter your name: ");
                string personName = Console.ReadLine();

                Console.Write("Enter a whole number: ");
                int userNumber = int.Parse(Console.ReadLine());

                DisplayEntry(personName, userNumber); // pass values using parameters

                int processedValue = ModifyNumber(userNumber); // store returned value

                Console.WriteLine("Calculated result: " + processedValue);

                if (processedValue >= 20) // decision making using returned values
                {
                    Console.WriteLine("The result is 20 or more");
                }
                else
                {
                    Console.WriteLine("The result is less than 20");
                }

                Console.WriteLine("\nWould you like to try again? (y/n: )");
                string response = Console.ReadLine();

                if (response.ToLower() != "y")
                {
                    continueProgram = false;
                }

                Console.WriteLine();
            }

            Console.WriteLine("Program finished.");

        }

        static void ShowGreeting() // intro message display
        {
            Console.WriteLine("Welcome to the Number Mod Program");
            Console.WriteLine();
        }

        static void DisplayEntry(string name, int number) // gets data from main using parameters
        {
            Console.WriteLine("\nHello " + name + ", you entered: " + number);
        }

        static int ModifyNumber(int value) // performs calculation and returns result to main
        {
            int updated = value * 2;
            return updated;
        }
    }
}
