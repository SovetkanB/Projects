namespace SimpleCalculatorWithSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to the Simple Calculator with Switch statement!");

            bool status = true;

            while (status)
            {
                double result = 0;

                Console.Write("Please select your first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Please select your second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please select an operation: ");
                Console.WriteLine("To close the Calculator type Enter.");
                ConsoleKey consoleKey = Console.ReadKey().Key;

                switch (consoleKey)
                {
                    case ConsoleKey.Multiply:
                        result = num1 * num2;
                        break;
                    case ConsoleKey.Add:
                        result = num1 + num2;
                        break;
                    case ConsoleKey.Subtract:
                        result = num1 - num2;
                        break;
                    case ConsoleKey.Divide:
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("Cannot devide to Zero!");
                        }
                        break;
                    case ConsoleKey.Enter:
                        status = false;
                        break;
                    default:
                        Console.WriteLine("Incorrect operation");
                        break;
                }
                Console.WriteLine("The result is equal to: " + result);
            }
        }
    }
}
