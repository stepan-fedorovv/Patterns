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

    public override List<string> GetBusPassengers()
    {
        return _bus.GetArr();
    }

    public override List<string> GetTaxiPassengers()
    {
        return _taxi.GetArr();
    }
}
