using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangvabien4
{
    internal class Program
    {
        struct ThongTinHS
        {
            public string hoTen;
            public string lop;
            public double diemTBHKI;
            public double diemTBHKII;
            public ThongTinHS (string hoten, string Lop, double TBHKI = 0, double TBHKII = 0)
            {
                this.hoTen = hoten;
                this.lop = Lop; 
                this.diemTBHKI = TBHKI;
                this.diemTBHKII = TBHKII;
            }
        }
        static void Main(string[] args)
        {
            ThongTinHS a = new ThongTinHS();
            a = NhapTTHS();
            Console.WriteLine("<---------------------------------->");
            Console.WriteLine("Diem trung binh ca nam cua hoc sinh: {0}", diemTB_nam(a.diemTBHKI, a.diemTBHKII));
            Console.WriteLine("<---------------------------------->");
            Console.ReadKey();

        }
        static ThongTinHS NhapTTHS()
        {
            ThongTinHS x = new ThongTinHS();
            Console.Write("Nhap ho ten hoc sinh: ");
            x.hoTen = Console.ReadLine();
            Console.Write("Nhap lop hoc sinh: ");
            x.lop = Console.ReadLine();
            Console.Write("Nhap diem trung binh HKI cua hoc sinh: ");
            x.diemTBHKI = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem trung binh HKII cua hoc sinh: ");
            x.diemTBHKII = double.Parse(Console.ReadLine());
            return x;
        }
        static double diemTB_nam(double TBHKI = 0, double TBHKII = 0)
        {
            double x = (TBHKI + TBHKII * 2) / 3;
            return x;
        }

    }
}
