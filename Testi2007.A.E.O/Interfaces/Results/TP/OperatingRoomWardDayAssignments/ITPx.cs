namespace Testi2007.A.E.O.Interfaces.Results.TP.OperatingRoomWardDayAssignments
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.ResultElements.TP.OperatingRoomWardDayAssignments;
    using Testi2007.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface ITPx
    {
        ImmutableList<ITPxResultElement> Value { get; }

        ImmutableList<Tuple<Location, Organization, FhirDateTime, INullableValue<bool>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}