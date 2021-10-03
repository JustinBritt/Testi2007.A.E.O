namespace Testi2007.A.E.O.InterfacesAbstractFactories
{
    using Testi2007.A.E.O.InterfacesFactories.Configurations.SP;
    using Testi2007.A.E.O.InterfacesFactories.Configurations.TP;

    public interface IConfigurationsAbstractFactory
    {
        ISPConfigurationFactory CreateSPConfigurationFactory();

        ITPConfigurationFactory CreateTPConfigurationFactory();
    }
}