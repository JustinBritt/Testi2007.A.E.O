namespace Testi2007.A.E.O.Interfaces.Contexts.SP
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    public interface ISPOutputContext
    {
        INullableValue<decimal> BestBound { get; }

        INullableValue<decimal> Gap { get; }

        long NumberOfExploredNodes { get; }

        INullableValue<decimal> ObjectiveValue { get; }

        TimeSpan OverallWallTime { get; }

        ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<bool>>> SurgeonSessionAssignments { get; }
    }
}