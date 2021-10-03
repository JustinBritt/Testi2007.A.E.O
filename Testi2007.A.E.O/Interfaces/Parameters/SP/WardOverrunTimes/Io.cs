namespace Testi2007.A.E.O.Interfaces.Parameters.SP.WardOverrunTimes
{
    using System.Collections.Immutable;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.ParameterElements.SP.WardOverrunTimes;

    public interface Io
    {
        ImmutableList<IoParameterElement> Value { get; }

        decimal GetElementAtAsdecimal(
            IjIndexElement jIndexElement);
    }
}