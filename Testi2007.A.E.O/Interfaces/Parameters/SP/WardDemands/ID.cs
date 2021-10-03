namespace Testi2007.A.E.O.Interfaces.Parameters.SP.WardDemands
{
    using System.Collections.Immutable;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.ParameterElements.SP.WardDemands;

    public interface ID
    {
        ImmutableList<IDParameterElement> Value { get; }

        decimal GetElementAtAsdecimal(
            IjIndexElement jIndexElement);

        decimal GetTotalDemand();
    }
}