using lab_1;

namespace Lab_1.lab1;

public class Director
{
    private Builder _builder;

    public Director(Builder builder)
    {
        _builder = builder;

    }

    public void ConstructBus(int age,bool preferential)
    {
        _builder.BuildBusAdult(age,preferential);
        _builder.BuildBusChild(age,preferential);
        _builder.BuildBusPreferential(preferential);
        
        
    }

    public void ConstructTaxi(int age)
    {
        _builder.BuildTaxiChild(age);
        _builder.BuildTaxiAdult(age);
        
    }
    
}