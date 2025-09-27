using System;
using PersonalLib; // dùng DLL

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Ung dung Du Doan Ngay Sinh (Console) ===");
            Console.Write("Nhap ngay sinh: ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("Nhap thang sinh: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam sinh: ");
            int year = int.Parse(Console.ReadLine());

            FunPredict fp = new FunPredict();
            string result = fp.PredictBirthday(day, month, year);

            Console.WriteLine("Ket qua du doan: " + result);
            Console.ReadKey();
        }
    }
}
