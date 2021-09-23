

namespace _1002___Area_of_a_Circle
{
    class Program
    {
        static void Main(string[] args)
        {



            double R = double.Parse(System.Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

            System.Console.WriteLine("A="+(3.14159 * (R*R)).ToString("F4", System.Globalization.CultureInfo.InvariantCulture));


        }
    }
}
