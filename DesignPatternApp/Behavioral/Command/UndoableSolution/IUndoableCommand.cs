namespace ch.px.designpattern.Behavioral.Command.UndoableSolution;

internal interface IUndoableCommand : ICommand
{
    void Unexecute();
}
