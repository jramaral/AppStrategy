// See https://aka.ms/new-console-template for more information


using AppStrategy;
using AppStrategy.Strategy;

// var transp = new Transport();
// transp.ChooseTransport("BUS");

SelectTransport(new Car());
SelectTransport(new Bus());
SelectTransport(new Taxi());



Console.WriteLine("Hello, World!");



void SelectTransport(ITransportStrategy transportStrategy)
{
    TransportContext context = new TransportContext(transportStrategy);
    context.ChooseTransport();
}