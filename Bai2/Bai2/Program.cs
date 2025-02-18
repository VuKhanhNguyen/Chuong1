using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        static void TongChuoi(int n_118)
        {
            int sum_118 = (n_118 * (n_118 + 1) * (2 * n_118 + 1)) / 6;

            Console.Write("Tong chuoi: ");
            for (int i_118 = 1; i_118 <= n_118; i_118++)
            {
                if (i_118 != n_118)
                    Console.Write("{0}^2 + ", i_118);
                else
                    Console.Write("{0}^2 = {1} ", i_118, sum_118);
            }
        }


        static void Main(string[] args)
        {
            Console.Write("\nNhap n: ");
            int n_118 = int.Parse(Console.ReadLine());

            TongChuoi(n_118);

        }
    }
}
