using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangvabien6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao ngay ban muon: ngay = ");
            int ngay = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao thang ban muon: thang = ");
            int thang = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao nam ban muon: nam = ");
            int nam = int.Parse(Console.ReadLine());
            DateTime inputDate = new DateTime(nam, thang, ngay);
            DateTime ngayMai = inputDate.AddDays(1);
            DateTime NgayHQ = inputDate.AddDays(-1);
            Console.WriteLine("<------------------------------>");
            Console.WriteLine("Ngay hom qua la:  \t{0}",NgayHQ.ToString("dd/MM/yyyy"));
            Console.WriteLine("Ngay hom nay la:  \t{0}", inputDate.ToString("dd/MM/yyyy"));
            Console.WriteLine("Ngay mai la:      \t{0}", ngayMai.ToString("dd/MM/yyyy"));
            Console.WriteLine("<------------------------------>");
            Console.ReadKey();


        }
    }
}
