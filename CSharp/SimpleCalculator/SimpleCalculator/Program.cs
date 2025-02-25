namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to SimpleCalculator!");
            bool status = true;
           
            while (status)
            {
                int result = 0;
                Console.WriteLine("Please, enter your first number:");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please, enter your second number:");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please select an operation:");
                Console.WriteLine("a for +");
                Console.WriteLine("s for -");
                Console.WriteLine("m for *");
                Console.WriteLine("d for /");
                string operation = Console.ReadLine();

                if (operation == "a")
                {
                    result = num1 + num2;
                }
                else if (operation == "s")
                {
                    result = num1 - num2;
                }
                else if (operation == "m")
                {
                    result = num1 * num2;
                }
                else
                {
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Cannot devide to Zero!");
                    }
                }
                Console.WriteLine("The result is equal to " + result);

                Console.WriteLine("Do you wanna continue?");
                Console.WriteLine("Y - yes");
                Console.WriteLine("N - no");
                string userAnswer = Console.ReadLine();
                if (userAnswer == "N")
                {
                    status = false;
                }
            }
        }
    }
}
