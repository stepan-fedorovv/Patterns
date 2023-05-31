namespace Lab5;

public class OddSpace: IExpression
{
    public string Interpret(string text)
    {
        text = text.Replace(" ,", ",");
        text = text.Replace(" .", ".");
        text = text.Replace("( ", "(");
        text = text.Replace(" )", ")");
        
        return text;
    }
    
}