using System;

class DebitCardNumber
{
    static void Main()
    {
        int digit1 = int.Parse(Console.ReadLine());
        int digit2 = int.Parse(Console.ReadLine());
        int digit3 = int.Parse(Console.ReadLine());
        int digit4 = int.Parse(Console.ReadLine());

        Console.WriteLine("{0:D4} {1:D4} {2:D4} {3:D4}", digit1, digit2, digit3, digit4);
    }
}
