using System;
using GarageConsoleApp;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main()
        {
            DatabaseRequests.GetTypeCarQuery();
            // DatabaseRequests.AddTypeCarQuery("Водный");
            Console.WriteLine();
            DatabaseRequests.GetDriverQuery();
            // DatabaseRequests.AddDriverQuery("Chelovek", "Chelovekovich", new DateTime(2003, 12, 12));
            Console.WriteLine();
            DatabaseRequests.GetDriverRightsCategoryQuery(1);
            // DatabaseRequests.AddDriverRightsCategoryQuery(1,2);
            Console.WriteLine();
            DatabaseRequests.GetCarQuery(); 
            // DatabaseRequests.AddCarQuery(2,"DeLorean DMC-12", "FUTURE70", 3);
            Console.WriteLine();
            DatabaseRequests.GetItineraryQuery();
            // DatabaseRequests.AddItineraryQuery("Из прошлого", "В будущее");
            Console.WriteLine();
            DatabaseRequests.GetRouteQuery();
            // DatabaseRequests.AddRouteQuery(3,6,7,2);
        }
    }
}