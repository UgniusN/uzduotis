using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis1
{
    class Program
    {
        static void Main(string[] args)
        {
            int ZemesSpindulys = 6371;
            double ZemesPlotas = 4 * Math.PI * Math.Pow(ZemesSpindulys, 2);
            double ZemesTuris = 4 / 3 * Math.PI * Math.Pow(ZemesSpindulys, 3);
            double izambine = Math.Sqrt(Math.Pow(10, 2) + Math.Pow(15, 2));
            double suma = ZemesTuris + ZemesPlotas + izambine;
            double vidurkis = suma / 3;

            Console.WriteLine("|-----------------------------------------------|");
            Console.WriteLine("*##################################################*");
            Console.WriteLine("*#   **$ Zemes plotas: {0}           #*", ZemesPlotas);
            Console.WriteLine("*#   **$ Zemes turis: {0}            #*", ZemesTuris);
            Console.WriteLine("*#   **$ Staciakampio izambine: {0}  #*", izambine);
            Console.WriteLine("*#   **$ Kintamuju vidurkis : {0}", vidurkis);
            Console.WriteLine("*##############################################*");
            Console.WriteLine("|-----------------------------------------------|");
            Console.ReadLine();
            Console.WriteLine("*#   **$ Kintamuju suma: {0}", suma);
            
        
        }
    }
}
