namespace ch.px.designpattern.Behavioral.ChainOfResponsibilty.GoodSolution;

public class HttpRequest
{
    private string _username;
    private string _password;
    public string ValidatedUsername { get; set; } = string.Empty;
    public string ValidatedPassword { get; set; } = string.Empty;

    public HttpRequest(string username, string password)
    {
        _username = username;
        _password = password;
    }

    public string GetUsername()
    {
        return _username;
    }

    public string GetPassword()
    {
        return _password;
    }
}