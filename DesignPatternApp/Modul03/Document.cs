namespace ch.px.designpattern.Modul03;
internal class Document
{
    public IState DocumentState { get; set; }
    public UserRoles CurrentUserRole { get; set; }

    public Document(UserRoles currentUserRole)
    {
        DocumentState = new DraftState(this);
        CurrentUserRole = currentUserRole;
    }

    public void Publish()
    {
        DocumentState.Publish();
    }
}