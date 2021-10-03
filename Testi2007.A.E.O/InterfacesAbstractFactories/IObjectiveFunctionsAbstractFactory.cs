namespace Testi2007.A.E.O.InterfacesAbstractFactories
{
    using Testi2007.A.E.O.InterfacesFactories.ObjectiveFunctions.SP;
    using Testi2007.A.E.O.InterfacesFactories.ObjectiveFunctions.TP;

    public interface IObjectiveFunctionsAbstractFactory
    {
        ISPObjectiveFunctionFactory CreateSPObjectiveFunctionFactory();

        ITPObjectiveFunctionFactory CreateTPObjectiveFunctionFactory();
    }
}