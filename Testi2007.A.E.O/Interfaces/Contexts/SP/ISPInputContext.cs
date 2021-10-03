namespace Testi2007.A.E.O.Interfaces.Contexts.SP
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    public interface ISPInputContext
    {
        Bundle Wards { get; }

        ImmutableList<PositiveInt> Sessions { get; }

        ImmutableList<Tuple<Organization, FhirDecimal>> WardPastDemands { get; }

        Duration MaximumNumberSessionOverrunHours { get; }

        ImmutableList<Tuple<Organization, PositiveInt>> WardLowerSessionBounds { get; }

        ImmutableList<Tuple<Organization, Duration>> WardOverrunTimes { get; }

        PositiveInt MaximumNumberSessions { get; }

        ImmutableList<Tuple<Organization, FhirDecimal>> WardWaitingListLengths { get; }

        FhirDecimal α { get; }

        FhirDecimal β { get; }

        ImmutableList<Tuple<Organization, FhirDecimal>> WardServiceRates { get; }
    }
}