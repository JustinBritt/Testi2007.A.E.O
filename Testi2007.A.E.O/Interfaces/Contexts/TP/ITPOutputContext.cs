namespace Testi2007.A.E.O.Interfaces.Contexts.TP
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    public interface ITPOutputContext
    {
        INullableValue<decimal> BestBound { get; }

        INullableValue<decimal> Gap { get; }

        long NumberOfExploredNodes { get; }

        INullableValue<decimal> ObjectiveValue { get; }

        TimeSpan OverallWallTime { get; }

        ImmutableList<Tuple<Location, Organization, FhirDateTime, INullableValue<bool>>> OperatingRoomWardDayAssignments { get; }
    }
}