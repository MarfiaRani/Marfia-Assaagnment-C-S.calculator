using System;

class Calculator
{
    static void Main()
    {
        bool continueCalculating = true;

        while (continueCalculating)
        {
            Console.WriteLine("Choose calculator type:");
            Console.WriteLine("1. Scientific Calculator");
            Console.WriteLine("2. Normal Calculator");
         
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ScientificCalculator();
                    break;
                case 2:
                    NormalCalculator();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine("Do you want to perform another calculation? (Y/N)");
            char continueChoice = char.Parse(Console.ReadLine());
            if (continueChoice != 'Y' && continueChoice != 'y')
            {
                continueCalculating = false;
            }
        }
    }
    // Scientific calculator

    static void ScientificCalculator()
    {
        Console.WriteLine("Enter a number:");
        double num = double.Parse(Console.ReadLine());

        Console.WriteLine("Choose operation:");
        Console.WriteLine("1. Exponentiation");
        Console.WriteLine("2. Square Root");
        Console.WriteLine("3. Logarithm (base 10)");
        Console.WriteLine("4. Sine");
        Console.WriteLine("5. Cosine");
        Console.WriteLine("6. Tangent");
        int operation = int.Parse(Console.ReadLine());

        switch (operation)
        {
            case 1:
                Console.WriteLine("Enter the exponent:");
                double exponent = double.Parse(Console.ReadLine());
                Console.WriteLine($"Result: {Math.Pow(num, exponent)}");
                break;
            case 2:
                Console.WriteLine($"Result: {Math.Sqrt(num)}");
                break;
            case 3:
                if (num > 0)
                {
                    Console.WriteLine($"Result: {Math.Log10(num)}");
                }
                else
                {
                    Console.WriteLine("Error: Logarithm of a non-positive number.");
                }
                break;
            case 4:
                Console.WriteLine($"Result: {Math.Sin(num)}");
                break;
            case 5:
                Console.WriteLine($"Result: {Math.Cos(num)}");
                break;
            case 6:
                Console.WriteLine($"Result: {Math.Tan(num)}");
                break;
            default:
                Console.WriteLine("Invalid operation. Please try again.");
                break;
        }

        //normal calculator

        static void NormalCalculator()
        {
            Console.WriteLine("Enter first number:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Choose operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            int operation = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case 1:
                    Console.WriteLine($"Result: {num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine($"Result: {num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine($"Result: {num1 * num2}");
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        Console.WriteLine($"Result: {num1 / num2}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation. Please try again.");
                    break;
            }
        }
    }
}
