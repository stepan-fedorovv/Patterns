namespace Lab3.Lab3;

public class EconomyPassenger:Component
{
    public EconomyPassenger(int luggageWeight)
    {
        if (5 > luggageWeight | luggageWeight > 20)
        {
            throw new ArgumentException("To light or overweight luggage");
        }
        LuggageWeight = luggageWeight;
    }
    private int LuggageWeight { get; set; }

    public override int GetWeight()
    {
        return LuggageWeight;
    }

    public override int ReduceWeight(int reduceBy)
    {
        int weightTookOff = LuggageWeight;
        LuggageWeight = 0;
        Console.WriteLine(String.Format("I'm economy passenger and my {0}kg luggage was left behind\n", weightTookOff));
        return weightTookOff;
    }

    public override int TotalPassenger()
    {
        return 1;
    }
}