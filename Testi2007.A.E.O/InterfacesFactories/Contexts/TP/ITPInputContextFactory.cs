namespace Testi2007.A.E.O.InterfacesFactories.Contexts.TP
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.Contexts.TP;

    public interface ITPInputContextFactory
    {
        ITPInputContext Create(
            Bundle surgeryRooms,
            Bundle wards,
            ImmutableList<PositiveInt> surgeryRoomTypes,
            ImmutableList<KeyValuePair<PositiveInt, FhirDateTime>> days,
            ImmutableList<Tuple<Organization, Organization>> wardOperatingTeams,
            ImmutableList<Tuple<Location, PositiveInt>> surgeryRoomSubsets,
            ImmutableList<Tuple<Organization, PositiveInt, PositiveInt>> wardSurgeryRoomTypeLowerSessionBounds,
            ImmutableList<Tuple<Organization, PositiveInt>> wardNumberAssignedSessions,
            ImmutableList<Tuple<Organization, FhirDecimal>> wardShortStayWaitingListLengths);
    }
}