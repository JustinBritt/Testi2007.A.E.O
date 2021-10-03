namespace Testi2007.A.E.O.Interfaces.ParameterElements.SP.WardWaitingLists
{
    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;

    public interface IWLParameterElement
    {
        IjIndexElement jIndexElement { get; }

        FhirDecimal Value { get; }
    }
}