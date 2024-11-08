namespace Tran_Thao_Vy
{
    internal class Ex5
    {

        private static void Main()
        {
            //Question_01();
            //Question_02();
            //Question_03();
        }
        public static void Question_01()
        {
            Console.Write("nhap so phan tu mang:");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            nhapmangbangCom(a);
        }
        static void nhapmangbangCom(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.Write($"Nhap phan tu thu #{i}");
            a[i] = int.Parse(Console.Readline());
        }

    }
}