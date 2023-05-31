namespace Lab5;

public class DashFix: IExpression
{
    public string Interpret(string text)
    {
        return text.Replace("-", "—");
    }
    
}