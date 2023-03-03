using lab_1;

namespace Lab_1.lab1;

public class Director
{
    private Builder _builder;

    public Director(Builder builder)
    {
        _builder = builder;

    }

    public void Construct(int age,bool preferential)
    {
        _builder.BuildBus(age,preferential);
        _builder.BuildTaxi(age);
        
    }
    
}