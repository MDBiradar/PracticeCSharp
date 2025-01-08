namespace PracticeCSharp.DesignPatterns.CreationalDesignPatterns.FactoryPattern
{
    internal class Truck : ITransport
    {
        public string Delivery()
        {
            return "Delivered by land in a box.";
        }
    }
}