namespace Testi2007.A.E.O.Classes.Contexts.TP
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.Contexts.TP;

    internal sealed class TPInputContext : ITPInputContext
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TPInputContext(
            Bundle surgeryRooms,
            Bundle wards,
            ImmutableList<PositiveInt> surgeryRoomTypes,
            ImmutableList<KeyValuePair<PositiveInt, FhirDateTime>> days,
            ImmutableList<Tuple<Organization, Organization>> wardOperatingTeams,
            ImmutableList<Tuple<Location, PositiveInt>> surgeryRoomSubsets,
            ImmutableList<Tuple<Organization, PositiveInt, PositiveInt>> wardSurgeryRoomTypeLowerSessionBounds,
            ImmutableList<Tuple<Organization, PositiveInt>> wardNumberAssignedSessions,
            ImmutableList<Tuple<Organization, FhirDecimal>> wardShortStayWaitingListLengths)
        {
            this.SurgeryRooms = surgeryRooms;

            this.Wards = wards;

            this.SurgeryRoomTypes = surgeryRoomTypes;

            this.Days = days;

            this.WardOperatingTeams = wardOperatingTeams;

            this.SurgeryRoomSubsets = surgeryRoomSubsets;

            this.WardSurgeryRoomTypeLowerSessionBounds = wardSurgeryRoomTypeLowerSessionBounds;

            this.WardNumberAssignedSessions = wardNumberAssignedSessions;

            this.WardShortStayWaitingListLengths = wardShortStayWaitingListLengths;
        }

        public Bundle SurgeryRooms { get; }

        public Bundle Wards { get; }

        public ImmutableList<PositiveInt> SurgeryRoomTypes { get; }

        public ImmutableList<KeyValuePair<PositiveInt, FhirDateTime>> Days { get; }

        public ImmutableList<Tuple<Organization, Organization>> WardOperatingTeams { get; }

        public ImmutableList<Tuple<Location, PositiveInt>> SurgeryRoomSubsets { get; }

        public ImmutableList<Tuple<Organization, PositiveInt, PositiveInt>> WardSurgeryRoomTypeLowerSessionBounds { get; }

        public ImmutableList<Tuple<Organization, PositiveInt>> WardNumberAssignedSessions { get; }

        public ImmutableList<Tuple<Organization, FhirDecimal>> WardShortStayWaitingListLengths { get; }
    }
}