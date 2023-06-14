namespace AppStrategy.Strategy;

public class Taxi : ITransportStrategy
{
    public void SelectTransport()
    {
        Console.WriteLine("User opted to go by TAXI");
    }
}