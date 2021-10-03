namespace Testi2007.A.E.O.InterfacesFactories.Variables.TP
{
    using OPTANO.Modeling.Optimization;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.IndexElements.TP;
    using Testi2007.A.E.O.Interfaces.Variables.TP;

    public interface ITPxFactory
    {
        ITPx Create(
            VariableCollection<IiIndexElement, IjIndexElement, IwIndexElement> value);
    }
}