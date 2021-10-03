namespace Testi2007.A.E.O.Factories.Contexts.SP
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Classes.Contexts.SP;
    using Testi2007.A.E.O.Interfaces.Contexts.SP;
    using Testi2007.A.E.O.InterfacesFactories.Contexts.SP;

    internal sealed class SPInputContextFactory : ISPInputContextFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SPInputContextFactory()
        {
        }

        public ISPInputContext Create(
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
            ISPInputContext context = null;

            try
            {
                context = new SPInputContext(
                    wards,
                    sessions,
                    wardPastDemands,
                    maximumNumberSessionOverrunHours,
                    wardLowerSessionBounds,
                    wardOverrunTimes,
                    maximumNumberSessions,
                    wardWaitingListLengths,
                    α,
                    β,
                    wardServiceRates);
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