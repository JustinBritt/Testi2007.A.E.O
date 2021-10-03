namespace Testi2007.A.E.O.Interfaces.ParameterElements.TP.WardWaitingLists
{
    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;

    public interface IWLSSParameterElement
    {
        IjIndexElement jIndexElement { get; }

        FhirDecimal Value { get; }
    }
}