namespace Testi2007.A.E.O.InterfacesAbstractFactories
{
    using Testi2007.A.E.O.InterfacesFactories.IndexElements.Common;
    using Testi2007.A.E.O.InterfacesFactories.IndexElements.SP;
    using Testi2007.A.E.O.InterfacesFactories.IndexElements.TP;

    public interface IIndexElementsAbstractFactory
    {
        IiIndexElementFactory CreateiIndexElementFactory();

        IjIndexElementFactory CreatejIndexElementFactory();

        IkIndexElementFactory CreatekIndexElementFactory();

        IsIndexElementFactory CreatesIndexElementFactory();

        IwIndexElementFactory CreatewIndexElementFactory();
    }
}