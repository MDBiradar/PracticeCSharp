namespace PracticeCSharp.DesignPatterns.CreationalDesignPatterns.PrototypePattern
{
    internal interface ICar
    {
        void ShowDetails(string str);
        ICar Clone();
    }
}
