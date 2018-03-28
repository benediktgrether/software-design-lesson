using System;

namespace X01_types
{
    public class Person
    {
        public string Name;
        public int Personalnummer;
    }
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
        
            Console.WriteLine(System.Text.ASCIIEncoding.ASCII.GetByteCount(j) + " Bytes"); 
            Console.WriteLine(System.Text.ASCIIEncoding.Unicode.GetByteCount(j) + " Bytes");  
        
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

            // To Do float declaration with var
            var db = 3.5f;
            Console.WriteLine(db.GetType() + " -- " + db + " float value" );
            //short
            short shortValue1 = 1_034;
            Console.WriteLine(shortValue1.GetType() + " -- " + db + " short value" );
        
            // Array - Variable declaration
            int[] ia = {1, 0, 2, 9, 3, 8, 4, 7, 5, 6};
            int ergebnis = ia[2] * ia[8] + ia[4];
            // 2 * 5  + 3 
            // Das Ergebnis ist 13
            Console.WriteLine("Das Ergebnis ist = " + ergebnis);

            // Array - double ( Pi , Eulersche number , Kepler-constant)
            double[] ja = {3.145,  2.71828, 2.97E-19};
            for(int k = 0; k < ja.Length; k++){
                Console.WriteLine(ja[k]);
            }

            // Array Length
            Console.WriteLine("---------------");
            Console.WriteLine(ja.Length);

            // String 
            string meinString = "Dies ist ein String";
            char zeichen = meinString[5];
            string a = "eins";
            string b = "zwei";
            string c = "eins";
            bool a_eq_b = (a == b);
            bool a_eq_c = (a == c);

            Console.WriteLine("-------");
            Console.WriteLine(meinString);
            Console.WriteLine(zeichen);
            Console.WriteLine(c);
            Console.WriteLine(a_eq_b);
            Console.WriteLine(a_eq_c);

            // class Person

            Person jemand = new Person();
            jemand.Name = "Horst";
            jemand.Personalnummer = 42;
            
            Person jemand2 = new Person {Name="Sabine", Personalnummer=89};

            Console.WriteLine(jemand.Name + " " + jemand.Personalnummer);
            Console.WriteLine(jemand2.Name + " " + jemand2.Personalnummer);
            Console.WriteLine("--------------");

            // if / else operation
            int ax = int.Parse(Console.ReadLine());
            int ay = int.Parse(Console.ReadLine());

            if (ay < ax){
                Console.WriteLine(ax + " ist größer " + ay);
            }else{
                Console.WriteLine(ax + " ist kleiner " + ay);
            }

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (3 < x ){
                Console.WriteLine();
            }else{
                Console.WriteLine();
            }
        }
    }
}
