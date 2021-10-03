namespace Testi2007.A.E.O.InterfacesAbstractFactories
{
    using Testi2007.A.E.O.InterfacesFactories.CrossJoins.SP;
    using Testi2007.A.E.O.InterfacesFactories.CrossJoins.TP;

    public interface ICrossJoinsAbstractFactory
    {
        IijFactory CreateijFactory();

        IijwFactory CreateijwFactory();

        IiwFactory CreateiwFactory();

        IjkFactory CreatejkFactory();

        IjsFactory CreatejsFactory();

        IjwFactory CreatejwFactory();
    }
}