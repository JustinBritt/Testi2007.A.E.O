namespace Testi2007.A.E.O.InterfacesFactories.ParameterElements.SP.WardServiceRates
{
    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.ParameterElements.SP.WardServiceRates;

    public interface IμParameterElementFactory
    {
        IμParameterElement Create(
            IjIndexElement jIndexElement,
            FhirDecimal value);
    }
}