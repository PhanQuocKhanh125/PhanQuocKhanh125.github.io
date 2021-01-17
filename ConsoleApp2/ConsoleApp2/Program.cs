using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Giai phuong trinh bac nhat co dang: ax + b = 0");
            Console.Write("Nhap vao a: ");
            float a = float.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("a phai khac 0");
            }
            else
            {
                Console.Write("Nhap vao b: ");
                float b = float.Parse(Console.ReadLine());

                float x = -b / a;
                Console.WriteLine("{0}x + {1} = 0 \n=> x = {2}", a, b, x);
            }
            Console.ReadKey();
        }
    }
}
