namespace ch.px.designpattern.Behavioral.Interpreter.GoodSolution;

internal class Interpreter
{
    private Context _context;

    public Interpreter(Context context)
    {
        _context = context;
    }

    public int Interpret(string expression)
    {
        IExpression expressionTree = BuildExpressionTree(expression);
        return expressionTree.Interpret(_context);
    }

    // 1 + 2 * 3
    private IExpression BuildExpressionTree(string input)
    {
        input = "1 + 2 * 3";

        IExpression expressionTree = new AdditionExpression(
            new MultiplicationExpression(
                new NumberExpression("2"),
                new NumberExpression("3")
            ),
            new NumberExpression("1")
        );

        return expressionTree;
    }
}
