namespace ch.px.designpattern.Behavioral.Visitor.BadSolution
{
    internal class RestaurantClient : Client
    {
        public RestaurantClient(string name, string email) : base(name, email)
        {
        }

        public override void SendEmail()
        {
            Console.WriteLine($"Sending Restaurant Marketing Tipps via email to {_name}");
        }
    }
}
