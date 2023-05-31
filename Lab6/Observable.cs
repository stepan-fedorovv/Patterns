namespace Lab6;

public interface Observable
{
    public void AddObserver(Observer observer);
    public bool RemoveObserver(Observer observer);
    public void NotifyObserver();
}