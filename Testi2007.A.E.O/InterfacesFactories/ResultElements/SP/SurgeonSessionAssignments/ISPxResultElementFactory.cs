namespace Testi2007.A.E.O.InterfacesFactories.ResultElements.SP.SurgeonSessionAssignments
{
    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.IndexElements.SP;
    using Testi2007.A.E.O.Interfaces.ResultElements.SP.SurgeonSessionAssignments;

    public interface ISPxResultElementFactory
    {
        ISPxResultElement Create(
            IjIndexElement jIndexElement,
            IkIndexElement kIndexElement,
            bool value);
    }
}