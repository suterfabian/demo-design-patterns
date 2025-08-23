namespace ch.px.designpattern.Behavioral.Visitor.BadSolution
{
    internal class RetailClient : Client
    {
        public RetailClient(string name, string email) : base(name, email)
        {
        }

        public override void SendEmail()
        {
            Console.WriteLine($"Sending Retail Marketing Tipps via email to {_name}");
        }
    }
}
