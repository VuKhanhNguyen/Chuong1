using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai22
{
    internal class Program
    {

        static int TichCacUocSo(int n_118)
        {
            int uoc_118 = 1;
            Console.Write("Cac uoc: ");
            for (int i_118 = 1;i_118 <= n_118; i_118++)
            {
                if(n_118 % i_118 == 0)
                {
                    Console.Write(i_118 + " ");
                    uoc_118 *= i_118;
                }
                
            }
            return uoc_118;
        }

        static int TichCacUocSo2(int n_118)
        {
            int tich_118 = 1;
            Console.Write("Cac uoc: ");
            for (int i_118 = 1; i_118 <= Math.Sqrt(n_118); i_118++)
            {
                if (n_118 % i_118 == 0)
                {
                    Console.Write(i_118 + " ");
                    tich_118 *= i_118;

                    // Nếu i và n/i không giống nhau thì tính thêm ước n/i
                    if (i_118 != n_118 / i_118)
                    {
                        Console.Write((n_118 / i_118) + " ");
                        tich_118 *= (n_118 / i_118);
                    }
                }
            }
            return tich_118;
        }

        static void Main(string[] args)
        {
            int n_118;
            do
            {
                Console.Write("Nhap n: ");
                n_118 = int.Parse(Console.ReadLine());
                if(n_118 <= 0)
                {
                    Console.WriteLine("\nNhap n phai lon hon 0, moi nhap lai ! ");

                }

            }while (n_118<=0);

            int t_118 = TichCacUocSo(n_118);

            Console.WriteLine("\nTich cac uoc cua {0} la: {1}", n_118, t_118);

            int t2_188 = TichCacUocSo2(n_118);

            Console.WriteLine("Tich cac uoc cua {0} la: {1}", n_118, t2_188);

            Console.ReadKey();
        }
    }
}
