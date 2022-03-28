using System;

namespace HarmonicTerm;
class Program
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        double h = 1;

        for (float i=2;i<=n;i++)
        {
            h = h + 1 / i;

            Console.WriteLine(h);
        }
    }
}