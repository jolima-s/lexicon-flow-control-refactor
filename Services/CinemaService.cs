using Ovn2_FlowControl.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ovn2_FlowControl.Services
{
    internal class CinemaService
    {
        public static void YoungsterOrSenior()
        {
            Console.Write("Ange ålder: ");
            string? input = Console.ReadLine();

            if (!int.TryParse(input, out int age))
            {
                Console.WriteLine("Ogiltig ålder.");
                return;
            }

            Ticket ticket = new Ticket(age);
            Console.WriteLine(ticket);
        }

        public static void GroupPriceCalculation()
        {
            Console.Write("Hur många personer är ni? ");
            string? countInput = Console.ReadLine();

            if (!int.TryParse(countInput, out int count) || count <= 0)
            {
                Console.WriteLine("Ogiltigt antal personer.");
                return;
            }

            List<Ticket> tickets = new List<Ticket>();

            for (int i = 1; i <= count; i++)
            {
                Console.Write($"Ange ålder för person {i}: ");
                string? ageInput = Console.ReadLine();

                if (!int.TryParse(ageInput, out int age) || age < 0)
                {
                    Console.WriteLine("Ogiltig ålder.");
                    return;
                }

                tickets.Add(new Ticket(age));
            }

            Console.WriteLine($"Antal personer: {tickets.Count}");
            Console.WriteLine($"Totalkostnad: {tickets.Sum(t => t.Price):C}");
        }
    }
}
