namespace ch.px.designpattern.ChainOfResponsibilty.BadSolution;

internal class Authenticator
{
    public bool Authenticate(HttpRequest request)
    {
        var username = request.GetUsername();
        var password = request.GetPassword();

        return username == "kaspar" && password == "123";
    }
}