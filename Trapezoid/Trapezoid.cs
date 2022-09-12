
using System;
using System.Globalization;
class Trapezoid
{
    static void Main()
    {
        NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
        {
            NumberDecimalSeparator = ".",
        };

        float a = float.Parse(Console.ReadLine(), numberFormatInfo);
        float b = float.Parse(Console.ReadLine(), numberFormatInfo);
        int h = int.Parse(Console.ReadLine());

        float area = ((a + b)/2) * h;

        Console.WriteLine(area);

    }
}
