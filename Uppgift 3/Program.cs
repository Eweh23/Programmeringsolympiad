using System;

namespace Uppgift_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Antal med grönt kort?");
            int M =int.Parse(Console.ReadLine());
            Console.WriteLine("Antal utan grönt kort?");
            int N =int.Parse(Console.ReadLine());
            int Tid=10*(N/M+ 2*M/M); 
            Console.WriteLine(Tid);
        }
    }
}
