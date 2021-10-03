namespace Testi2007.A.E.O.Interfaces.ParameterElements.SP.WardDemands
{
    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;

    public interface IDSParameterElement
    {
        IjIndexElement jIndexElement { get; }

        FhirDecimal Value { get; }
    }
}