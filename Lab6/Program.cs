
using Lab6;

public class Program
{
    public static void Main(String[] args)
    {
        List<String> teachersList = new List<string>{"Fedorov Alexey Roaldovich","Garashenko Anton Vitalevich", "Garashenko Alina Vitalevna"};
        Cathedre cathedre = new Cathedre();
        Deanery deanery = new Deanery(teachersList);
        deanery.AddObserver(cathedre);
        Teacher teacher1 = new Teacher("Fedorov Alexey Roaldovich");
        Teacher teacher2 = new Teacher("Garashenko Anton Vitalevich");
        Teacher teacher3 = new Teacher("Garashenko Alina Vitalevna");
        teacher1.AddObserver(deanery);
        teacher2.AddObserver(deanery);
        teacher3.AddObserver(deanery);
        teacher1.CreateReport();
        teacher2.CreateReport();
        deanery.ItsTime();
    }
}
