using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai82
{
    internal class Program
    {
        //Bài 82: Viết chương trình tìm số lớn nhất trong 3 số thực a, b, c

        static void SoLonNhat(double a_118, double b_118, double c_118)
        {
            double max_118;
            if (a_118 > c_118)
            {
                if (a_118 > b_118)
                {
                    max_118 = a_118;
                    Console.Write("So lon nhat la: {0}", a_118);
                }
                else
                {
                    max_118 = b_118;
                    Console.Write("So lon nhat la: {0}", b_118);
                }
            }
            else
            {
                max_118 = c_118;
                Console.Write("So lon nhat la: {0}", c_118);
            }


        }

        static void Main(string[] args)
        {
            int a_118, b_118, c_118;
            Console.WriteLine("Nhap so thu 1: ");
            a_118 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so thu 2: ");
            b_118 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so thu 3: ");
            c_118 = Convert.ToInt32(Console.ReadLine());
            SoLonNhat(a_118, b_118, c_118);
            
        }
    }
}
