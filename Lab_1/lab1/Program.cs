
using System;
using Lab_1;

class Project
{
     protected static void Main()
     {
         //Singleton
         TaxiDriver taxiDriver = new TaxiDriver();
         BusDriver busDriver = new BusDriver();

         taxiDriver.SetLicense("B");
         Console.WriteLine(taxiDriver.Driver.License);
         taxiDriver.DeleteLicense();
         busDriver.SetLicense("D");
         Console.WriteLine(busDriver.Driver.License);
         
         
         //Abstract fabric  
         BusTrip busTrip = new BusTrip();
         busTrip.StartTrip();
         TaxiTrip taxiTrip = new TaxiTrip();
         taxiTrip.StartTrip();
         
         
         BoardTaxi boardTaxi = new BoardTaxi(true, 3);


     }

}