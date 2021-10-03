namespace Testi2007.A.E.O.Interfaces.Calculations.SP.WardDemands
{
    using Testi2007.A.E.O.Interfaces.Indices.Common;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.DemandWeights;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.WardDemands;
    using Testi2007.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using Testi2007.A.E.O.InterfacesFactories.ParameterElements.SP.WardDemands;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.SP.WardDemands;

    public interface IDCalculation
    {
        ID CalculateD(
            INullableValueFactory nullableValueFactory,
            IDParameterElementFactory DParameterElementFactory,
            IDFactory DFactory,
            Ij j,
            IDL DL,
            IDS DS,
            Iα α,
            Iβ β);
    }
}