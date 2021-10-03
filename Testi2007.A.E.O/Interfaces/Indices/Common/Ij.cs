namespace Testi2007.A.E.O.Interfaces.Indices.Common
{
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;

    public interface Ij
    {
        ImmutableList<IjIndexElement> Value { get; }

        IjIndexElement GetElementAt(
            Organization value);
    }
}