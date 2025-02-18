using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai12
{
    internal class Program
    {
        //static float TinhTongChuoi(float x_118 , int n_118)
        //{
        //    int i_118 = 1;
        //    float trc_118 = 1;
        //    float s_118 = 0;
        //    while (i_118 <= n_118)
        //    {
        //        trc_118 *= x_118;
        //        s_118 += trc_118;
        //        i_118++;
        //    }
        //    return s_118;
        //   //Console.WriteLine("Tong la: {0}", s);
        //}

        static float TongChuoiDeQuy(float x_118, int n_118)
        {
                return (float)Math.Pow(x_118, n_118) + TongChuoiDeQuy(x_118, n_118 - 1);  
        }


        static void Main(string[] args)
        {
            Console.Write("\nNhap x: ");
            float x_118 = float.Parse(Console.ReadLine());

            Console.Write("\nNhap n: ");
            int n_118 = int.Parse(Console.ReadLine());

            //float total_118 = TinhTongChuoi(x_118, n_118);

            try
            {
                float total_118 = TongChuoiDeQuy(x_118, n_118);
                Console.WriteLine("Tong la: {0}", total_118);
            }

            catch (StackOverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
