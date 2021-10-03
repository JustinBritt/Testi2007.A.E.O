namespace Testi2007.A.E.O.Interfaces.Parameters.SP.WardServiceRates
{
    using System.Collections.Immutable;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.ParameterElements.SP.WardServiceRates;

    public interface Iμ
    {
        ImmutableList<IμParameterElement> Value { get; }

        decimal GetElementAtAsdecimal(
            IjIndexElement jIndexElement);
    }
}