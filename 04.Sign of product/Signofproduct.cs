
using System;
using System.Globalization;
class Signofproduct
{
    static void Main()
    {
        NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
        {
            NumberDecimalSeparator = ".",
        };

        float a = float.Parse(Console.ReadLine(), numberFormatInfo);
        float b = float.Parse(Console.ReadLine(), numberFormatInfo);
        float c = float.Parse(Console.ReadLine(), numberFormatInfo);

        if ((a > 0) && (b > 0) && (c > 0))
        {
            Console.WriteLine("positive");
        }
        else if ((a < 0) && (b < 0) || (b < 0) && (c < 0) || (a < 0) && (c < 0))
        {
            Console.WriteLine("positive");
        }
        else
        {
            Console.WriteLine("negative");
        }
    }
}
