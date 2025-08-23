namespace ch.px.designpattern.Behavioral.Interpreter.GoodSolution;

internal class Interpreter2
{
    private Context _context;

    public Interpreter2(Context context)
    {
        _context = context;
    }

    public int Interpret(string expression)
    {
        IExpression expressionTree = BuildExpressionTree(expression);
        return expressionTree.Interpret(_context);
    }

    // 1 + 4 - 3
    private IExpression BuildExpressionTree(string input)
    {
        string[] tokens = input.Split(" ");
        var output = new Queue<string>();
        var operators = new Stack<string>();

        // Shunting Yard Algorithm to convert infix to postfix
        foreach (var token in tokens)
        {
            if (int.TryParse(token, out _))
            {
                output.Enqueue(token);
            }
            else if (token == "+" || token == "-")
            {
                while (operators.Count > 0 && (operators.Peek() == "+" || operators.Peek() == "-"))
                {
                    output.Enqueue(operators.Pop());
                }

                operators.Push(token);
            }
        }

        while (operators.Count > 0)
        {
            output.Enqueue(operators.Pop());
        }

        var expressionStack = new Stack<IExpression>();

        while (output.Count > 0)
        {
            var token = output.Dequeue();

            if (int.TryParse(token, out int number))
            {
                expressionStack.Push(new NumberExpression(number));
            }
            else if (token == "+" || token == "-")
            {
                var right = expressionStack.Pop();
                var left = expressionStack.Pop();

                if (token == "+")
                {
                    expressionStack.Push(new AdditionExpression(left, right));
                }
                else if (token == "-")
                {
                    expressionStack.Push(new SubstractionExpression(left, right));
                }
            }
        }

        return expressionStack.Pop();
    }
}
