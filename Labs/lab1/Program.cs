

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
         busDriver.SetLicense("D");
         Console.WriteLine(busDriver.Driver.License);
         Console.WriteLine("##################");
         
         //Abstract fabric  
         BusTrip busTrip = new BusTrip();
         busTrip.StartTrip();
         TaxiTrip taxiTrip = new TaxiTrip();
         taxiTrip.StartTrip();
         
         
         


     }

}