namespace Testi2007.A.E.O.Interfaces.Variables.SP
{
    using OPTANO.Modeling.Optimization;

    using Testi2007.A.E.O.Interfaces.CrossJoins.SP;
    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.IndexElements.SP;
    using Testi2007.A.E.O.InterfacesFactories.ResultElements.SP.SurgeonSessionAssignments;
    using Testi2007.A.E.O.InterfacesFactories.Results.SP.SurgeonSessionAssignments;

    public interface ISPx
    {
        VariableCollection<IjIndexElement, IkIndexElement> Value { get; }

        bool GetElementAt(
            IjIndexElement jIndexElement,
            IkIndexElement kIndexElement);

        Interfaces.Results.SP.SurgeonSessionAssignments.ISPx GetElementsAt(
            ISPxResultElementFactory SPxResultElementFactory,
            ISPxFactory SPxFactory,
            Ijk jk);
    }
}