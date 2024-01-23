using OTS.Consumers;
using OTS.ShowSeats;
using System;

namespace OTS
{
    /// <summary>
    /// 
    /// </summary>
    public static class Program
    {
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