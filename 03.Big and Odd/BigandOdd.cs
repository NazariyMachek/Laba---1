
using System;
class BigandOdd
{
    static void Main()
    {
        int n;
        bool result;   

        n = int.Parse(Console.ReadLine());
        
        if ((n > 20) && (n % 2 != 0))
        {
            result = true;
            Console.WriteLine(result);
        }
        else
        {
            result=false;
            Console.WriteLine(result);
        }
    }
}