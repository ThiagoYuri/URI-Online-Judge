using System;

namespace _1005___Average_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());

            Console.WriteLine("MEDIA = "+(((3.5/ A)+(7.5/ B)/2)).ToString("F5"));
            Console.ReadKey();
        }
    }
}
