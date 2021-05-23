using System;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            SizeDemo sd = new SizeDemo();
            sd.PrintSizeOf();
            int[] a = new int[] { 1, 2, 3, 4 };
            DateTime dt = DateTime.Now;
            string s = "Hello World!";
            Console.WriteLine(sizeof(byte));
            Console.WriteLine(sizeof(short));
            Console.WriteLine(sizeof(int));
            Console.WriteLine(sizeof(long));
            Console.WriteLine(sizeof(float));
            Console.WriteLine(sizeof(double));
            Console.WriteLine(sizeof(decimal));
            unsafe
            {
                fixed (int* p = &a[0])
                {
                    System.Console.WriteLine(a[0]);

                    Console.WriteLine((int)p);
                    *p = 5;
                    System.Console.WriteLine(a[0]);
                }
                fixed (int* p1 = &a[1])
                {
                    Console.WriteLine((int)p1);
                }
                fixed (int* p2 = &a[2])
                {
                    Console.WriteLine((int)p2);
                }
                int i = s.GetHashCode();
                System.Console.WriteLine(dt.GetHashCode());
                s = "new text";
                System.Console.WriteLine(s.GetHashCode());
                System.Console.WriteLine(i);
                Console.WriteLine(sizeof(DateTime));

            }
        }
    }
}
