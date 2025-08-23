namespace ch.px.designpattern.Behavioral.ChainOfResponsibilty.GoodSolution;

public class ValidatorHandler : Handler
{
    public override bool DoHandle(HttpRequest request)
    {
        var username = request.GetUsername();
        var password = request.GetPassword();

        // Trim whitespace
        request.ValidatedUsername = username.Trim();
        request.ValidatedPassword = password.Trim();

        var isValid = request.ValidatedUsername == "" || request.ValidatedPassword == "";

        if (isValid)
            Console.WriteLine("Kein Username oder kein Passwort");
        else
            Console.WriteLine("Username und Passwort sind vorhanden.");

        return isValid;
    }
}