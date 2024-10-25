using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tran_Thao_Vy
{
    internal class Ex3
    {
        private static void Main()
        {
            //Question_02();
            Question_03();
            //Question_05();
        }
        public static void Question_02()
        {
            int y;
            Console.WriteLine("x = y² - 2y + 1");
            Console.WriteLine();
            for (y = -5; y <= 5; y++)
            {
                double x = Math.Pow(y, 2) + 2 * y + 1;
                Console.WriteLine($"y={y}; x = ({y})² - 2*({y}) + 1 = {x}");
            }
        }
        public static void Question_03()
        {
            Console.WriteLine( "Nhap");
            Console.Write("Hour:");
            Console.Write("Minute:");
            Console.Write("Second:");
            double hours = double.Parse(Console.ReadLine());
            double minutes = double.Parse(Console.ReadLine());
            double seconds = double.Parse(Console.ReadLine());
            double t = (hours * 3600) + (minutes * 60) + seconds;
            Console.WriteLine( $"Tong la:{t}");
            Console.Write("km hay m?:" );
            string khoangcach = Console.ReadLine();
            if (khoangcach == "m")
            {
                Console.Write("Doan duong di duoc s=");
                double s=double.Parse(Console.ReadLine());
                double v1 = s / t;
                double v2 = (s/t)*1000;
                Console.WriteLine($"van toc: \n m/s: {v1} \n km/h:{v2});
            }
            else
            {
                Console.Write("Doan duong di duoc s=");
                double s = double.Parse(Console.ReadLine());
                double v1 = s / t;
                double v2 = (s / t) / 1000;
                Console.WriteLine($"van toc: \n m/s: {v2} \n km/h:{v1});
            }
            
        }
        public static void Question_05()
        {
            char c = char.Parse(Console.ReadLine());

            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                Console.WriteLine("The entered Character is an Lowercase Vowel={0}", c);
            }
            else if (c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9')
            {
                Console.WriteLine("Nhap so={0}", c);

            }
            else
                Console.WriteLine("Khong ton tai gia tri");
            Console.ReadLine();
        }
        
    }
}
