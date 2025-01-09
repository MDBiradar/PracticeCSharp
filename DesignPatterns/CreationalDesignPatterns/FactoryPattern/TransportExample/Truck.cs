namespace PracticeCSharp.DesignPatterns.CreationalDesignPatterns.FactoryPattern.TransportExample
{
    internal class Truck : ITransport
    {
        public string Delivery()
        {
            return "Delivered by land in a box.";
        }
    }
}