namespace Testi2007.A.E.O.InterfacesFactories.ParameterElements.SP.WardDemands
{
    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.ParameterElements.SP.WardDemands;

    public interface IDSParameterElementFactory
    {
        IDSParameterElement Create(
            IjIndexElement jIndexElement,
            FhirDecimal value);
    }
}