namespace PracticeCSharp.DesignPatterns.CreationalDesignPatterns.FactoryPattern.TransportExample
{
    internal class Ship : ITransport
    {
        public string Delivery()
        {
            return "Deliverd by sea in a container.";
        }
    }
}