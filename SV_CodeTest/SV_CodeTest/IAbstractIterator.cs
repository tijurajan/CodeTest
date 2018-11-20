namespace SV_CodeTest
{
    internal interface IAbstractIterator
    {
        Child First();
        Child Next();
        bool IsDone { get; }
        Child CurrentChild { get; }
    }
}