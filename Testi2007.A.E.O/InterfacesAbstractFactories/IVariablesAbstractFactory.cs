namespace Testi2007.A.E.O.InterfacesAbstractFactories
{
    public interface IVariablesAbstractFactory
    {
        Testi2007.A.E.O.InterfacesFactories.Variables.SP.ISPxFactory CreateSPxFactory();

        Testi2007.A.E.O.InterfacesFactories.Variables.TP.ITPxFactory CreateTPxFactory();
    }
}