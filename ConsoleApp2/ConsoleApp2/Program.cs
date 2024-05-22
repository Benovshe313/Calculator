using System.Runtime;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first value:");
            float a = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter operator:");
            string? option = Console.ReadLine();

            Console.WriteLine("Enter second value:");
            float b = Convert.ToSingle(Console.ReadLine());

            float result = 0;
            bool possibleCondition = true;

            switch (option)
            {
                case "+":
                    result = AddFunc(a, b);
                    break;
                case "-":
                    result = SubtractFunc(a, b);
                    break;
                case "*":
                    result = MultiplyFunc(a, b);
                    break; 
                case "/":
                    if (b == 0)
                    {
                        Console.WriteLine("Cannot divide by zero");
                        possibleCondition = false;
                    }
                    else
                    {
                        result = DivisionFunc(a, b);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator entered");
                    possibleCondition = false;
                    break;
            }
            if (possibleCondition)
            {
                Console.WriteLine($"Result: {result}");
            }
        }

        static float AddFunc(float a, float b)
        {
            return a + b;
        }

        static float SubtractFunc(float a, float b)
        {
            return a - b;
        }

        static float MultiplyFunc(float a, float b)
        {
            return a * b;
        }

        static float DivisionFunc(float a, float b)
        {
            return a / b;
        }

    }
}
