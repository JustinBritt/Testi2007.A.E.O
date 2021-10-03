namespace Testi2007.A.E.O.Classes.Calculations.SP.WardDemands
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.Calculations.SP.WardDemands;
    using Testi2007.A.E.O.Interfaces.Indices.Common;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.WardServiceRates;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.WardDemands;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.WardWaitingLists;
    using Testi2007.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using Testi2007.A.E.O.InterfacesFactories.ParameterElements.SP.WardDemands;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.SP.WardDemands;

    internal sealed class DLCalculation : IDLCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DLCalculation()
        {
        }

        // DL(j) = WL(j) / μ(j)
        public IDL CalculateDL(
            INullableValueFactory nullableValueFactory,
            IDLParameterElementFactory DLParameterElementFactory,
            IDLFactory DLFactory,
            Ij j,
            IWL WL,
            Iμ μ)
        {
            return DLFactory.Create(
                j.Value
                .Select(y => DLParameterElementFactory.Create(
                    y,
                    (FhirDecimal)nullableValueFactory.Create<decimal>(
                        WL.GetElementAtAsdecimal(
                            y)
                        /
                        μ.GetElementAtAsdecimal(
                            y))))
                .ToImmutableList());
        }
    }
}