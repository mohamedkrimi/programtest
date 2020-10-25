using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            System.Console.Write("Entrez un nombre x = ");
            x = Double.Parse(System.Console.ReadLine());
            if (x < 0) System.Console.WriteLine("|x| = " + (-x));
            else System.Console.WriteLine("|x| = " + x);
        }
    }
}
