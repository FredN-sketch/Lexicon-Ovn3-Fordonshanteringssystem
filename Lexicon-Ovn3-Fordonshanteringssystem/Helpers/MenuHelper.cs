using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Ovn3_Fordonshanteringssystem.Helpers
{
    public static class MenuHelper
    {
        public static void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("Fordonshantering");
            Console.WriteLine("================");
            Console.WriteLine("1. Lägg till fordon manuellt");
            Console.WriteLine("2. Lägg till fordon automatiskt (färdiga exempel)");
            Console.WriteLine("3. Visa fordonslista");
            Console.WriteLine("4. Generera fel och visa fellista (10 slumpmässiga fel)");                        
            Console.WriteLine("0. Avsluta");
            Console.Write(Environment.NewLine);
            Console.WriteLine("Skriv in siffran till vänster om varje menyval för att köra resp funktion");
            Console.Write(Environment.NewLine);
        }
        
          public static void PressAnyKey()
        {
            Console.Write(Environment.NewLine);
            Console.WriteLine("Tryck på valfri tangent för att återgå till huvudmenyn.");
            Console.ReadKey();
        }
    }
}
