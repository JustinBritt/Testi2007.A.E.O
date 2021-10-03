namespace Testi2007.A.E.O.Interfaces.Indices.SP
{
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.IndexElements.SP;

    public interface Ik
    {
        ImmutableList<IkIndexElement> Value { get; }

        IkIndexElement GetElementAt(
            PositiveInt value);
    }
}