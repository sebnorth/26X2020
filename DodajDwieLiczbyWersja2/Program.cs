using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DodajDwieLiczbyWersja2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę: ");
            int.TryParse(Console.ReadLine(), out int x);

            Console.WriteLine("Podaj drugą liczbę: ");
            int.TryParse(Console.ReadLine(), out int y);

            Obliczenia.ObliczSume(x, y);

            Console.ReadKey();

        }
    }
}
