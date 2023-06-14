namespace AppStrategy.Strategy;

public class TransportContext
{
    private readonly ITransportStrategy _strategy;

    public TransportContext(ITransportStrategy strategy)
    {
        _strategy = strategy;
    }

    public void ChooseTransport()
    {
        _strategy.SelectTransport();
    }

}