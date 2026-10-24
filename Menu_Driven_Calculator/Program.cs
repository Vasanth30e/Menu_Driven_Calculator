namespace Menu_Driven_Calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Calculator");
            Console.Write("Enter First Number: ");

            if (decimal.TryParse(Console.ReadLine(), out decimal firstNumber))
            {
                Console.WriteLine("First Number: " + firstNumber);
            }
            else
            {
                Console.WriteLine("Invalid Input");
                return;
            }

            Console.Write("Enter Second Number: ");

            if (decimal.TryParse(Console.ReadLine(), out decimal secondNumber))
            {
                Console.WriteLine("Second Number: " + secondNumber);
            }
            else
            {
                Console.WriteLine("Invalid Input");
                return;
            }

            if(Calculator(firstNumber, secondNumber))
            {
                Console.WriteLine("Arithmetic operation complete!");
            }
            else
            {
                Console.WriteLine("Arithmetic operation failed!!");
            }
            
        }

        public static bool Calculator(decimal x, decimal y)
        {
            Console.WriteLine("\n1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\nEnter the opertion to perform: ");
            if(int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        decimal add = x + y;
                        Console.WriteLine($"Addition of {x} and {y} is " + add.ToString("F2"));
                        return true;
                    case 2:
                        decimal sub = x - y;
                        Console.WriteLine($"Subtraction of {x} and {y} is " + sub.ToString("F2"));
                        return true;
                    case 3:
                        decimal mul = x * y;
                        Console.WriteLine($"Multiplication of {x} and {y} is "+ mul.ToString("F2"));
                        return true;
                    case 4:

                        if (y == 0)
                        {
                            Console.WriteLine("Cannot divide by Zero");
                            return false;
                        }

                        decimal div = x / y;

                        Console.WriteLine($"Division of {x} and {y} is " + div.ToString("F2"));
                        return true;
                    default:
                        Console.WriteLine("Please enter the choice between 1 to 4");
                        return false;
                }
            }
            else
            {
                Console.WriteLine("Please enter numeric value");
                return false;
            }
        }
    }
}