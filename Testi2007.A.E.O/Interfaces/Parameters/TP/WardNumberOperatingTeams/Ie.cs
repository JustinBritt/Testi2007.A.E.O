namespace Testi2007.A.E.O.Interfaces.Parameters.TP.WardNumberOperatingTeams
{
    using System.Collections.Immutable;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.ParameterElements.TP.WardNumberOperatingTeams;

    public interface Ie
    {
        ImmutableList<IeParameterElement> Value { get; }

        int GetElementAtAsint(
            IjIndexElement jIndexElement);
    }
}