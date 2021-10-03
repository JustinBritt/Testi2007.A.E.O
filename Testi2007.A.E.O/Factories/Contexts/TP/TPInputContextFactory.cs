namespace Testi2007.A.E.O.Factories.Contexts.TP
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Classes.Contexts.TP;
    using Testi2007.A.E.O.Interfaces.Contexts.TP;
    using Testi2007.A.E.O.InterfacesFactories.Contexts.TP;

    internal sealed class TPInputContextFactory : ITPInputContextFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TPInputContextFactory()
        {
        }

        public ITPInputContext Create(
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
            ITPInputContext context = null;

            try
            {
                context = new TPInputContext(
                    surgeryRooms,
                    wards,
                    surgeryRoomTypes,
                    days,
                    wardOperatingTeams,
                    surgeryRoomSubsets,
                    wardSurgeryRoomTypeLowerSessionBounds,
                    wardNumberAssignedSessions,
                    wardShortStayWaitingListLengths);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return context;
        }
    }
}