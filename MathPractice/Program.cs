using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Int -2,147,483,648 to 2,147,483,647
            int intNum = -2121523;
            Console.WriteLine("int type " + "=" + intNum);

            // Uint 0 to 4,294,967,295
            uint uintNum = 21212121;
            Console.WriteLine("uint type " + "=" + uintNum);

            // Long -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            long longNum = 2345671625;
            Console.WriteLine("long type " + "=" + longNum);

            // Ulong 0 to 18,446,744,073,709,551,615	
            ulong ulongNum = 1121212;
            Console.WriteLine("ulong type " + "=" + ulongNum);

            // sbyte -128 to 127
            sbyte sbyteNum = -100;
            Console.WriteLine("sbyte type " + "=" + sbyteNum);

            // byte 0 to 255
            byte byteNum = 100;
            Console.WriteLine("byte type " + "=" + byteNum);

            // ushort 0 to 65,535
            ushort ushortNum = 65000;
            Console.WriteLine("ushort type " + "=" + ushortNum);

            // short -32,768 to 32,767	
            short shortNum = -12256;
            Console.WriteLine("short type " + "=" + shortNum);

            // float 
            float floatNum = 12.24F;
            Console.WriteLine("float type " + "=" + floatNum);

            // decimal
            decimal decimalNum = 12m;
            Console.WriteLine("decimal type " + "=" + decimalNum);

            // decimal
            double doubleNum = 12.678D;
            Console.WriteLine("double type " + "=" + doubleNum);


            // Math for examples

            float mathFloat = 12.622F;
            int mathInt = 13;
            Console.WriteLine("math.Floor() " + "=" + Math.Floor(mathFloat));
            Console.WriteLine("math.Ceiling() " + "=" + Math.Ceiling(mathFloat));
            Console.WriteLine("math.Round() " + "=" + Math.Round(mathFloat));
            Console.WriteLine("math.Sqrt() " + "=" + Math.Sqrt(mathFloat));
            Console.WriteLine("math.Pow() " + "=" + Math.Pow(mathFloat, mathInt));

            Console.ReadLine();
        }
    }
}
