namespace Testi2007.A.E.O.Interfaces.Contexts.TP
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    public interface ITPInputContext
    {
        Bundle SurgeryRooms { get; }

        Bundle Wards { get; }

        ImmutableList<PositiveInt> SurgeryRoomTypes { get; }

        ImmutableList<KeyValuePair<PositiveInt, FhirDateTime>> Days { get; }

        ImmutableList<Tuple<Organization, Organization>> WardOperatingTeams { get; }

        ImmutableList<Tuple<Location, PositiveInt>> SurgeryRoomSubsets { get; }

        ImmutableList<Tuple<Organization, PositiveInt, PositiveInt>> WardSurgeryRoomTypeLowerSessionBounds { get; }

        ImmutableList<Tuple<Organization, PositiveInt>> WardNumberAssignedSessions { get; }

        ImmutableList<Tuple<Organization, FhirDecimal>> WardShortStayWaitingListLengths { get; }
    }
}