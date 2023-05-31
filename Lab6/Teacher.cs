namespace Lab6;

public class Teacher: Observable
{
    private List<Observer> _observers;

    public Teacher(string fio)
    {
        _observers = new List<Observer>();
        Fio = fio;
        Report = false;
    }
    
    public string Fio { get; }
    private bool Report { get; set; }

    public void AddObserver(Observer observer)
    {
        _observers.Add(observer);    
    }

    public bool RemoveObserver(Observer observer)
    {
        return _observers.Remove(observer);
    }

    public void NotifyObserver()
    {
        foreach (Observer observer in _observers)
        {
            observer.Update(this);
        }   
    }


    public void CreateReport()
    {
        Console.WriteLine(string.Format("{0} сделал отчет",Fio));
        Report = true;
        NotifyObserver();
    }

    public bool HasReport()
    {
        return Report;
    }
}