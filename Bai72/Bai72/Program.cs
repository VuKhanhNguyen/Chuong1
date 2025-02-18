using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai72
{
    //Bài 72: Tính S(x, n) = – x + x^2/2! – x^3/3! + … + (-1)^n * x^n/n!
    internal class Program
    {

        static double giaithua(int n_118)
        {
            if (n_118==0)
            {
                return 1;
            }
            else
            {
               return n_118 * giaithua(n_118-1);
            }
        }

        static double tong(double x_118, int n_118)
        {
            
            if (n_118 == 1)
            {
                return -x_118;
            }
            else
            {
                return ((Math.Pow(-1, n_118) * Math.Pow(x_118, n_118) / giaithua(n_118))) + tong(x_118, n_118 - 1);
            }

        }

        static void Main(string[] args)
        {
            int x_118;
            int n_118;
            Console.Write("Nhap x: ");
            x_118 = int.Parse(Console.ReadLine());
            Console.Write("Nhap n: ");
            n_118 = int.Parse(Console.ReadLine());
 
            double ketqua_118 = tong(x_118, n_118);
            Console.Write("Ket qua la: {0}", ketqua_118);
        }
    }
}
