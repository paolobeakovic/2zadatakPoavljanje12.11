using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beakovicPaolozadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upiši niz : ");
            string niz = Console.ReadLine();

            Console.WriteLine(niz.Replace(" ", "_"));
            Console.ReadKey();

        }
    }
}
