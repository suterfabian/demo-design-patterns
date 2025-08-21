namespace ch.px.designpattern.Behavioral.ChainOfResponsibilty.BadSolution;

internal class Validator
{
    public void Validate(HttpRequest request)
    {
        var username = request.GetUsername();
        var password = request.GetPassword();

        // Trim whitespace
        request.ValidatedUsername = username.Trim();
        request.ValidatedPassword = password.Trim();
    }
}