namespace Testi2007.A.E.O.Interfaces.Results.SP.SurgeonSessionAssignments
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.ResultElements.SP.SurgeonSessionAssignments;
    using Testi2007.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface ISPx
    {
        ImmutableList<ISPxResultElement> Value { get; }

        ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<bool>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}