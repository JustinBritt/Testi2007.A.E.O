namespace Testi2007.A.E.O.Interfaces.Calculations.SP.WardDemands
{
    using Testi2007.A.E.O.Interfaces.Indices.Common;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.WardServiceRates;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.WardDemands;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.WardWaitingLists;
    using Testi2007.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using Testi2007.A.E.O.InterfacesFactories.ParameterElements.SP.WardDemands;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.SP.WardDemands;

    public interface IDLCalculation
    {
        IDL CalculateDL(
            INullableValueFactory nullableValueFactory,
            IDLParameterElementFactory DLParameterElementFactory,
            IDLFactory DLFactory,
            Ij j,
            IWL WL,
            Iμ μ);
    }
}