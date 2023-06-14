namespace AppStrategy.Strategy;

public class Car : ITransportStrategy
{
    public void SelectTransport()
    {
        Console.WriteLine("User opted to go by CAR");
    }
}