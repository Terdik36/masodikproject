using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MásodikProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("szia, adjál ide 5 dolcsit");
            int penz = Convert.ToInt32( Console.ReadLine() );

            if (penz < 5)
            {
                Console.WriteLine("csóró ez nem elég pénz RAFLLLLLL");
                Console.WriteLine("most meghalsz hahaha");
                System.Threading.Thread.Sleep(
                    (int)System.TimeSpan.FromSeconds(2).TotalMilliseconds);
                return;
            }
            else if (penz == 5)
            {
                Console.WriteLine("kösz de mielőtt elmész");
            }
            else
            {
                int visszajaro = penz - 5;
                Console.WriteLine("ez túl sok tessék itt van " + visszajaro + " dolcsi");
            }

        // itt van a doxolás
            int magassag;
            int kor;

            Console.WriteLine("még add meg az informacioidat vagy meghalsz");
            Console.WriteLine("korod:");
            kor = Convert.ToInt32( Console.ReadLine() );

            if (kor >= 18)
            {
                Console.WriteLine("ok nem vagy underage");
            }
            else
            {
                Console.WriteLine("bruh underage vagy rafl");
                Console.WriteLine("most meghalsz hahaha");
                System.Threading.Thread.Sleep(
                    (int)System.TimeSpan.FromSeconds(2).TotalMilliseconds);
                return;
            }

            Console.WriteLine("magasságod:");
            magassag = Convert.ToInt32( Console.ReadLine() );

            if (magassag >= 150)
            {
                Console.WriteLine("ok köszi jól van");
                System.Threading.Thread.Sleep(
                    (int)System.TimeSpan.FromSeconds(2).TotalMilliseconds);
                return;
            }
            else
            {
                Console.WriteLine("bruh túl alacsony vagy rafl");
                Console.WriteLine("most meghalsz hahaha");
                System.Threading.Thread.Sleep(
                    (int)System.TimeSpan.FromSeconds(2).TotalMilliseconds);
                return;
            }

            Console.ReadKey();
        }
    }
}