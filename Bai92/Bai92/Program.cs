using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bai92
{
    internal class Program
    {

        static int UCLN(int a_118, int b_118)
        {
            if(a_118 == b_118)
                return a_118;
            while (b_118 != 0)
            {
                int r = a_118 % b_118;
                a_118 = b_118;
                b_118 = r;
            }
            return a_118;
        }
        
        static void Main(string[] args)
        {
           
            int a_118;
            int b_118;
            do
            {
            Console.Write("Nhap a: ");
            a_118 = int.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            b_118 = int.Parse(Console.ReadLine());

                if (a_118 <= 0 || b_118 <= 0)
                {
                    Console.WriteLine("So nhap vao phai > 0 !");
                }


            } while (a_118 <= 0 || b_118 <= 0);

            int ketqua_118 = UCLN(a_118, b_118);
            Console.Write("UCLN cua {0} voi {1} la {2}", a_118, b_118, ketqua_118);
        }
    }
}
