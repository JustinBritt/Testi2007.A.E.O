namespace Testi2007.A.E.O.InterfacesFactories.Results.SP.SurgeonSessionAssignments
{
    using System.Collections.Immutable;
  
    using Testi2007.A.E.O.Interfaces.ResultElements.SP.SurgeonSessionAssignments;
    using Testi2007.A.E.O.Interfaces.Results.SP.SurgeonSessionAssignments;

    public interface ISPxFactory
    {
        ISPx Create(
            ImmutableList<ISPxResultElement> value);
    }
}