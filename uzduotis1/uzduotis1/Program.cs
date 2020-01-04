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
            double ZemesPlotas = Math.Round(4 * Math.PI * Math.Pow(ZemesSpindulys, 2),2);
            double ZemesTuris = Math.Round(4 / 3 * Math.PI * Math.Pow(ZemesSpindulys, 3),2);
            double izambine = Math.Round(Math.Sqrt(Math.Pow(10, 2) + Math.Pow(15, 2)),2);
            double suma = Math.Round(ZemesTuris + ZemesPlotas + izambine,2);
            double vidurkis = Math.Round(suma / 3,2);

            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("██████████████████████████████████████████████████");
            Console.WriteLine("█                                                █");
            Console.WriteLine("█                Duomenu lentele                 █");
            Console.WriteLine("█                                                █");
            Console.WriteLine("██████████████████████████████████████████████████");
            Console.WriteLine("█                                                █");
            Console.WriteLine("█       Zemes plotas: {0}               █", ZemesPlotas);
            Console.WriteLine("█       Zemes turis: {0}             █", ZemesTuris);
            Console.WriteLine("█       Staciakampio izambine: {0}             █", izambine);
            Console.WriteLine("█       Kintamuju vidurkis : {0}     █", vidurkis);
            Console.WriteLine("█       Kintamuju suma: {0}          █", suma);
            Console.WriteLine("█                                                █");
            Console.WriteLine("██████████████████████████████████████████████████");

             
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
