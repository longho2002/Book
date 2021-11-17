
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp12
{

    public static class Program
    {

        public static void Main()
        {
            ListBook a = new ListBook();
            book temp = new book();
            temp.maSach = "001";
            temp.tenSach = "Nhà giả kim";
            temp.TacGia = "Quốc Trung";
            temp.ChuDe = "Triết học";
            temp.NXB = "Kim Đồng";
            temp.price = 290000;
            temp.vt = "A-03";
            temp.imgSrc = "C:/Users/Thai_Long/Downloads/giakim.jpg";
            temp.NgXB = new DateTime(2019, 1, 1);
            a.Push(temp);
            a.Display();
            Console.ReadKey();
        }
    }
}