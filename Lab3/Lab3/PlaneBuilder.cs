namespace Lab3.Lab3;

public class PlaneBuilder
{
    public PlaneBuilder()
    {
        Plane = new Airplane(250, 3000);
        Stewards = new Steward[2];
        FirstClass = new ServiceClass(10);
        BusinessClass = new ServiceClass(10);
        EconomyClass = new ServiceClass(150);
    }
    
    private Airplane Plane { get; set; }
    private Steward[] Stewards { get; set; }
    private  ServiceClass FirstClass { get; set; }
    private  ServiceClass BusinessClass{ get; set; }
    private  ServiceClass EconomyClass{ get; set; }
    
    private Pilot Pilot { get; set; }

    public PlaneBuilder AddSteward(Steward steward)
    {
        if (Stewards[0] == null)
        {
            Stewards[0] = steward;
            return this;
        }
        if (Stewards[1] == null)
        {
            Stewards[1] = steward;
            return this;
        }
        throw new ArgumentException("To much stewards");
    }
    
    public PlaneBuilder AddPilot(Pilot pilot){
        Pilot = pilot;
        return this;
    }
    
    public PlaneBuilder AddFirstClassPassenger(Component passenger)
    {
        if (!FirstClass.AddPassenger(passenger))
        {
            throw new ArgumentException("First class is full");
        }
        return this;
    }

    public PlaneBuilder AddBusinessPassenger(Component passenger)
    {
        if (BusinessClass.AddPassenger(passenger))
        {
            return this;
        }
        else
        {
            if (FirstClass.AddPassenger(passenger))
            {
                Console.WriteLine("Business was full so we put business passenger to 1st class");
                return this;
            }
            else
            {
                throw new ArgumentException("Business and first classes are full");
            }
        }
    }

    public PlaneBuilder AddEconomyPassenger(Component passenger)
    {
        if (EconomyClass.AddPassenger(passenger))
        {
            return this;
        }
        else {
            if (BusinessClass.AddPassenger(passenger)){
                Console.WriteLine("Economy was full so we put economy passenger to business class");
                return this;
            }
            else {
                if(FirstClass.AddPassenger(passenger)){
                    Console.WriteLine("Economy and business was full so we put economy passenger to first class");
                    return this;
                }
                else
                    throw new ArgumentException("Economy, business and first classes are full");
            }
        }
    }
    
    public Airplane build(){
        Plane.AddPassenger(Pilot);
        if (Stewards[0]==null || Stewards[1]==null)
            throw new ArgumentException("Not enough stewards");
        Plane.AddPassenger(Stewards[0]);
        Plane.AddPassenger(Stewards[1]);
        Plane.AddPassenger(FirstClass);
        Plane.AddPassenger(BusinessClass);
        Plane.AddPassenger(EconomyClass);
        return Plane;
    }
}