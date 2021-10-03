namespace Testi2007.A.E.O.InterfacesFactories.ParameterElements.SP.WardWaitingLists
{
    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.ParameterElements.SP.WardWaitingLists;

    public interface IWLParameterElementFactory
    {
        IWLParameterElement Create(
            IjIndexElement jIndexElement,
            FhirDecimal value);
    }
}