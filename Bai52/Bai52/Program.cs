using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai52
{
    internal class Program
    {

        static int MinNguyenDuong(int n_118)
        {
            int min_118;
            int i_118;
            min_118 = n_118 % 10;
            if(n_118 == 0)
                min_118 = 0;
            while (n_118 > 0)
            {
                i_118 = n_118 % 10;
                 if (i_118 < min_118)
                   {
                    min_118 = i_118;
                  }
                n_118 /= 10;
            }
            

            return min_118;     
          
        }

        static void Main(string[] args)
        {
            int n_118;
            do
            {
                Console.WriteLine("Nhap n: ");
                n_118 = int.Parse(Console.ReadLine());
                if (n_118 <= 0)
                {
                    Console.WriteLine("Nhap so >0 !");

                }
                else
                {

                    int min_118=MinNguyenDuong(n_118);
                    Console.WriteLine("Chu so nho nhat la {0} ", min_118);
                    break;
                }
            } while (n_118 <= 0);
        }
    }
}
