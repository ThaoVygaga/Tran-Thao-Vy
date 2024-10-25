using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tran_Thao_Vy
{
    internal class Ex2
    {
        private static void Man()
        {
            //Question_01();
            //Question_02();
            //Question_03();
        }
        public static void Question_01()
        {
            Console.Write("Enter a Celsius number= ");
            int C = int.Parse(Console.ReadLine());
            int K = C + 273;
            int F = C * 18 / 10 + 32;
            Console.WriteLine($"convert to Kelvin: {K}");
            Console.WriteLine($"convert to fahrenheit: {F}");
        }
        public static void Question_02()
        {
            Console.Write("Enter a radius number:");
            float x = float.Parse(Console.ReadLine());
            double s = 4 * Math.PI * Math.Pow(x, 2);
            double v = 4 / 3 * Math.PI * Math.Pow(x, 3);
            Console.WriteLine($"Surface: {s}");
            Console.WriteLine($"Volume: {v}");

        }
        public static void Question_03()
        {
            Console.Write("Enter a number a= ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter a number b= ");
            int b = int.Parse(Console.ReadLine());
            int sum = a + b;
            int sub = a - b;
            int mul = a * b;
            int div = a / b;
            Console.WriteLine($"sum of: {a} + {b} = {sum}");
            Console.WriteLine($"sub of: {a} * {b} = {sub}");
            Console.WriteLine($"mul:{mul}");
            Console.WriteLine($"div:{div}");
            int g= a % b;
            Console.WriteLine($"the rest of the division: {g}");
        }
    }
}
