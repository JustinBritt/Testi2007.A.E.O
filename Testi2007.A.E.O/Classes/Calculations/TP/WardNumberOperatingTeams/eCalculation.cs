namespace Testi2007.A.E.O.Classes.Calculations.TP.WardNumberOperatingTeams
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.Calculations.TP.WardNumberOperatingTeams;
    using Testi2007.A.E.O.Interfaces.Indices.Common;
    using Testi2007.A.E.O.Interfaces.Parameters.TP.WardNumberOperatingTeams;
    using Testi2007.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using Testi2007.A.E.O.InterfacesFactories.ParameterElements.TP.WardNumberOperatingTeams;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.TP.WardNumberOperatingTeams;

    internal sealed class eCalculation : IeCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public eCalculation()
        {
        }

        public Ie Calculatee(
            INullableValueFactory nullableValueFactory,
            IeParameterElementFactory eParameterElementFactory,
            IeFactory eFactory,
            Ij j,
            ImmutableList<Tuple<Organization, Organization>> wardOperatingTeams)
        {
            return eFactory.Create(
                j.Value
                .Select(y => Tuple.Create(
                    y,
                    (PositiveInt)nullableValueFactory.Create<int>(
                        wardOperatingTeams.Where(x => x.Item1 == y).Select(x => x.Item2).Distinct().Count())))
                .Select(y => eParameterElementFactory.Create(
                    y.Item1,
                    y.Item2))
                .ToImmutableList());
        }
    }
}