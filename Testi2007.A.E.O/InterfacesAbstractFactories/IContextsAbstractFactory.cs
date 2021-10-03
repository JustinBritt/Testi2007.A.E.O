namespace Testi2007.A.E.O.InterfacesAbstractFactories
{
    using Testi2007.A.E.O.InterfacesFactories.Contexts.SP;
    using Testi2007.A.E.O.InterfacesFactories.Contexts.TP;

    public interface IContextsAbstractFactory
    {
        ISPInputContextFactory CreateSPInputContextFactory();

        ISPOutputContextFactory CreateSPOutputContextFactory();

        ITPInputContextFactory CreateTPInputContextFactory();

        ITPOutputContextFactory CreateTPOutputContextFactory();
    }
}