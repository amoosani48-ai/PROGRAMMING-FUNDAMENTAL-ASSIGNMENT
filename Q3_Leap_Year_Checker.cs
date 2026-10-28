using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Class ID: 66457 | Registration ID: EDIT_REGISTRATION_ID | Name: MUHAMMAD AHMED | Submission Date: 29-10-2026");

        Console.Write("Enter year: ");
        if (!int.TryParse(Console.ReadLine(), out int year) || year <= 0)
        {
            Console.WriteLine("Invalid year");
            return;
        }

        if (year % 400 == 0)
            Console.WriteLine("Leap Year");
        else if (year % 100 == 0)
            Console.WriteLine("Not a Leap Year");
        else if (year % 4 == 0)
            Console.WriteLine("Leap Year");
        else
            Console.WriteLine("Not a Leap Year");
    }
}
