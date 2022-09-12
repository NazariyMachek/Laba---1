
using System;
using System.Threading;

class NDigit
{
    static void Main()
    {
        int n, number, nDigit;

        number = int.Parse(Console.ReadLine());
        n = int.Parse(Console.ReadLine());

        nDigit = (number / Convert.ToInt32(Math.Pow(10,n-1))) % 10;

        if (nDigit > 0)
        {
            Console.WriteLine(nDigit);
        }
        else
        {
            Console.WriteLine("-");
        }
    }
}
