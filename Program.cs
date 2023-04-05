using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LINQ_Paring
{
    class Program
    {
        static void Main(string[] args)
        {
            // Näidiselemendid int ja string
            int[] numbrid = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 55 };
            string[] nimed = { "Anna", "Amanda", "Mart", "Marit",
                "Jüri", "Malle", "Tõnis" };

            // Päring, mis valib välja numbrid, mis on suuremad kui 10 kasutades .Where
            var suuredNumbrid = numbrid.Where(num => num > 10);

            //Kõik numbrid 
            {
                Console.WriteLine("Kõik numbrid: 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 55");
            }

            // Näitab valitud numbrid konsoolis
            Console.WriteLine("Suuremad kui 10:");
            foreach (var number in suuredNumbrid)
            {
                Console.WriteLine(number);
            }

            // Päring, mis järjestab nimed pikkuse järgi ja siis tähestiku järgi kasutades .OrderBy ja seejärel .ThenBy
            var jarjestatudNimed = nimed.OrderBy(nimi => nimi.Length).ThenBy(nimi => nimi);

            // Näitab järjestatud nimesid konsoolis
            Console.WriteLine("\nJärjestatud nimed:");
            foreach (var nimi in jarjestatudNimed)
            {
                Console.WriteLine(nimi);
            }

            Console.ReadLine();
        }
    }
}

