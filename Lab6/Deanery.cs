namespace Lab6;

public class Deanery: Observer, Observable
{
    private List<String> teachers;
    private List<Observer> _observers;
    private List<Teacher> MadeReport;
    private List<String> NotMadeReport;


    public Deanery(List<String> Teachers)
    {
        MadeReport = new List<Teacher>();
        teachers = Teachers;
        _observers = new List<Observer>();
    }

    public void Update(Object o)
    {
        Teacher teacher = (Teacher) o;
        if (teacher.HasReport())
        {
            MadeReport.Add(teacher);
        }
    }


    public void ItsTime()
    {
        NotMadeReport=new List<String>(teachers);
        foreach (Teacher teacher in MadeReport){
            NotMadeReport.Remove(teacher.Fio);
        }
        foreach (String teacher in NotMadeReport)
            Console.WriteLine("Деканат узнал о том, что преподаватель " + teacher + " не сдал отчёт");
        NotifyObserver();
    }

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
            observer.Update(NotMadeReport);
        }
    }
}