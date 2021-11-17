
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
            a.Push(new book("001", "Nhà giả kim", "Quốc Trung", "Triết học", "Kim Đồng", 290000, "A-03",  new DateTime(2019, 1, 1),""));
            a.Display();
            Console.ReadKey();
        }
    }
}