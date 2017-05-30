using System;

class BeverageLabels
{
    static void Main()
    {
        string name = Console.ReadLine();
        int volume = int.Parse(Console.ReadLine());
        int energyPer100ml = int.Parse(Console.ReadLine());
        int sugarPer100ml = int.Parse(Console.ReadLine());

        var energy = (volume * energyPer100ml)/100.0;
        var sugar = (volume * sugarPer100ml)/100.0;

        Console.WriteLine("{0}ml {1}:\n{2}kcal, {3}g sugars", volume, name, energy, sugar);
    }
}
