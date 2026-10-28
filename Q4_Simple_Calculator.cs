using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Class ID: 66457 | Registration ID: EDIT_REGISTRATION_ID | Name: MUHAMMAD AHMED | Submission Date: 29-10-2026");

        Console.Write("Enter first number: ");
        if (!double.TryParse(Console.ReadLine(), out double num1))
        {
            Console.WriteLine("Invalid number");
            return;
        }

        Console.Write("Enter second number: ");
        if (!double.TryParse(Console.ReadLine(), out double num2))
        {
            Console.WriteLine("Invalid number");
            return;
        }

        Console.Write("Enter operator (+, -, *, /): ");
        string input = Console.ReadLine() ?? "";
        if (input.Length != 1)
        {
            Console.WriteLine("Invalid operator");
            return;
        }

        switch (input[0])
        {
            case '+': Console.WriteLine("Result: " + (num1 + num2)); break;
            case '-': Console.WriteLine("Result: " + (num1 - num2)); break;
            case '*': Console.WriteLine("Result: " + (num1 * num2)); break;
            case '/':
                if (num2 != 0)
                    Console.WriteLine("Result: " + (num1 / num2));
                else
                    Console.WriteLine("Error: Cannot divide by zero.");
                break;
            default: Console.WriteLine("Invalid operator"); break;
        }
    }
}
