using System;

namespace ValueTypeAndReferrenceType
{
    class Program
    {
        static void TestOut(out int value)

        {
            value = 0;
            value++;
        }
        static void TestRef(ref int value)

        {
            value++;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int x;
            x = 5;

            string str1;
            str1 = "Hello there";

            int a;
            a = 1;
            int b;
            b = a;
            a++;

            string str2;
            str2 = "thang";
            string str3;
            str3 = str2;

            // Bài Tập
            int value = 5;
            TestOut(out value);
            Console.WriteLine(value);
            TestRef(ref value);
            Console.WriteLine(value);
        }
    }
}
