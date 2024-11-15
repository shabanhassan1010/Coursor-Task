
namespace Coursor
{
    public static class My_Functions
    {
        public static void ExecuteMyOperations(int currentSelection)
        {
            Console.WriteLine($"{(currentSelection == 1 ? ">>> " : "    ")}1. Sum");
            Console.WriteLine($"{(currentSelection == 2 ? ">>> " : "    ")}2. Multiply");
            Console.WriteLine($"{(currentSelection == 3 ? ">>> " : "    ")}3. Divide");
            Console.WriteLine($"{(currentSelection == 4 ? ">>> " : "    ")}4. Exit");
        }
        public static void PrintSum()
        {
            Console.WriteLine("You selected Sum.");
            Console.Write("Enter Number One: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Number Two: ");
            int num2 = int.Parse(Console.ReadLine());
            int res = num1 + num2;
            Console.WriteLine($"Result: {res}");
        }
        public static void PrintMultiply()
        {
            Console.WriteLine("You selected Multiply.");
            Console.Write("Enter two numbers: ");
            Console.Write("Enter Number One: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Number Two: ");
            int num2 = int.Parse(Console.ReadLine());
            int res = num1 * num2;
            Console.WriteLine($"Result: {res}");
        }
        public static void PrintDivide()
        {
            Console.WriteLine("You selected Divide.");
            Console.Write("Enter two numbers: ");
            Console.Write("Enter Number One: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Number Two: ");
            int num2 = int.Parse(Console.ReadLine());
            if (num2 == 0)
            {
                Console.WriteLine("Cannot divide by zero.");
            }
            else
            {
                int res = num1 / num2;
                Console.WriteLine($"Result: {res}");
            }
        }
        public static bool ExitProgram()
        {
            Console.Write("Are you sure you want to exit? (y/n): ");
            char confirmExit = Console.ReadKey(true).KeyChar;
            if (confirmExit == 'y' || confirmExit == 'Y')
            {
                Console.WriteLine("\nExiting...");
                return false; // Stop the program
            }
            else
            {
                Console.WriteLine("\nExit canceled. Returning to menu...");
                return true; // Continue the program
            }
        }
    }
}
