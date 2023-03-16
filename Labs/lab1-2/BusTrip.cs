using System.Collections.Immutable;
using lab_1;
using Lab_1.lab1;

namespace Lab_1;

public class BusTrip
{
    public void StartTrip()
    {
        Console.WriteLine("Write count of passengers in bus");
        Random random = new Random();
        int busPassengerCount = Convert.ToUInt16(Console.ReadLine());
        List<int> busArray = new List<int>();
        for (int i = 0; i < busPassengerCount; i++)
        {
            Passenger passenger = new Passenger(i);
            Builder builder = new ConcreteBuilder(i);
            Director director = new Director(builder);
            director.ConstructBus(random.Next(20),random.Next(2)==1);
            foreach (var j in builder.GetBusPassengers())
            {
                Console.WriteLine(j);
            }
            busArray.Add(passenger.Id);
        }
        

        BoardBus boardBus = new BoardBus(true, busArray.Count);
        if (boardBus.BoardDriver() == false)
        {
            Console.WriteLine("Can't start trip without driver");
            return;
        }

        if (busArray.Count > 30 & busArray.Count < 1)
        {
            Console.WriteLine("Min count of passenger is 1 and max is 30 ");
            return;
        }

        if (busArray.Count <= 30)
        {
            Console.WriteLine("Count of bus passengers " + boardBus.BoardPassenger() + ", driver is ready");
        }


    }
    
}