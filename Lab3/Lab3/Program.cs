// See https://aka.ms/new-console-template for more information

using Lab3.Lab3;

public class Program
{
    public static void Main(String[] args)
    {
        Random random = new Random();
        PlaneBuilder planeBuilder = new PlaneBuilder();
        for (int i = 0; i < 7; i++)
        {
            planeBuilder.AddFirstClassPassenger(new FirstClassPassenger(random.Next(55)+5));
        }
        for (int i=0;i<10;i++){
            planeBuilder.AddBusinessPassenger(new BusinessPassenger(random.Next(31)+5));
        }
        for (int i=0;i<150;i++){
            planeBuilder.AddEconomyPassenger(new EconomyPassenger(random.Next(15)+5));
        }
        planeBuilder.AddPilot(new Pilot(0)).AddSteward(new Steward(0)).AddSteward(new Steward(0));
        Airplane plane = planeBuilder.build();
        plane.takeOff();
    }
}