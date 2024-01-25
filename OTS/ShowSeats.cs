using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

namespace OTS.ShowSeats
{
    /// <summary>
    /// This class is responsible for the user selecting the amount of seats they want for the show they've selected
    /// </summary>
    public class ShowSeat : Shows.Show
    {
        int adultSeats;
        int childSeats;
        int studentSeats;
        int seniorSeats;
        double adultPrice = 20.00;
        double childPrice = 10.00;
        double studentPrice = 17.50;
        double seniorPrice = 13.50;
        double totalCost;

        /// <summary>
        /// This method is the main method for this class and it calls the method for the user to pick a show and then the method for the user to select the amount of tickets they want
        /// </summary>
        public void Run()
        {
            UpcomingShows();
            SelectSeats();
        }

        /// <summary>
        /// This method is called after the user has selected they show they want to see and it allows the user to enter the number of each ticket type they want, as well as reiterate it back to them, as well as the show time they selected.
        /// It also calculates the total cost of all the tickets and displays it to the user.
        /// </summary>
        public void SelectSeats()
        {
            Console.Write("Enter the number of adult tickets you want to purchase (£" + adultPrice + " each):");
            adultSeats = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of child tickets you want to purchase (£" + childPrice + " each):");
            childSeats = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of student tickets you want to purchase (£" + studentPrice + " each):");
            studentSeats = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of senior citizen tickets you want to purchase (£" + seniorPrice + " each):");
            seniorSeats = Convert.ToInt32(Console.ReadLine());
            totalCost = (adultSeats * adultPrice) + (childSeats * childPrice) + (studentSeats * studentPrice) + (seniorSeats * seniorPrice);
            Console.WriteLine("You are purchasing " + adultSeats + " adult tickets, " + childSeats + " child tickets, " + studentSeats + " student tickets and " + seniorSeats + " senior citizen tickets for the " + shows[showNumber] + " showing of GYPSY");
            Console.WriteLine("The total cost is £" + totalCost);
        }
    }
}