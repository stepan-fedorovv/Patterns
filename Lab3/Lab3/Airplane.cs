namespace Lab3.Lab3;

public class Airplane : Component
{
    private List<Component> _passengers;
    public Airplane(int passengersQuota, int luggageWeightQuota)
    {
        _passengers = new List<Component>();
        LuggageWeightQuota = luggageWeightQuota;
        PassengersQuota = passengersQuota;
    }
    
    private int PassengersQuota { get; }
    private int LuggageWeightQuota { get; }


    public bool AddPassenger(Component passenger)
    {
        if (passenger.TotalPassenger() + TotalPassenger() > PassengersQuota)
        {
            return false;
        }
        else
        {
            _passengers.Add(passenger);
            return true;
        }
        
    }


    public bool takeOff()
    {
        if (PassengersQuota >= TotalPassenger() && LuggageWeightQuota >= this.GetWeight())
        {
            Console.WriteLine(String.Format("Took off successfully. Weight {0}kG/{1}kG, Passengers {2}/{3}",this.GetWeight(),LuggageWeightQuota,this.TotalPassenger(),PassengersQuota));
            return true;
        }
        else
        {
            if (PassengersQuota < TotalPassenger())
            {
                throw new ArgumentException("Too much passengers");
            }

            if (this.GetWeight() > LuggageWeightQuota)
            {
                Console.WriteLine(String.Format("Luggage overweight ({0}kG/{1}kG)! Drop off started", this.GetWeight(), LuggageWeightQuota));
                int dropedOff = ReduceWeight(GetWeight() - LuggageWeightQuota);
                if (this.GetWeight() <= LuggageWeightQuota)
                {
                    Console.WriteLine(String.Format("Took off successfully. Weight {0}kG/{1}kG. Passengers {2}/{3}.Droped {4} of luggage",
                        this.GetWeight(),this.LuggageWeightQuota,this.TotalPassenger(),PassengersQuota,dropedOff));
                    return true;
                }
                else
                {
                    Console.WriteLine(String.Format("Unable to take off! Dropped off {0}kG. Airplane is still overweight ({1}/{2})!",dropedOff,this.GetWeight(),this.LuggageWeightQuota));
                    return false;
                }
            }
            Console.WriteLine("Can't be here");
            return false;
        }
    }

    public override int GetWeight()
    {
        int total = 0;
        foreach (Component passenger in _passengers)
        {
            total += passenger.GetWeight();
        }

        return total;
    }

    public override int ReduceWeight(int reduceBy)
    {
        int totalReduce = 0;
        foreach (Component passenger in _passengers)
        {
            totalReduce += passenger.ReduceWeight(reduceBy - totalReduce);
            if (totalReduce >= reduceBy)
                break;
        }
        return totalReduce;
    }
    

    public override int TotalPassenger() 
    {
        int total = 0;
        foreach (var passenger in _passengers) {
            total += passenger.TotalPassenger();
        }
        return total;
    }
}