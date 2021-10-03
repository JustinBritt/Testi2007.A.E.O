namespace Testi2007.A.E.O.InterfacesFactories.Parameters.SP.WardOverrunTimes
{
    using System.Collections.Immutable;

    using Testi2007.A.E.O.Interfaces.ParameterElements.SP.WardOverrunTimes;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.WardOverrunTimes;

    public interface IoFactory
    {
        Io Create(
            ImmutableList<IoParameterElement> value);
    }
}