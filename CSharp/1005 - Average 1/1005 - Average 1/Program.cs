using System;

namespace _1005___Average_1
{
    class Program
    {
        static void Main(string[] args)
        {
            float A = float.Parse(Console.ReadLine());
            float B = float.Parse(Console.ReadLine());

            Console.WriteLine("MEDIA = "+(((A/3.5)+(B/7.5))).ToString("F5"));

        }
    }
}
