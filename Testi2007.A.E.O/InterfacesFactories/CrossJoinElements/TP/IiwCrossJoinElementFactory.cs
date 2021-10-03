namespace Testi2007.A.E.O.InterfacesFactories.CrossJoinElements.TP
{
    using Testi2007.A.E.O.Interfaces.CrossJoinElements.TP;
    using Testi2007.A.E.O.Interfaces.IndexElements.TP;

    public interface IiwCrossJoinElementFactory
    {
        IiwCrossJoinElement Create(
            IiIndexElement iIndexElement,
            IwIndexElement wIndexElement);
    }
}