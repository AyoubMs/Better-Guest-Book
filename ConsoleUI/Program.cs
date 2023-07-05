// Capture the information about each guest (assumption is at least one guest and unknown maximum)
// Info to capture: First name, Last name, message to the host
// Once done, loop through each guest and print their info


using ConsoleUI;
using GuestBookLibrary.Models;

List<GuestModel> guests = new List<GuestModel>();

ConsoleUIMethods.GetGuestInformation(guests);

ConsoleUIMethods.PrintGuests(guests);


Console.ReadLine();
