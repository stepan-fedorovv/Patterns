using System.Text.RegularExpressions;

namespace Lab5;

public class RemoveMultipleNewlines: IExpression
{
    public string Interpret(string text)
    {
        while (text.Contains("\n\n"))
        {
            text = text.Replace("\n\n","\n");
        }

        return text;
    }
    
}