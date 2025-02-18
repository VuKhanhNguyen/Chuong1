using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai32
{
    internal class Program
    {

        static void LaSoChinhPhuong(int n_118)
        {
            int scp_118 = (int)Math.Sqrt(n_118);
            if (scp_118 * scp_118 == n_118)
            {
                Console.WriteLine("{0} la so chinh phuong", n_118);
            }
            else
            {
                Console.WriteLine("{0} khong phai la so chinh phuong", n_118);
            }
        }

        static void Main(string[] args)
        {
            int n_118;

            do
            {
                
                Console.Write("\nNhap n: ");
                n_118 = int.Parse(Console.ReadLine());
                if (n_118 <= 0)
                {
                    Console.WriteLine("Nhap so lon hon 0!! ");
                    //Console.Write("\nNhap n: ");
                    //n_118 = int.Parse(Console.ReadLine());
                }
                else
                {
                    LaSoChinhPhuong(n_118);
                }

            } while (n_118 <= 0);


        }
    }
}
