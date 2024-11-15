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
                My_Functions.ExecuteMyOperations(position);

                // Wait for user input
                key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.Enter) // Enter key
                {
                    switch (position)
                    {
                        case 1:
                            My_Functions.PrintSum();
                            break;
                        case 2:
                            My_Functions.PrintMultiply();
                            break;
                        case 3:
                            My_Functions.PrintDivide();
                            break;
                        case 4:
                            running = My_Functions.ExitProgram();
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
    }
}
