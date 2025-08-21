namespace ch.px.designpattern.Behavioral.Memento.GoodSolution;

public class History
{
    private List<EditorState> _states = [];
    private Editor _editor;

    public History(Editor editor)
    {
        _editor = editor;
    }

    public void Backup()
    {
        _states.Add(_editor.CreateState());
    }

    public void Undo()
    {
        if (_states.Count == 0)
        {
            return;
        }

        var prevState = _states.Last();
        _states.Remove(prevState);

        _editor.RestoreState(prevState);
    }

    public void ShowHistory()
    {
        Console.WriteLine("History of states:");

        foreach (var state in _states)
        {
            Console.WriteLine(state.GetName());
        }
    }
}
