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
            sbyte   sb  = new sbyte();  // create new object
            byte    bt  = new byte();
            short   sh  = new short();
            ushort  ush = new ushort();
            int     ii  = new int();
            uint    ui  = new uint();
            long    lo  = new long();
            ulong   ul  = new ulong();
            float   fl  = new float();
            double  db  = new double();
            bool    bl  = new bool();
            char    ch  = new char();
            decimal de  = new decimal();

            object ob;
            string st;
            dynamic dy;


            Console.WriteLine($"Declaration\t   Type name\t  Type code\t    Maximum Value\t      Minimum Value");
            Console.WriteLine($"---------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"sbyte sb\t {sb.GetType()}\t  {sb.GetTypeCode()}\t\t  {sbyte.MaxValue}\t\t\t\t  {sbyte.MinValue} ");
            Console.WriteLine($"byte bt\t\t {bt.GetType()}\t  {bt.GetTypeCode()}\t\t  {byte.MaxValue}\t\t\t\t   {byte.MinValue}  ");
            Console.WriteLine($"short sh\t {sh.GetType()}\t  {sh.GetTypeCode()}\t\t  {short.MaxValue}\t\t\t\t  {short.MinValue} ");
            Console.WriteLine($"ushort ush\t {sh.GetType()}\t  {ush.GetTypeCode()}\t  {ushort.MaxValue}\t\t\t\t   {ushort.MinValue}");
            Console.WriteLine($"int ii\t\t {ush.GetType()}\t  {ii.GetTypeCode()}\t\t  {int.MaxValue}\t\t\t   {int.MinValue}   ");
            Console.WriteLine($"uint ui\t\t {ii.GetType()}\t  {ui.GetTypeCode()}\t  {uint.MaxValue}\t\t\t   {uint.MinValue}   ");
            Console.WriteLine($"long lo\t\t {lo.GetType()}\t  {lo.GetTypeCode()}\t\t  {long.MaxValue}\t\t   {long.MinValue}   ");
            Console.WriteLine($"ulong ul\t {ul.GetType()}\t  {ul.GetTypeCode()}\t  {ulong.MaxValue}\t\t   {ulong.MinValue}   ");
            Console.WriteLine($"float fl\t {fl.GetType()}\t  {fl.GetTypeCode()}\t  {float.MaxValue}\t\t\t    {float.MinValue}   ");
            Console.WriteLine($"double db\t {db.GetType()}\t  {db.GetTypeCode()}\t  {double.MaxValue}\t\t   {double.MinValue}   ");
            Console.WriteLine($"bool bl\t\t {bl.GetType()}\t  {bl.GetTypeCode()}\t  {bool.TrueString}\t\t\t\t   {bool.FalseString}   ");
            Console.WriteLine($"char ch\t\t {ch.GetType()}\t  {ch.GetTypeCode()}\t\t  {char.MaxValue}\t\t\t\t    {char.MinValue}   ");
            Console.WriteLine($"decimal de\t {de.GetType()}\t  {de.GetTypeCode()}\t  {decimal.MaxValue}\t   {decimal.MinValue}   ");

            Console.WriteLine("==========================================================================================================");
        }
    }
}
