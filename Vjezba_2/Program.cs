using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Vjezba_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite recenicu:");
            var tekst = Console.ReadLine();
            Console.WriteLine();

            tekst.Split(new char[] { ' ', ';', '.', ',', '?','!' }).GroupBy(x => x.ToLower()).ToList().ForEach(g => 
            {
                Console.WriteLine($"\"{g.Key}\" - se pojavljuje {g.Count()} puta");
            });

            

            Console.ReadLine();
        }
    }
}
