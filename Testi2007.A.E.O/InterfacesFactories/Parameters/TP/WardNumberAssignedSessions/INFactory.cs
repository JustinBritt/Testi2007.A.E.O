namespace Testi2007.A.E.O.InterfacesFactories.Parameters.TP.WardNumberAssignedSessions
{
    using System.Collections.Immutable;

    using Testi2007.A.E.O.Interfaces.ParameterElements.TP.WardNumberAssignedSessions;
    using Testi2007.A.E.O.Interfaces.Parameters.TP.WardNumberAssignedSessions;

    public interface INFactory
    {
        IN Create(
            ImmutableList<INParameterElement> value);
    }
}