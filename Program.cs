// mohammad mousavi factorei!
using System.Diagnostics.Metrics;

namespace consoleApplication1
{
    class proggram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num:");
            int num = Convert.ToInt32(Console.ReadLine());
            int f = fact(num);
            Console.WriteLine("factoreil is :{0}", f);

        }
        static int fact(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            else
            {
                return num * fact(num - 1);
            }
        }
    }
}