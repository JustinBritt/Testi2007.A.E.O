namespace Testi2007.A.E.O.Interfaces.CrossJoinElements.SP
{
    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.IndexElements.SP;

    public interface IjkCrossJoinElement
    {
        IjIndexElement jIndexElement { get; }

        IkIndexElement kIndexElement { get; }
    }
}