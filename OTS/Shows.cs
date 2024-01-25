using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

namespace OTS.Shows
{
    /// <summary>
    /// This class is responsible for the user sleecting which show time they want to buy tickets for
    /// </summary>
    public class Show
    {
        public string[] shows = { "14:00, 12/7" , "20:00, 27/7" , "14:00, 28/7" , "20:00, 28/7" , "14:00, 29/7" , "14:00, 30/7" , "14:00, 2/8" , "14:00, 3/8" , "20:00, 3/8" , "14:00, 4/8" , "20:00, 4/8" , "14:00, 5/8" , "14:00, 6/8"};
        bool validShow = false;
        public int showNumber;

        /// <summary>
        /// This method is called b ythe ShowSeat class and it list all the upcoming show timws and asks the user to pick the time of the show they want and stores which show this is to display it back to the user later.
        /// </summary>
        public void UpcomingShows()
        {
            Console.WriteLine("All upcoming showings of GYPSY:");
            for(int i = 0 ; i < shows.Length; i++){
                Console.WriteLine(i+1 + ". " + shows[i]);
            }
            while (validShow == false){
                Console.Write("Enter the number of the show you want to buy tickets for: ");
                showNumber = (Convert.ToInt32(Console.ReadLine())) - 1;
                if (showNumber <= (shows.Length - 1)){
                    validShow = true;
                }
                else{
                    Console.WriteLine("Invalid option, please try again.");
                }
            }
        }
    }
}