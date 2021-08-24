using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kill_K_th_Bit_CodeSignal_Core_Test17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input n given number");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Input k bit from the righ");
            int k = int.Parse(Console.ReadLine());
            int item = killKthBit(n, k);
            Console.WriteLine(item);
        }

        static int killKthBit(int n, int k)
        {
            return n & ~(1 << (k - 1));
        }

    }
}
