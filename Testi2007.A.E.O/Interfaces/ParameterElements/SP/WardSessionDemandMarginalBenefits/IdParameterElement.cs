namespace Testi2007.A.E.O.Interfaces.ParameterElements.SP.WardSessionDemandMarginalBenefits
{
    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.IndexElements.SP;

    public interface IdParameterElement
    {
        IjIndexElement jIndexElement { get; }

        IkIndexElement kIndexElement { get; }

        FhirDecimal Value { get; }
    }
}