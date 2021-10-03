namespace Testi2007.A.E.O.InterfacesFactories.Configurations.TP
{
    using OPTANO.Modeling.Optimization.Configuration;

    using Testi2007.A.E.O.Interfaces.Configurations.TP;

    public interface ITPConfigurationFactory
    {
        ITPConfiguration Create(
            Configuration configuration);
    }
}