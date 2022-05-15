using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week07_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte sb = new sbyte();  // create new object
            byte bt = new byte();
            short sh;
            ushort ush;
            int ii = new int();
            uint ui;
            long lo;
            ulong ul;
            float fl;
            double db;
            bool bl;
            char ch;
            decimal de;

            object ob;
            string st;
            dynamic dy;


            Console.WriteLine($"Declaration\tType name\tType code\tMaximum Value\tMinimum Value");
            Console.WriteLine($"----------------------------------------------------------------------------");
            Console.WriteLine($"sbyte sb\t{sb.GetType()}\t{sb.GetTypeCode()}\t\t{sbyte.MaxValue}\t\t{sbyte.MinValue}");
            Console.WriteLine($"byte bt\t\t{sb.GetType()}\t{bt.GetTypeCode()}\t\t{byte.MaxValue}\t\t{byte.MinValue}");
            Console.WriteLine($"short sh");
            Console.WriteLine($"ushort ush");
            Console.WriteLine($"int ii\t\t{ii.GetType()}\t{ii.GetTypeCode()}\t\t{int.MaxValue}\t{int.MinValue} ");
 
            Console.WriteLine("============================================================================");
        }
    }
}
