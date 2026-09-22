using System;

namespace _3._3.Логические_операторы
{
    internal class Program
    {
        static bool Foo()
        {
            Console.WriteLine("Foo вызван");
            return true;
        }

        static void Main(string[] args)
        {

            //bool res = !true || false && true;
            //Console.WriteLine($"{res}");


            //bool res = false && Foo();
            //Console.WriteLine($"{res}");


            //bool res = false & Foo();
            //Console.WriteLine($"{res}");


            //bool res = true ^ false ^ true;
            //Console.WriteLine($"{res}");


            //bool res = !(5 > 2 || 3 < 1);
            //Console.WriteLine($"{res}");


            //bool a = true, b = false;
            //bool res = a && !b || b && !a;
            //Console.WriteLine($"{res}");


            //int x = 5;
            //bool res = true || (x / 0 == 1);
            //Console.WriteLine($"{res}");

            //int zero = 0;
            //bool res = false & (10 / zero == 1);
            //Console.WriteLine($"{res}");


            //bool A = true, B = false;
            //bool deMorgan1 = !(A && B);
            //bool deMorgan1Equivalent = !A || !B;
            //Console.WriteLine($"{deMorgan1}, {deMorgan1Equivalent}");


            //bool A = true, B = false;
            //bool deMorgan2 = !(A || B);
            //bool deMorgan2Equivalent = !A && !B;
            //Console.WriteLine($"{deMorgan2}, {deMorgan2Equivalent}");
        }
    }
}
