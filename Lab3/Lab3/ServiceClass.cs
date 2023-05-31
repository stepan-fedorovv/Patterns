namespace Lab3.Lab3;

public class ServiceClass : Component
{
    private List<Component> _passengers;

    public ServiceClass(int passengersQuota)
    {
        _passengers = new List<Component>();
        PassengerQuota = passengersQuota;

    }

    public int PassengerQuota { get; }
    
    public bool AddPassenger(Component passenger)
    {
        if (TotalPassenger() + passenger.TotalPassenger() > PassengerQuota)
        {
            return false;
        }
        else
        {
            _passengers.Add(passenger);
            return true;
        }
    }

    public override int GetWeight()
    {
        var total = 0;
        foreach (Component passenger in _passengers)
        {
            total += passenger.GetWeight();
        }
        return total;
    }


    public override int ReduceWeight(int reduceBy)
    {
        var totalReduce = 0;
        foreach (Component passenger in _passengers)
        {
            totalReduce += passenger.ReduceWeight(reduceBy);
            if (totalReduce >= reduceBy)
            {
                break;
            }
        }
        return totalReduce;
    }

    public override int TotalPassenger()
    {
        var total = 0;
        foreach (Component passenger in _passengers)
        {
            total += passenger.TotalPassenger();
        }
        if (total != _passengers.Count)
        {
            Console.WriteLine(String.Format("totalPassengers = {0} size = {1}",total, _passengers.Count));
        }
        return total;
    }

}