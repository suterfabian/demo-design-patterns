namespace ch.px.designpattern.Behavioral.Memento.GoodSolution;

// Originator
public class Editor
{
    public string Title { get; set; } = null!;
    public string Content { get; set; } = null!;

    public EditorState CreateState()
    {
        return new EditorState(Title, Content);
    }

    public void RestoreState(EditorState state)
    {
        Title = state.GetTitle();
        Content = state.GetContent();
    }
}