internal class Program
{
    public static void ToPower(long num1, long num2)
    {
        long result = num1 ^ num2;
        Console.WriteLine($"\n{num1} ^ {num2} = {result}");
    }

    public static void Add(long num1, long num2)
    {
        long result = num1 + num2;
        Console.WriteLine($"\n{num1} + {num2} = {result}");
    }

    public static void Multiply(long num1, long num2)
    {
        long result = num1 * num2;
        Console.WriteLine($"\n{num1} * {num2} = {result}");
    }

    public static void Divide(long num1, long num2)
    {
        double result = num1 / num2;
        Console.WriteLine($"\n{num1} / {num2} = {result}");
    }

    public static void Subtract(long num1, long num2)
    {
        long result = num1 - num2;
        Console.WriteLine($"\n{num1} - {num2} = {result}");
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to my calculator!\n");
        Console.WriteLine("(* for multiplication) (/ for division) (+ for addition) (- for subtraction) (^ for to power)");
        Console.Write("What operation would you like to carry out?: ");
        var userOpInput = Console.ReadLine();

        if (userOpInput == "/")
        {
            Console.Write("\nPlease enter your first number: ");
            var userNum1 = Console.ReadLine();

            bool tryParse = int.TryParse(userNum1, out int num1);
            
            if (tryParse)
            {
                Console.Write("\nPlease enter your second number: ");
                var userNum2 = Console.ReadLine();

                bool tryParse1 = int.TryParse(userNum2, out int num2);

                if (tryParse1)
                {
                    Divide(num1, num2);
                }
                else
                {
                    Console.WriteLine("\nPlease enter a valid integer.");
                }
            }
            else
            {
                Console.WriteLine("\nPlease enter a valid integer.");
            }
        }

        else if (userOpInput == "+")
        {
            Console.Write("\nPlease enter your first number: ");
            var userNum1 = Console.ReadLine();

            bool tryParse = int.TryParse(userNum1, out int num1);

            if (tryParse)
            {
                Console.Write("\nPlease enter your second number: ");
                var userNum2 = Console.ReadLine();

                bool tryParse1 = int.TryParse(userNum2, out int num2);

                if (tryParse1)
                {
                    Add(num1, num2);
                }
                else
                {
                    Console.WriteLine("\nPlease enter a valid integer.");
                }
            }
            else
            {
                Console.WriteLine("\nPlease enter a valid integer.");
            }
        }

        else if (userOpInput == "-")
        {
            Console.Write("\nPlease enter your first number: ");
            var userNum1 = Console.ReadLine();

            bool tryParse = int.TryParse(userNum1, out int num1);

            if (tryParse)
            {
                Console.Write("\nPlease enter your second number: ");
                var userNum2 = Console.ReadLine();

                bool tryParse1 = int.TryParse(userNum2, out int num2);

                if (tryParse1)
                {
                    Subtract(num1, num2);
                }
                else
                {
                    Console.WriteLine("\nPlease enter a valid integer.");
                }
            }
            else
            {
                Console.WriteLine("\nPlease enter a valid integer.");
            }
        }

        else if (userOpInput == "*")
        {
            Console.Write("\nPlease enter your first number: ");
            var userNum1 = Console.ReadLine();

            bool tryParse = int.TryParse(userNum1, out int num1);

            if (tryParse)
            {
                Console.Write("\nPlease enter your second number: ");
                var userNum2 = Console.ReadLine();

                bool tryParse1 = int.TryParse(userNum2, out int num2);

                if (tryParse1)
                {
                    Multiply(num1, num2);
                }
                else
                {
                    Console.WriteLine("\nPlease enter a valid integer.");
                }
            }
            else
            {
                Console.WriteLine("\nPlease enter a valid integer.");
            }
        }

        else if (userOpInput == "^")
        {
            Console.Write("\nPlease enter your first number: ");
            var userNum1 = Console.ReadLine();

            bool tryParse = int.TryParse(userNum1, out int num1);

            if (tryParse)
            {
                Console.Write("\nPlease enter your second number: ");
                var userNum2 = Console.ReadLine();

                bool tryParse1 = int.TryParse(userNum2, out int num2);

                if (tryParse1)
                {
                    ToPower(num1, num2);
                }
                else
                {
                    Console.WriteLine("\nPlease enter a valid integer.");
                }
            }
            else
            {
                Console.WriteLine("\nPlease enter a valid integer.");
            }
        }

        else
        {
            Console.WriteLine("\nPlease enter a valid operation.");
            return;
        }
    }
}
