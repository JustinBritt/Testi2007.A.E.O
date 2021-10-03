namespace Testi2007.A.E.O.Interfaces.ResultElements.SP.SurgeonSessionAssignments
{
    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.IndexElements.SP;

    public interface ISPxResultElement
    {
        IjIndexElement jIndexElement { get; }

        IkIndexElement kIndexElement { get; }

        bool Value { get; }
    }
}