using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so nguyen b = ");
            int b = int.Parse(Console.ReadLine());
            int tong = a + b;
            int hieu0 = a - b;
            int hieu1 = b - a;
            int tich = a * b;
            double thuong0 = (double)b / a;
            double thuong1 = (double)a / b;
            Console.WriteLine("<------------------------->");
            Console.WriteLine($"Tong cua a + b = {tong}");
            Console.WriteLine($"Hieu cua a - b = {hieu0}");
            Console.WriteLine($"Hieu cua b - a = {hieu1}");
            Console.WriteLine($"Tich cua a * b = {tich}");
            Console.WriteLine($"Thuong cua a / b = {thuong0}");
            Console.WriteLine($"Thuong cua b /a = {thuong1}");
            Console.WriteLine("<------------------------->");
            Console.ReadKey();
        }
    }
}
