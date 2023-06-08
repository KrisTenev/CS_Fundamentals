using System;

namespace Data_Types_and_Variables
{
    internal class Program
    {
        static void Main()
        {
            //1. Data Types and Variables

            //2. Integer Types
            sbyte @sbyte = -68;
            byte @byte = 21;

            short @short = -657;
            ushort @ushort = 6547;

            int @int = -1;
            uint @uint = 100;

            long @long = -100;
            ulong @ulong = 100;

            //3. Real Numbers Types
            float @float = 2.3545f;         //32 bit
            double @double = 2.354345;      //64 bit
            decimal @decimal = 2.53242m;    //128 bit

            //4. Type Conversion
            int numberHex = 0xaf;
            int numberDeci = 0b10;
            int numberParce = int.Parse("0xAF");
            int numberParceInt23 = Convert.ToInt32("0xAF",2);

            //5. Boolean Type
            bool @bool = false;

            //6. Character Type
            char @char = '#';

            //7. String Type
            string @string = "String";




        }
    }
}
