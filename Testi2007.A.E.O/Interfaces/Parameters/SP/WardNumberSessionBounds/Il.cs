namespace Testi2007.A.E.O.Interfaces.Parameters.SP.WardNumberSessionBounds
{
    using System.Collections.Immutable;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.ParameterElements.SP.WardNumberSessionBounds;

    public interface Il
    {
        ImmutableList<IlParameterElement> Value { get; }

        int GetElementAtAsint(
            IjIndexElement jIndexElement);
    }
}