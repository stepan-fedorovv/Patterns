namespace Lab_1;

public class Driver
{
    private static Driver instance;
    public string License { get; set; }

    protected Driver(string license)
    {
        this.License = license;
    }

    public static Driver GetInstance(string license)
    {
        if (instance == null)
        {
            instance = new Driver(license);
        }
        return instance;
    }
    public static Driver DeleteInstance()
    {
        instance = null;
        return instance;
    }
}