using lab_1;
using Lab_1.lab1;

namespace Lab_1;

public class TaxiTrip
{
    public void StartTrip()
    {
        Console.WriteLine("Write count of passengers in taxi");
        int taxiPassengerCount = Convert.ToUInt16(Console.ReadLine());
        Random random = new Random();
        List<int> taxiArray = new List<int>();
        for (int i = 0; i < taxiPassengerCount; i++)
        {
            Passenger passenger = new Passenger(i);
            Builder builder = new ConcreteBuilderTaxi(i);
            TaxiDirector director = new TaxiDirector(builder);
            director.ConstructTaxi(random.Next(20));
            foreach (var j in builder.GetTaxiPassengers())
            {
                Console.WriteLine(j);
            }
            
            taxiArray.Add(passenger.Id);
        }
        BoardTaxi boardTaxi = new BoardTaxi(true,taxiArray.Count);
        if (boardTaxi.BoardDriver() == false)
        {
            Console.WriteLine("Can't start trip without driver");
            return;
        }
        if (taxiArray.Count > 30 & taxiArray.Count < 1)
        {
            Console.WriteLine("Min count of passenger is 1 and max is 4 ");
            return;
        }
        Console.WriteLine("Count of taxi passengers " + boardTaxi.BoardPassenger() + ", driver is ready");
    }
}