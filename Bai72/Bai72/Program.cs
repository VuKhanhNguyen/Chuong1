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

        static int giaithua(int n_118)
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



        static void Main(string[] args)
        {

        }
    }
}
