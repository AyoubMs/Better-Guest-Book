using GuestBookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class ConsoleUIMethods
    {
        internal static void GetGuestInformation(List<GuestModel> guests)
        {

            string moreGuestsComing = "";

            do
            {
                GuestModel guest = new GuestModel();

                guest.FirstName = GetInfoFromConsole("What is your first name: ");

                guest.FirstName = GetInfoFromConsole("What is your last name: ");

                guest.MessageToHost = GetInfoFromConsole("What message would you like to tell your host: ");

                moreGuestsComing = GetInfoFromConsole("Are more guests coming (yes/no): ");

                guests.Add(guest);

                Console.Clear();
            } while (moreGuestsComing.ToLower() == "yes");
        }

        internal static void PrintGuests(List<GuestModel> guests)
        {
            foreach (GuestModel guest in guests)
            {
                Console.WriteLine(guest.GuestInfo);
            }
        }

        internal static string GetInfoFromConsole(string message)
        {
            Console.Write(message);
            string output = Console.ReadLine();
            return output;
        }
    }
}
