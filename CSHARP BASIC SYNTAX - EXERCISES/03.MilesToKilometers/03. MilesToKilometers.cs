using System;

class MilesToKilometers
{
    static void Main()
    {
        double miles = double.Parse(Console.ReadLine());
        double resultKM = miles * 1.60934;

        Console.WriteLine("{0:f2}",resultKM);
    }
}
