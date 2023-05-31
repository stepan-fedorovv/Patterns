using Lab5;

class Program
{
    static void Main(string[] args)
    {
        string text = "\t\t\t     .Это текст с лишним  количеством   пробелов, где используются дефисы(-) вместо тире(—),    используются  “кавычки” вместо «кавычек», а также имеются ненужные пробелы ( например, перед запятой ). \n\n\n    Также наблюдается  множественный переход на   новую   строку.";

        EditorContext context = new EditorContext(text);
        string correctedText = context.Execute();

        Console.WriteLine(correctedText);
    }
}
