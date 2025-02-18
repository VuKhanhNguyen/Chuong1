using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai42
{
    internal class Program
    {

        static void MaxofNguyenDuong(int n_118)
        {
            int k_118 = 0;
            int S_118 = 0;
            while(k_118 < n_118)
            {
                k_118++;
                S_118 += k_118;

            }
            Console.WriteLine("Gia tri k lon nhat de S(k) < n la: {0}", k_118);

        }


        static void Main(string[] args)
        {
            int n_118;
            Console.WriteLine("Nhap n: ");
            n_118 = int.Parse(Console.ReadLine());
            MaxofNguyenDuong(n_118);
        }
    }
}
