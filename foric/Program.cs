using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foric
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] heyvan_isimleri = new string[5] { "ayi", "cavid", "meymun", "dovsan", "bal porsugu" };
            Array.Clear(heyvan_isimleri, 2, 2);

            foreach (string adlar in heyvan_isimleri) 
            {
                Console.WriteLine(adlar);

            }Console.ReadKey();
        }
    }
}
