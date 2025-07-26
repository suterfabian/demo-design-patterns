namespace ch.px.designpattern.Modul03;

public class BadDocument
{
    public DocumentStates State { get; set; }
    public UserRoles CurrentUserRole { get; set; }

    public void Publish()
    {
        if (State == DocumentStates.Draft)
        {
            State = DocumentStates.Moderation;
        }
        else if (State == DocumentStates.Moderation)
        {
            if (CurrentUserRole == UserRoles.Admin)
            {
                State = DocumentStates.Published;
            }
        }
        else if (State == DocumentStates.Published)
        {
            // Do Nothing, we are in the highest possible state
        }
    }
}