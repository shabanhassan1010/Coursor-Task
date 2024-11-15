namespace Coursor
{
    internal class Program
    {
        static void Main()
        {
            int position = 1;
            bool running = true;
            ConsoleKey key;

            while (running)
            {
                Console.Clear(); // Clear the screen every time
                ExecuteMyOperations(position);

                // Wait for user input
                key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.Enter) // Enter key
                {
                    switch (position)
                    {
                        case 1:
                            PrintSum();
                            break;
                        case 2:
                            PrintMultiply();
                            break;
                        case 3:
                            PrintDivide();
                            break;
                        case 4:
                            running = ExitProgram();
                            break;
                    }
                    if (running)
                    {
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey(true);
                    }
                }
                else if (key == ConsoleKey.UpArrow) // Up arrow key
                {
                    position--;
                    if (position < 1)
                        position = 4;
                }
                else if (key == ConsoleKey.DownArrow) // Down arrow key
                {
                    position++;
                    if (position > 4)
                        position = 1;
                }
            }
        }

        static void ExecuteMyOperations(int currentSelection)
        {
            Console.WriteLine($"{(currentSelection == 1 ? ">>> " : "    ")}1. Sum");
            Console.WriteLine($"{(currentSelection == 2 ? ">>> " : "    ")}2. Multiply");
            Console.WriteLine($"{(currentSelection == 3 ? ">>> " : "    ")}3. Divide");
            Console.WriteLine($"{(currentSelection == 4 ? ">>> " : "    ")}4. Exit");
        }
        static void PrintSum()
        {
            Console.WriteLine("You selected Sum.");
            Console.Write("Enter two numbers: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int res = num1 + num2;
            Console.WriteLine($"Result: {res}");
        }
        static void PrintMultiply()
        {
            Console.WriteLine("You selected Multiply.");
            Console.Write("Enter two numbers: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int res = num1 * num2;
            Console.WriteLine($"Result: {res}");
        }
        static void PrintDivide()
        {
            Console.WriteLine("You selected Divide.");
            Console.Write("Enter two numbers: ");
            int num1 = int.Parse(Console.ReadLine());
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
        static bool ExitProgram()
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
