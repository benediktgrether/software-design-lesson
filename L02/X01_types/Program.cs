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
        
        // To Do - Initialisierung & Typ Inferenz

            int i1 = 42;
            double pi1 = 3.1415;
            string salute1 = "Hello, World";
            Console.WriteLine(i1);
            Console.WriteLine(pi1);
            Console.WriteLine(salute1);
            Console.WriteLine("--------");

            // To Do Change declaration to var
            var i = 42;
            var pi = 3.1415;
            var salute = "Hello, World";
            Console.WriteLine(i.GetType() + " -- " + i);
            Console.WriteLine(pi.GetType() + " -- " + pi);
            Console.WriteLine(salute.GetType() + " -- " + salute);
        }
    }
}
