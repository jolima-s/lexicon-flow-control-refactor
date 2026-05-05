
using Ovn2_FlowControl;
using System;
using Ovn2_FlowControl.Services;

namespace FlowControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Menu.DisplayMenu();

                string? input = Console.ReadLine();

                switch (input)
                {
                    case "0":
                        running = false;
                        Console.WriteLine("Programmet avslutas.");
                        break;

                    case "1":
                        CinemaService.YoungsterOrSenior();
                        break;

                    case "2":
                        CinemaService.GroupPriceCalculation();
                        break;

                    case "3":
                        StringManipulationService.RepeatTenTimes();
                        break;

                    case "4":
                        StringManipulationService.ThirdWord();
                        break;

                    default:
                        Console.WriteLine("Felaktig input, välj 0-4.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}

