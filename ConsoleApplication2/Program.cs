using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("(Dont give up , Skeleton!)" +
            //    "\nAdd meg a bekérendő számok mennyiségét! (most)");
            //String atmero = Console.ReadLine();

            Console.WriteLine("Add meg a számot!");
            int nSzam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bekérendő számok mennyisége: " + nSzam);
            Console.ReadLine();
            int[] t = new int[nSzam];

            for (int i = 0; i < nSzam; i++)
            {
                Console.WriteLine("Add meg a "+ (i + 1) + ". számot!");
                t[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.ReadLine();

            int max;

            //Maximum kiválasztás tétele
            max = t[0];
            for (int i = 0; i < t.Length; i++)
                if (t[i] > max)
                    max = t[i];

            Console.WriteLine("A tömb legnagyobb értéke: " + max);
            //atmero = double.Parse(Console.ReadLine());
            //double asdd;

            //if (!double.TryParse(Console.ReadLine(), out asdd))
            //{
            //    Console.Clear();
            //    Console.WriteLine("Hibás adat! Kérem adja meg újra", 50, 2, ConsoleColor.Black, ConsoleColor.Red);
            //}
            //else {
            //    Console.WriteLine("nyasgem");


        }
        
    }
}
