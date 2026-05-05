using System;
using System.Collections.Generic;
using System.Text;

namespace Ovn2_FlowControl
{
    internal class Menu
    {
        public static void DisplayMenu()
        {
            Console.WriteLine("Välkommen till huvudmenyn.");
            Console.WriteLine("Skriv en siffra för att välja funktion.");
            Console.WriteLine("0 = Avsluta");
            Console.WriteLine("1 = Ungdom eller pensionär");
            Console.WriteLine("2 = Pris för sällskap");
            Console.WriteLine("3 = Upprepa tio gånger");
            Console.WriteLine("4 = Det tredje ordet");
            Console.Write("Ditt val: ");
        }
    }
}
