using lab_1;

namespace Lab_1.lab1;

public class ConcreteBuilderTaxi : Builder
{
    private Taxi _taxi = new Taxi();
    private Passenger Passenger { get; }

    
    public ConcreteBuilderTaxi(int p)
    {
        Passenger = new Passenger(p);
    }
    
    public override void BuildTaxiChild(int age)
    {
        if (age <= 6)
        {
            _taxi.Add(String.Format("Taxi:\n Passenger ID: {0},Passenger age: {1}, need baby chair",Passenger.Id,age));
            return;
        }
    }

    public override void BuildTaxiAdult(int age)
    {
        if (age > 6)
        {
            _taxi.Add(String.Format("Taxi:\n Passenger ID: {0}, Passenger age: {1}",Passenger.Id,age));
            return;
        }
    }

    public override void BuildBusAdult(int age, bool preferential)
    {
        throw new NotImplementedException();
    }

    public override void BuildBusChild(int age, bool preferential)
    {
        throw new NotImplementedException();
    }

    public override void BuildBusPreferential(bool preferential)
    {
        throw new NotImplementedException();
    }
    
    public override List<string> GetBusPassengers()
    {
        throw new NotImplementedException();
    }

    public override List<string> GetTaxiPassengers()
    {
        return _taxi.GetArr();
    }
}