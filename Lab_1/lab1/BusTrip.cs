namespace Lab_1;

public class BusTrip
{
    public void StartTrip()
    {
        Console.WriteLine("Write count of passengers in bus");
        int busPassengerCount = Convert.ToUInt16(Console.ReadLine());
        List<int> busArray = new List<int>();
        for (int i = 0; i < busPassengerCount; i++)
        {
            Passenger passenger = new Passenger(i);
            busArray.Add(passenger.Id);
        }
        BoardBus boardBus = new BoardBus(true,busArray.Count);
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
        Console.WriteLine("Count of bus passengers " + boardBus.BoardPassenger() + ", driver is ready");
    }
}