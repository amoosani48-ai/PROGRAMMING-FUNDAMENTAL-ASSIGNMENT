using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Class ID: 66457 | Registration ID: EDIT_REGISTRATION_ID | Name: MUHAMMAD AHMED | Submission Date: 29-10-2026");

        Console.Write("Enter purchase amount: ");
        if (!double.TryParse(Console.ReadLine(), out double amount) || amount < 0)
        {
            Console.WriteLine("Invalid purchase amount");
            return;
        }

        double percentage = 0;
        if (amount >= 5000)
            percentage = 20;
        else if (amount >= 2000)
            percentage = 10;

        double discount = amount * percentage / 100;
        double payable = amount - discount;

        Console.WriteLine("Discount Percentage: " + percentage + "%");
        Console.WriteLine("Discount Amount: Rs. " + discount.ToString("0.00"));
        Console.WriteLine("Final Payable Amount: Rs. " + payable.ToString("0.00"));
    }
}
