namespace Testi2007.A.E.O.Interfaces.Indices.TP
{
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.IndexElements.TP;

    public interface Is
    {
        ImmutableList<IsIndexElement> Value { get; }

        IsIndexElement GetElementAt(
            PositiveInt value);
    }
}