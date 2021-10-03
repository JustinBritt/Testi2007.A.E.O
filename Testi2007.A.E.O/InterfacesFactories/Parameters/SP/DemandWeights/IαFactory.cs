namespace Testi2007.A.E.O.InterfacesFactories.Parameters.SP.DemandWeights
{
    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.Parameters.SP.DemandWeights;

    public interface IαFactory
    {
        Iα Create(
            FhirDecimal value);
    }
}