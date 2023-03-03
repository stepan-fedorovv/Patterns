namespace Lab_1.lab1;

public class Taxi
{
    private List<string> passengers = new List<string>();

    public void Add(string passenger)
    {
        passengers.Add(passenger);
    }
    
    public List<string> GetArr()
    {
        return passengers;
    }
}