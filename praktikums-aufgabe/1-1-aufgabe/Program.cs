using System;

namespace _1_1_aufgabe
{
    class Program
    {
        static void Main(string[] args)
        {
            string w = "w";
            string k = "k";
            string o = "o";
            var eingabe = (args[0]);
            var Num = (args[1]); 
            double d = Convert.ToDouble(Num);
            // double d = Convert.ToDouble(test);
             if (w == eingabe){
                Console.WriteLine("Hello World");
                Console.WriteLine(d.GetType() + " " + d);
                // double a = 6 * (d * d);
                // double v = d * d * d;
                // Console.WriteLine(a + " " + v);
            }else if( k == eingabe ){

            }else if( o == eingabe ){
            
            }else{
                Console.WriteLine("Wrong input");
            }
            
        }

        // public double Oberflaeche(double kantenlangen, double durchmesser){
        //     double a = 6 * kantenlangen * kantenlangen;
        //     return a;
        // }
    }
}
