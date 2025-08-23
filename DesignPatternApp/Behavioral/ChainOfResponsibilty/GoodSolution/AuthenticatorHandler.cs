namespace ch.px.designpattern.Behavioral.ChainOfResponsibilty.GoodSolution;

public class AuthenticatorHandler : Handler
{
    public override bool DoHandle(HttpRequest request)
    {
        var username = request.GetUsername();
        var password = request.GetPassword();

        var isValid = username == "kaspar" && password == "123";

        if (isValid)
            Console.WriteLine("Authentifiziert OK");
        else
            Console.WriteLine("Username oder Passwort sind falsch.");

        return !isValid;
    }
}