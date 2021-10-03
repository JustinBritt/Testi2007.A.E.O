namespace Testi2007.A.E.O.InterfacesAbstractFactories
{
    using Testi2007.A.E.O.InterfacesFactories.Models.SP;
    using Testi2007.A.E.O.InterfacesFactories.Models.TP;

    public interface IModelsAbstractFactory
    {
        ISPModelFactory CreateSPModelFactory();

        ITPModelFactory CreateTPModelFactory();
    }
}