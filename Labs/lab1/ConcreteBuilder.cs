using lab_1;

namespace Lab_1.lab1;

public class ConcreteBuilder : Builder
{
    public ConcreteBuilder(int p)
    {
        Passenger = new Passenger(p);
    }
    
    private Bus _bus = new Bus();
    private Taxi _taxi = new Taxi();
    
    private Passenger Passenger { get;}

    public override void BuildBus(int age, bool preferential)
    {
        if (preferential)
        {
            _bus.Add( String.Format("Bus:\n Passenger ID: {0} , Passenger age: {1}, Type of ticket: Preferential, Price: 0", Passenger.Id, age));
            return;
        }
        if (age >= 18)
        {
            _bus.Add( String.Format("Bus:\n Passenger ID: {0} , Passenger age: {1}, Type of ticket: Adult, Price: 100", Passenger.Id, age));
            return;
        }
        if (age <= 16)
        {
            _bus.Add( String.Format("Bus:\n Passenger ID: {0} , Passenger age: {1}, Type of ticket: Child, Price: 50", Passenger.Id, age));
            
        }
    }
    

    public override void BuildTaxi(int age)
    {
        if (age >= 12)
        {
            _taxi.Add(String.Format("Taxi\n Passenger ID: {0} , Passenger age: {1} Type of passenger: Adult",
                Passenger.Id, age));
        }
        else
        {
            _taxi.Add(String.Format("Taxi\n Passenger ID: {0} , Passenger age: {1} Type of passenger: Child\n Need a child seat",
                Passenger.Id, age));
        }

    }

    public override List<string> GetBusPassengers()
    {
        return _bus.GetArr();
    }

    public override List<string> GetTaxiPassengers()
    {
        return _taxi.GetArr();
    }
}