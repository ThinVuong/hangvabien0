using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangvabien2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chieu dai hinh chu nhat a = ");
            double a= double.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong hinh chu nhat b = ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("<------------------------>");
            double chuVi = (a + b) * 2;
            double dienTich = a * b;
            Console.WriteLine($"Chu vi hinh chu nhat la {chuVi}");
            Console.WriteLine($"Dien tich hinh chu nhat la {dienTich}");
            Console.WriteLine("<------------------------>");
            Console.ReadKey();
        }
    }
}
