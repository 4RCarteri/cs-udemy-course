namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region integers
            // With negative sign
            sbyte mySbyte = 127; // -128 to 127
            short myShort = 32767; // -32768 to 32767
            int myInt = 2147483647; // -2147483648 to 2147483647
            long myLong = 9223372036854775807; // -9223372036854775808 to 9223372036854775807

            // Without negative sign
            byte myByte = 255; // 0 to 255
            ushort myUshort = 65535; // 0 to 65535
            uint myUint = 4294967295; // 0 to 4294967295 
            ulong myUlong = 18446744073709551615; // 0 to 18446744073709551615

            Console.WriteLine(myInt);
            #endregion

            #region floating point
            float real1 = 0.05f; // 7 digits
            double real2 = 0.0545; // 15-16 digits
            decimal real3 = 0.564498m; // 28-29 digits
            Console.WriteLine(real1);
            #endregion

            #region characters
            char myChar = 'A';
            char utf16 = '\u0061';
            Console.WriteLine(myChar);
            Console.WriteLine(utf16);
            #endregion

            #region boolean
            bool myBool = true;
            Console.WriteLine(myBool);
            #endregion

            #region string
            string myString = "Hello, World!";
            Console.WriteLine(myString);

            //Ignore escape characters
            string myString2 = @"C:\Users\MyUser";
            Console.WriteLine(myString2);
            #endregion

            #region var
            var myVar = 5;
            var myVar2 = false;
            Console.WriteLine(myVar);
            Console.WriteLine(myVar2);
            #endregion
        }
    }
}
