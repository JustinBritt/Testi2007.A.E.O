namespace Testi2007.A.E.O.InterfacesAbstractFactories
{
    using Testi2007.A.E.O.InterfacesFactories.Solutions.SP;
    using Testi2007.A.E.O.InterfacesFactories.Solutions.TP;

    public interface ISolutionsAbstractFactory
    {
        ISPSolutionFactory CreateSPSolutionFactory();

        ITPSolutionFactory CreateTPSolutionFactory();
    }
}