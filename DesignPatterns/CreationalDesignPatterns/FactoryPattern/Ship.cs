namespace PracticeCSharp.DesignPatterns.CreationalDesignPatterns.FactoryPattern
{
    internal class Ship : ITransport
    {
        public string Delivery()
        {
            return "Deliverd by sea in a container.";
        }
    }
}