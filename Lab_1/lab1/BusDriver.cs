namespace Lab_1;

public class BusDriver
{
    
    public Driver Driver { get; set; }
    public void SetLicense(string typeOfLicense)
    {
        Driver = Driver.GetInstance(typeOfLicense);
    }
    
    public void DeleteLicense()
    {
        Driver = Driver.DeleteInstance();
    }
}