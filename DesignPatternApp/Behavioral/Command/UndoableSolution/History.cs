namespace ch.px.designpattern.Behavioral.Command.UndoableSolution;

internal class History
{
    private readonly Stack<IUndoableCommand> _commands = new();

    public void Push(IUndoableCommand command) => _commands.Push(command);

    public IUndoableCommand Pop() => _commands.Pop();

    public int Size => _commands.Count;
}
