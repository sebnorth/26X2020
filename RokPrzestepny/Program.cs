using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RokPrzestepny
{
    class Program
    {

        public static void CzyRokJestPrzestepny(int liczba) {
            if ((liczba % 4 == 0 && liczba % 100 != 0) || liczba % 400 == 0)
            {
                Console.WriteLine("Rok {0} jest przestępny", liczba);
            }

            else
            {
                Console.WriteLine("Rok {0} nie jest przestępny", liczba);
            }
        }
        
        static void Main(string[] args)
        {
            //Console.WriteLine("Podaj rok: ");
            //int liczba = Convert.ToInt32(Console.ReadLine());

            CzyRokJestPrzestepny(1900);
            CzyRokJestPrzestepny(2000);
            CzyRokJestPrzestepny(2020);
            CzyRokJestPrzestepny(2021);

            Console.ReadKey();
        }
    }
}
