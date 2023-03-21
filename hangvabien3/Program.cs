using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangvabien3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap duong kinh hinh tron d = ");
            double d = double.Parse(Console.ReadLine());
            double banKinh = d / 2;
            double chuVi = (Math.PI) * d;
            double dienTich = (Math.PI) * Math.Pow(banKinh,2);
            Console.WriteLine("<--------------------------------------->");
            Console.WriteLine($"Ban kinh hinh tron la {banKinh}");
            Console.WriteLine($"chu vi hinh tron la {chuVi}");
            Console.WriteLine($"Dien tich hinh tron la {dienTich}");
            Console.WriteLine("<--------------------------------------->");
            Console.ReadKey();
        }
    }
}
