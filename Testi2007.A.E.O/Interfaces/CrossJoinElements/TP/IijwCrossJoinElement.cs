namespace Testi2007.A.E.O.Interfaces.CrossJoinElements.TP
{
    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.IndexElements.TP;

    public interface IijwCrossJoinElement
    {
        IiIndexElement iIndexElement { get; }

        IjIndexElement jIndexElement { get; }

        IwIndexElement wIndexElement { get; }
    }
}