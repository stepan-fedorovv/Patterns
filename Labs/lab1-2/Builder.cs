using Lab_1.lab1;

namespace lab_1;

public abstract class Builder
{
    public abstract void BuildBusChild(int age,bool preferential);
    public abstract void BuildBusPreferential(bool preferential);
    public abstract void BuildBusAdult(int age,bool preferential);
    public abstract void BuildTaxiChild(int age);
    public abstract void BuildTaxiAdult(int age);
    public abstract List<string> GetBusPassengers();
    public abstract List<string> GetTaxiPassengers();
}