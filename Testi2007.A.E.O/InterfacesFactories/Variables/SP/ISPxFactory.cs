namespace Testi2007.A.E.O.InterfacesFactories.Variables.SP
{
    using OPTANO.Modeling.Optimization;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.IndexElements.SP;
    using Testi2007.A.E.O.Interfaces.Variables.SP;

    public interface ISPxFactory
    {
        ISPx Create(
            VariableCollection<IjIndexElement, IkIndexElement> value);
    }
}