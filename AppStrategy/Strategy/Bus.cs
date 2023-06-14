namespace AppStrategy.Strategy;

public class Bus : ITransportStrategy
{
    public void SelectTransport()
    {
        Console.WriteLine("User opted to go by BUS");
    }
}