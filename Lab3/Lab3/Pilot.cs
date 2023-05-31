namespace Lab3.Lab3;

public class Pilot : Component
{
    public Pilot(int luggageWeight)
    {
        LuggageWeight = luggageWeight;
    }
    private int LuggageWeight { get; }

    public override int GetWeight()
    {
        return LuggageWeight;
    }

    public override int ReduceWeight(int reduceBy)
    {
        return 0;
    }

    public override int TotalPassenger()
    {
        return 1;
    }
    
    
}