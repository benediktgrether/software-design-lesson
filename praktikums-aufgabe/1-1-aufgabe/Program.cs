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
            double a;
            double v;
            var eingabe = (args[0]);
            var Num = (args[1]); 
            double d = Convert.ToDouble(Num);
            // double d = Convert.ToDouble(test);
             if (w == eingabe){
                a = getCubeSurfaceW(d);
                v = getCubeVolumeW(d);
                getCubeInfoW(a, v);
                // Console.WriteLine(a);
                // getCubeInfoW(a, v);
            }else if( k == eingabe ){
                // getCubeSurfaceK(d);
                // getCubeVolumeK(d);
            }else if( o == eingabe ){
            
            }else{
                Console.WriteLine("Wrong input");
            }

            // A = getCubeSurfaceW(a);
            
        }
    
        public static double getCubeSurfaceW(double kanten){
            double d = kanten;
            double a = 6 * (d * d);
            // Console.WriteLine(a);
            return a;
        }
        public static double getCubeVolumeW(double kanten){
            double d = kanten;
            double v = d * d * d;
            return v;
        }

        public static void getCubeInfoW(double surface, double volume){
            double a = surface;
            double v = volume;
            Console.WriteLine(a + " | " + v );
        }
    }

}
