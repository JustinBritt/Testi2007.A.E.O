namespace Testi2007.A.E.O.InterfacesAbstractFactories
{
    using Testi2007.A.E.O.InterfacesFactories.SolverConfigurations;

    public interface ISolverConfigurationsAbstractFactory
    {
        ISolverConfigurationFactory CreateSolverConfigurationFactory();
    }
}