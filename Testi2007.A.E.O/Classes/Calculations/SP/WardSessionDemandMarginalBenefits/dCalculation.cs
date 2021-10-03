namespace Testi2007.A.E.O.Classes.Calculations.SP.WardSessionDemandMarginalBenefits
{
    using System.Collections.Immutable;
    using System.Linq;
 
    using log4net;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.Calculations.SP.WardSessionDemandMarginalBenefits;
    using Testi2007.A.E.O.Interfaces.CrossJoins.SP;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.WardDemands;
    using Testi2007.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using Testi2007.A.E.O.InterfacesFactories.ParameterElements.SP.WardSessionDemandMarginalBenefits;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.SP.WardSessionDemandMarginalBenefits;

    internal sealed class dCalculation : IdCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public dCalculation()
        {
        }

        // d(j,k) = (D(j) - (k - 1)) / (sum(j)D(j))
        public Testi2007.A.E.O.Interfaces.Parameters.SP.WardSessionDemandMarginalBenefits.Id Calculated(
            INullableValueFactory nullableValueFactory,
            IdParameterElementFactory dParameterElementFactory,
            IdFactory dFactory,
            Ijk jk,
            ID D)
        {
            return dFactory.Create(
                jk.Value
                .Select(y => dParameterElementFactory.Create(
                    y.jIndexElement,
                    y.kIndexElement,
                    (FhirDecimal)nullableValueFactory.Create<decimal>(
                        (decimal)(D.GetElementAtAsdecimal(
                            y.jIndexElement)
                            -
                            (y.kIndexElement.Value.Value - 1))
                            /
                            D.GetTotalDemand())))
                .ToImmutableList());
        }
    }
}