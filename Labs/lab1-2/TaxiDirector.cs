namespace Lab_1.lab1;
using lab_1;

public class TaxiDirector
{
    private Builder _builder;

    public TaxiDirector(Builder builder)
    {
        _builder = builder;
    }

    public void ConstructTaxi(int age)
    {
        _builder.BuildTaxiAdult(age);
        _builder.BuildTaxiChild(age);
    }
}