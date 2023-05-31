using lab_1;

namespace Lab_1.lab1;

public class ConcreteBuilderBus : Builder
{
    public ConcreteBuilderBus(int p)
    {
        Passenger = new Passenger(p);
    }

    private Bus _bus = new Bus();

    private Passenger Passenger { get; }

    public override void BuildBusChild(int age, bool preferential)
    {
        if (age <= 18 & preferential == false)
        {
            _bus.Add(String.Format(
                "Bus:\n Passenger ID: {0} , Passenger age: {1}, Type of ticket: Child, Price: 50",
                Passenger.Id, age));
            return;
        }
    }

    public override void BuildBusAdult(int age,bool preferential)
    {
        if (age >= 18 & preferential == false)
        {
            _bus.Add(String.Format("Bus:\n Passenger ID: {0} , Passenger age: {1}, Type of ticket: Adult, Price: 100",
                Passenger.Id, age));
            return;
        }
    }

    public override void BuildBusPreferential(bool preferential)
    {
        if (preferential)
        {
            _bus.Add(String.Format("Bus:\n Passenger ID: {0}, Type of ticket: Preferential, Price: 0",
                Passenger.Id));
            return;
        }
    }

    public override void BuildTaxiAdult(int age)
    {
        throw new NotImplementedException();
    }
    
    public override void BuildTaxiChild(int age)
    {
        throw new NotImplementedException();
    }

    public override List<string> GetTaxiPassengers()
    {
        throw new NotImplementedException();
    }

    public override List<string> GetBusPassengers()
    {
        return _bus.GetArr();
    }
    
}
