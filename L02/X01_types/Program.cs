using System;

namespace X01_types
{
    class Program
    {
        static void Main(string[] args)
        {
            int horst; 
            horst = 42;
            Console.WriteLine(horst * 2 );
            Console.WriteLine("Hello World!");

            // String count to know how many bytes the string need it
            string j = "Hello, World";
            var countByte = j.Length * sizeof(Char);
            Console.WriteLine(j + " need "  + countByte + " Bytes ");
        
        // System.Text.ASCIIEncoding.ASCII.GetByteCount(j);   
        }
    }
}
