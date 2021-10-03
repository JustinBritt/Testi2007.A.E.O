namespace Testi2007.A.E.O.Interfaces.Parameters.TP.WardDayPreferences
{
    using System.Collections.Immutable;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.IndexElements.TP;
    using Testi2007.A.E.O.Interfaces.ParameterElements.TP.WardDayPreferences;

    public interface Ip
    {
        ImmutableList<IpParameterElement> Value { get; }

        int GetElementAtAsint(
            IjIndexElement jIndexElement,
            IwIndexElement wIndexElement);
    }
}