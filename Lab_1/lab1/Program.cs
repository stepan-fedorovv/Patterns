
using System;
using Lab_1;

class Project
{
     protected static void Main()
     {
         BusTrip busTrip = new BusTrip();
         busTrip.StartTrip();
         TaxiTrip taxiTrip = new TaxiTrip();
         taxiTrip.StartTrip();
         
         
         BoardTaxi boardTaxi = new BoardTaxi(true, 3);


     }

}