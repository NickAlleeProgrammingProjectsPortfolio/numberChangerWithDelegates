using System;

namespace numberChangerWithDelegates
{
    class numberChanger
    {
        static int num = 10;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            theNumberChanger sol = new theNumberChanger(add);
            Console.WriteLine(sol(2));
            theNumberChanger subtracting = new theNumberChanger(sub);
            Console.WriteLine(subtracting(8));
            theNumberChanger multiplying = new theNumberChanger(mult);
            Console.WriteLine(multiplying(2));
        }

        public static int add(int n)
        {
            num = n +num;
            return num;
        }

        public static int sub(int n)
        {
            num = num - n;
            return num;
        }

        public static int mult(int n)
        {
            num = n * num;
            return num;
        }

        public static int div(int n)
        {
            num = n / num;
            return num;
        }

        public delegate int theNumberChanger(int number);

    }
}
