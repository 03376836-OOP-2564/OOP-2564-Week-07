# การทดลองสัปดาห์ที่ 7.2 #
## แสดงรายละเอียดของ predefined type ในภาษา C#  ##


### Learning Outcome ###
1. นักศึกษารู้จัก predefined type และบอกได้ว่ามีอะไรบ้าง
2. นักศึกษาสามารถเขียนโปรแกรมเพื่อรายงานค่าเฉพาะตัวของ predefined type ได้

## งานที่ต้องทำให้สำเร็จ ##

แก้ไขโค้ดตัวอย่าง ให้รายงานรายละเอียดของ predefine type ได้ครบถ้วน
```cs
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

```

<p align = "center"> 
    
![image](https://user-images.githubusercontent.com/92080550/169587324-570bdded-7415-48e1-8c3e-14bdece7ff01.png)


<p align = "center"> <b>รูปที่ 1 </b> ผลที่ได้จากการรันโปรแกรม</p>

### Hint ###
1. อาจจะต้องสร้าง object ด้วยคำสั่ง `new ___();`
2. อาจจะต้องเพิ่มหรือลด `\t` ใน `Console.WriteLine(...)` เพื่อให้การแสดงผลมีระยะเหมาะสม
3. การใช้  `$"..........."` ในเมธอด `Console.WriteLine(...)` เรียกว่า `string interpreter` ช่วยให้เราไม่ต้องกังวลเรื่องตำแหน่งของ place holder ในข้อความ สามารถแทรกตัวแปรลงในเครื่องหมาย `{...}` ได้เลย คอมไพเลอร์จะแปลงเป็น string ให้โดยอัตโนมัติ  (และสามารถกำหนดรูปแบบได้้เช่นเดียวกับ string formatting ด้วยวิธีการเดิม)

