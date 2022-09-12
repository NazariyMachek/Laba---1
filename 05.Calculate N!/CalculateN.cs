
using System;

class CalculateN
{
    static void Main()
    {
        int fact = 1, n = Convert.ToInt32(Console.ReadLine());

        for (int i = 2; i <= n; i++)
        {
            fact = fact * i;
        }

        Console.WriteLine(fact);
    }
}
