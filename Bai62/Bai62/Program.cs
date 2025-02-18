using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai62
{
    internal class Program
    {
        //Bài 62: Cho 2 số nguyên dương a và b.Hãy tìm ước chung lớn nhất của 2 số này.
        static int ucln(int a_118, int b_118)
        {
            if (a_118 == 0 || b_118 == 0)
            {
                return a_118 + b_118;

            }
            while (a_118 != b_118)
            {
                if (a_118 > b_118)
                {
                    a_118 = a_118 - b_118;
                }
                else
                {
                    b_118 = b_118 - a_118;
                }
            }
            return a_118;
        }

        static void Main(string[] args)
        {

        }
    }
}
