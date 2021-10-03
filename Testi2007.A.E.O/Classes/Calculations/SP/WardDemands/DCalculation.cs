namespace Testi2007.A.E.O.Classes.Calculations.SP.WardDemands
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.Calculations.SP.WardDemands;
    using Testi2007.A.E.O.Interfaces.Indices.Common;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.DemandWeights;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.WardDemands;
    using Testi2007.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using Testi2007.A.E.O.InterfacesFactories.ParameterElements.SP.WardDemands;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.SP.WardDemands;

    internal sealed class DCalculation : IDCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DCalculation()
        {
        }

        // D(j) = (α)(DS(j)) + (β)(DL(j)), where α + β = 1
        public ID CalculateD(
            INullableValueFactory nullableValueFactory,
            IDParameterElementFactory DParameterElementFactory,
            IDFactory DFactory,
            Ij j,
            IDL DL,
            IDS DS,
            Iα α,
            Iβ β)
        {
            return DFactory.Create(
                j.Value
                .Select(y => DParameterElementFactory.Create(
                    y,
                    (FhirDecimal)nullableValueFactory.Create<decimal>(
                        α.Value.Value.Value
                        +
                        DS.GetElementAtAsdecimal(
                            y)
                        +
                        β.Value.Value.Value
                        +
                        DL.GetElementAtAsdecimal(
                            y))))
                .ToImmutableList());
        }
    }
}