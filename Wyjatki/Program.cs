using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyjatki
{
    class Program
    {
        static void Main(string[] args)
        {

        naprawa:
            try
            {
                
                int x = 10;
                
                
                int y = Convert.ToInt32(Console.ReadLine());
                int wynik = x / y;
                Console.WriteLine(wynik);
            }

            catch (DivideByZeroException uchwyt)
            {
                Console.WriteLine(uchwyt.Message);

                // throw;
            }

            catch (Exception uchwyt)
            {
                Console.WriteLine(uchwyt.Message);
                goto naprawa;
            }

        

            //finally {
                
            //    Console.WriteLine("Program rusza dalej");
            //    double dzielnik, iloraz;
            //    try
            //    {
            //        dzielnik = Convert.ToDouble(Console.ReadLine());
            //        if (dzielnik == 0)
            //            throw new DivideByZeroException("Dzielnik nie może mieć wartość zero!!!");
            //        iloraz = 10.2 / dzielnik; Console.WriteLine(iloraz);
            //    }
            //    catch (DivideByZeroException ex)
            //    {
            //        Console.WriteLine("Komunikat wyjatku: {0}", ex.Message);
            //    }

            //}

            Console.ReadKey();
        }
    }
}
