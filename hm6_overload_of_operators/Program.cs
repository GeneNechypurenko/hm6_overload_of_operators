using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm6_overload_of_operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Magazine m1 = new Magazine(20);
            Magazine m2 = new Magazine(30);

            m1 += m2;
            Console.WriteLine(m1);

            m2 += 10;
            Console.WriteLine(m2);

            m1 -= m2;
            Console.WriteLine(m1);

            m2 -= 5;
            Console.WriteLine(m2);

            if (m1 == m2)
            {
                Console.WriteLine($"{m1} == {m2}");
            }
            else
            {
                Console.WriteLine($"{m1} != {m2}");
            }

            if (m1 < m2)
            {
                Console.WriteLine($"{m1} < {m2}");
            }
            else
            {
                Console.WriteLine($"{m1} > {m2}");
            }
        }
    }
}
