namespace Testi2007.A.E.O.InterfacesFactories.SolverConfigurations
{
    using Testi2007.A.E.O.Interfaces.SolverConfigurations;

    public interface ISolverConfigurationFactory
    {
        ISolverConfiguration Create(
            OPTANO.Modeling.Optimization.SolverConfiguration solverConfiguration);
    }
}