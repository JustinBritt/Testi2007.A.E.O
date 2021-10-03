namespace Testi2007.A.E.O.Interfaces.Calculations.SP.WardSessionDemandMarginalBenefits
{
    using Testi2007.A.E.O.Interfaces.CrossJoins.SP;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.WardDemands;
    using Testi2007.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using Testi2007.A.E.O.InterfacesFactories.ParameterElements.SP.WardSessionDemandMarginalBenefits;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.SP.WardSessionDemandMarginalBenefits;

    public interface IdCalculation
    {
        Testi2007.A.E.O.Interfaces.Parameters.SP.WardSessionDemandMarginalBenefits.Id Calculated(
            INullableValueFactory nullableValueFactory,
            IdParameterElementFactory dParameterElementFactory,
            IdFactory dFactory,
            Ijk jk,
            ID D);
    }
}