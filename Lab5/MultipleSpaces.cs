using System.Text.RegularExpressions;

namespace Lab5;

public class MultipleSpaces: IExpression
{
    public string Interpret(string text)
    {
        Regex regex = new Regex(@"[ ]{2,}", RegexOptions.None);
        return regex.Replace(text, " ");
    }
}