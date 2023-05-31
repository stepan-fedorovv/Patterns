namespace Lab5;

public class EditorContext
{
    private string _text;
    private IExpression[] _expressions;
    
    public EditorContext(string text)
    {
        _text = text;
        _expressions = new IExpression[] { new DashFix(), new FixQuotes(), new MultipleSpaces(), new OddSpace(), new RemoveTabs(), new RemoveMultipleNewlines() };
    }
    
    public string Execute()
    {
        foreach (IExpression expression in _expressions)
        {
            _text = expression.Interpret(_text);
        }
        return _text;
    }
}