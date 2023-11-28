using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_cikli_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ievadiet trīsstūra platumu: ");
            int platums = int.Parse(Console.ReadLine());

            for (int rinda = platums; rinda >= 1; rinda--)
            {
                for (int tukšumi = 1; tukšumi <= platums - rinda; tukšumi++)
                {
                    Console.Write(' ');
                }
                for (int kolonna = 1; kolonna <= 2 * rinda - 1; kolonna++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
