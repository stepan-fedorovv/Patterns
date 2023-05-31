using lab_1;

namespace Lab_1.lab1;

public class BusDirector
{
    private Builder _builder;

    public BusDirector(Builder builder)
    {
        _builder = builder;

    }

    public void ConstructBus(int age,bool preferential)
    {
        _builder.BuildBusAdult(age,preferential);
        _builder.BuildBusChild(age,preferential);
        _builder.BuildBusPreferential(preferential);
    }
}