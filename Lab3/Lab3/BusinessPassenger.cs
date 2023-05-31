namespace Lab3.Lab3;

public class BusinessPassenger : Component
{
    public BusinessPassenger(int luggageWeight)
    {
        if (5 > luggageWeight | luggageWeight > 35)
        {
            throw new ArgumentException("To light or overweight luggage");
        }
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