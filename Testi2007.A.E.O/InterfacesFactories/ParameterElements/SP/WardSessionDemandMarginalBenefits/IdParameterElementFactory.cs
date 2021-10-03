namespace Testi2007.A.E.O.InterfacesFactories.ParameterElements.SP.WardSessionDemandMarginalBenefits
{
    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.IndexElements.SP;
    using Testi2007.A.E.O.Interfaces.ParameterElements.SP.WardSessionDemandMarginalBenefits;

    public interface IdParameterElementFactory
    {
        IdParameterElement Create(
            IjIndexElement jIndexElement,
            IkIndexElement kIndexElement,
            FhirDecimal value);
    }
}