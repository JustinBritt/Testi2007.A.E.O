namespace Testi2007.A.E.O.Interfaces.ParameterElements.SP.WardServiceRates
{
    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;

    public interface IμParameterElement
    {
        IjIndexElement jIndexElement { get; }

        FhirDecimal Value { get; }
    }
}