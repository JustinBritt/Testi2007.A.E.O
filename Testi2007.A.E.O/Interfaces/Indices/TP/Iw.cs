namespace Testi2007.A.E.O.Interfaces.Indices.TP
{
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.IndexElements.TP;

    public interface Iw
    {
        ImmutableList<IwIndexElement> Value { get; }

        IwIndexElement GetElementAt(
            FhirDateTime value);
    }
}