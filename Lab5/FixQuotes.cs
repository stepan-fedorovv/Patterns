using System.Text;

namespace Lab5;

public class FixQuotes: IExpression
{
    
    public string Interpret(string text)
    {
        return text.Replace('“', '«').Replace('”', '»');
    } 
}
