using OTS.Consumers;
using OTS.ShowSeats;
using System;

namespace OTS
{
    /// <summary>
    /// This class calls the methods from the other classes when the porgram is run.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This method is the main method for this class and it calls the methods from other classes.
        /// </summary>
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Online Ticketing System for The Bucks Centre for the Performing Arts\n");
            Consumer consumer = new Consumer();
            consumer.Run();
            ShowSeat showSeat = new ShowSeat();
            showSeat.Run();
        }
    }
}