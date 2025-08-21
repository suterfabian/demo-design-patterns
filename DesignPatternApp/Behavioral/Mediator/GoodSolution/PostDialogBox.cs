namespace ch.px.designpattern.Behavioral.Mediator.GoodSolution;
internal class PostDialogBox : DialogBox
{
    private readonly Dictionary<UiControl, Action> _controlHandlers = new();

    private ListBox _postListBox;
    private TextBox _textTitleBox;
    private Button _saveButton;

    public PostDialogBox()
    {
        _postListBox = new ListBox(this);
        _textTitleBox = new TextBox(this);
        _saveButton = new Button(this);
        _saveButton.SetIsEnabled(false);

        _controlHandlers = new Dictionary<UiControl, Action>
        {
            { _postListBox, HandlePostChanged },
            { _textTitleBox, HandleTitleChanged }
            // Weitere Controls können hier einfach ergänzt werden
        };
    }

    public override void Changed(UiControl uiControl)
    {
        if (_controlHandlers.TryGetValue(uiControl, out var handler))
        {
            handler();
        }

        //if (uiControl == _postListBox)
        //{
        //    HandlePostChanged();
        //}
        //else if (uiControl == _textTitleBox)
        //{
        //    HandleTitleChanged();
        //}
    }

    public void SimulateUserInteraction()
    {
        _postListBox.SetSelection("Post 2");
        Console.WriteLine($"Title Text Box: {_textTitleBox.GetText()}");
        Console.WriteLine($"Is Button enabled: {_saveButton.IsEnabled().ToString()}");
    }

    private void HandleTitleChanged()
    {
        var isTitleEmpty = string.IsNullOrWhiteSpace(_textTitleBox.GetText());
        _saveButton.SetIsEnabled(!isTitleEmpty);
    }

    private void HandlePostChanged()
    {
        _textTitleBox.SetText(_postListBox.GetSelection());
        _saveButton.SetIsEnabled(true);
    }
}
