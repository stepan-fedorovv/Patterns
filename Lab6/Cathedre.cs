namespace Lab6;

public class Cathedre:Observer
{
    
    public Cathedre()
    {}
    public void Update(Object notMadeReport)
    {
        List<String> teachers = (List<String>)notMadeReport;
        foreach (String teacher in teachers)
        {
            Console.WriteLine("Кафедра узнала, что " + teacher + " не сдал отчет");
        }
    }
}