namespace Testi2007.A.E.O.Interfaces.Parameters.TP.WardNumberAssignedSessions
{
    using System.Collections.Immutable;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.ParameterElements.TP.WardNumberAssignedSessions;

    public interface IN
    {
        ImmutableList<INParameterElement> Value { get; }

        int GetElementAtAsint(
            IjIndexElement jIndexElement);
    }
}