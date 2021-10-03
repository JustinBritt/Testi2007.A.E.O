namespace Testi2007.A.E.O.InterfacesAbstractFactories
{
    using Testi2007.A.E.O.InterfacesFactories.Indices.Common;
    using Testi2007.A.E.O.InterfacesFactories.Indices.SP;
    using Testi2007.A.E.O.InterfacesFactories.Indices.TP;

    public interface IIndicesAbstractFactory
    {
        IiFactory CreateiFactory();

        IjFactory CreatejFactory();

        IkFactory CreatekFactory();

        IsFactory CreatesFactory();

        IwFactory CreatewFactory();
    }
}