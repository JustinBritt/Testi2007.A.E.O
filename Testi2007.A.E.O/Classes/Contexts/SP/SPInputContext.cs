namespace Testi2007.A.E.O.Classes.Contexts.SP
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.Contexts.SP;

    internal sealed class SPInputContext : ISPInputContext
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SPInputContext(
            Bundle wards,
            ImmutableList<PositiveInt> sessions,
            ImmutableList<Tuple<Organization, FhirDecimal>> wardPastDemands,
            Duration maximumNumberSessionOverrunHours,
            ImmutableList<Tuple<Organization, PositiveInt>> wardLowerSessionBounds,
            ImmutableList<Tuple<Organization, Duration>> wardOverrunTimes,
            PositiveInt maximumNumberSessions,
            ImmutableList<Tuple<Organization, FhirDecimal>> wardWaitingListLengths,
            FhirDecimal α,
            FhirDecimal β,
            ImmutableList<Tuple<Organization, FhirDecimal>> wardServiceRates)
        {
            this.Wards = wards;

            this.Sessions = sessions;

            this.WardPastDemands = wardPastDemands;

            this.MaximumNumberSessionOverrunHours = maximumNumberSessionOverrunHours;

            this.WardLowerSessionBounds = wardLowerSessionBounds;

            this.WardOverrunTimes = wardOverrunTimes;

            this.MaximumNumberSessions = maximumNumberSessions;

            this.WardWaitingListLengths = wardWaitingListLengths;

            this.α = α;

            this.β = β;

            this.WardServiceRates = wardServiceRates;
        }

        public Bundle Wards { get; }

        public ImmutableList<PositiveInt> Sessions { get; }

        public ImmutableList<Tuple<Organization, FhirDecimal>> WardPastDemands { get; }

        public Duration MaximumNumberSessionOverrunHours { get; }

        public ImmutableList<Tuple<Organization, PositiveInt>> WardLowerSessionBounds { get; }

        public ImmutableList<Tuple<Organization, Duration>> WardOverrunTimes { get; }

        public PositiveInt MaximumNumberSessions { get; }

        public ImmutableList<Tuple<Organization, FhirDecimal>> WardWaitingListLengths { get; }

        public FhirDecimal α { get; }

        public FhirDecimal β { get; }

        public ImmutableList<Tuple<Organization, FhirDecimal>> WardServiceRates { get; }
    }
}