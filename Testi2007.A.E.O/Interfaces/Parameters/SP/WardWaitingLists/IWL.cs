namespace Testi2007.A.E.O.Interfaces.Parameters.SP.WardWaitingLists
{
    using System.Collections.Immutable;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.ParameterElements.SP.WardWaitingLists;

    public interface IWL
    {
        ImmutableList<IWLParameterElement> Value { get; }

        decimal GetElementAtAsdecimal(
            IjIndexElement jIndexElement);
    }
}