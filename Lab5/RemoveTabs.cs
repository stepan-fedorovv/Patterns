namespace Lab5;

public class RemoveTabs: IExpression
{
    public string Interpret(string text)
    {
        return text.Replace("\t", " ");
    }  
}