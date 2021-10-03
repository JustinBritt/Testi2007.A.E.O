namespace Testi2007.A.E.O.InterfacesAbstractFactories
{
    using Testi2007.A.E.O.InterfacesFactories.CrossJoinElements.SP;
    using Testi2007.A.E.O.InterfacesFactories.CrossJoinElements.TP;

    public interface ICrossJoinElementsAbstractFactory
    {
        IijCrossJoinElementFactory CreateijCrossJoinElementFactory();

        IijwCrossJoinElementFactory CreateijwCrossJoinElementFactory();

        IiwCrossJoinElementFactory CreateiwCrossJoinElementFactory();

        IjkCrossJoinElementFactory CreatejkCrossJoinElementFactory();

        IjsCrossJoinElementFactory CreatejsCrossJoinElementFactory();

        IjwCrossJoinElementFactory CreatejwCrossJoinElementFactory();
    }
}