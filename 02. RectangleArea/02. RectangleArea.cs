using System;

class RectangleArea
{
    static void Main()
    {
        float width = float.Parse(Console.ReadLine());
        float height = float.Parse(Console.ReadLine());
        float result = width * height;

        Console.WriteLine("{0:f2}", result);
    }
}
