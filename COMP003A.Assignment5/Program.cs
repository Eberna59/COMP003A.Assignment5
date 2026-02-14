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

                DisplayEntry(personName, userNumber);

                int processedValue = ModifyNumber(userNumber);

                Console.WriteLine("Calculated result: " + processedValue);

                if (processedValue >= 20)
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

        static void ShowGreeting()
        {
            Console.WriteLine("Welcome to the Number Mod Program");
            Console.WriteLine();
        }
    }
}
