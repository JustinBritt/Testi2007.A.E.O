namespace Testi2007.A.E.O.InterfacesFactories.Configurations.SP
{
    using OPTANO.Modeling.Optimization.Configuration;

    using Testi2007.A.E.O.Interfaces.Configurations.SP;

    public interface ISPConfigurationFactory
    {
        ISPConfiguration Create(
            Configuration configuration);
    }
}