using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace hangvabien5
{
    internal class Program
    {
        struct thongTinNV
        {
            public string hoTen;
            public string gioiTinh;
            public string ngaySinh;
            public double hsl;
            public int luongCB;
            public int phucapNV;
        }
        static void Main(string[] args)
        {
            thongTinNV a = new thongTinNV();
            thongTinNV b = new thongTinNV();
            Console.WriteLine("Nhap thong tin nhan vien:");
            Console.WriteLine("\tNhap thong tin nhan vien thu nhat");
            a = NhapTTNV();
            Console.WriteLine("\tNhap thong tin nhan vien thu hai");
            b = NhapTTNV();
            Console.WriteLine("<------------------------------------------->");
            Console.WriteLine("Hien thi thong tin nhan vien:");
            Console.WriteLine("\tHien thi thong tin nhan vien thu nhat:");
            PrintTTNV(a);
            Console.WriteLine("\tHien thi thong tin nhan vien thu hai:");
            PrintTTNV(b);
            Console.WriteLine("<------------------------------------------->");
            Console.ReadKey();
        }
        static thongTinNV NhapTTNV()
        {
            thongTinNV x = new thongTinNV();
            Console.Write("\t\tNhap ho ten nhan vien: ");
            x.hoTen= Console.ReadLine();
            Console.Write("\t\tNhap gioi tinh nhan vien: ");
            x.gioiTinh = Console.ReadLine();
            Console.Write("\t\tNhap ngay sinh nhan vien: ");
            x.ngaySinh = Console.ReadLine();
            Console.Write("\t\tNhap he so luong nhan vien: ");
            x.hsl =double.Parse(Console.ReadLine());
            Console.Write("\t\tNhap luong co ban nhan vien: ");
            x.luongCB = int.Parse(Console.ReadLine());
            Console.Write("\t\tNhap phu cap nhan vien: ");
            x.phucapNV = int.Parse(Console.ReadLine());
            return x;
        }
        static void PrintTTNV(thongTinNV x)
        {
            Console.WriteLine("\t\tHo ten nhan vien la {0}", x.hoTen);
            Console.WriteLine("\t\tGioi tinh nhan vien la {0}", x.gioiTinh);
            Console.WriteLine("\t\tNgay sinh nhan vien la {0}", x.ngaySinh);
            Console.WriteLine("\t\tHe so luong nhan vien la {0}", x.hsl);
            Console.WriteLine("\t\tLuong co ban nhan vien la {0}", x.luongCB);
            Console.WriteLine("\t\tphu cap nhan vien la {0}", x.phucapNV);
        }
    }
}
