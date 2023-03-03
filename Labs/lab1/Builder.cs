using Lab_1.lab1;

namespace lab_1;

public abstract class Builder
{
    public abstract void BuildBus(int age,bool preferential);
    public abstract void BuildTaxi(int age);
    public abstract List<string> GetBusPassengers();
    public abstract List<string> GetTaxiPassengers();
}