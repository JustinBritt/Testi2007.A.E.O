namespace Testi2007.A.E.O.InterfacesFactories.Contexts.SP
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.Contexts.SP;

    public interface ISPInputContextFactory
    {
        ISPInputContext Create(
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
            ImmutableList<Tuple<Organization, FhirDecimal>> wardServiceRates);
    }
}