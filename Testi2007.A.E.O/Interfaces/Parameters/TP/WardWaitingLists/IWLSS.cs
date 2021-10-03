namespace Testi2007.A.E.O.Interfaces.Parameters.TP.WardWaitingLists
{
    using System.Collections.Immutable;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.ParameterElements.TP.WardWaitingLists;

    public interface IWLSS
    {
        ImmutableList<IWLSSParameterElement> Value { get; }

        decimal GetElementAtAsdecimal(
            IjIndexElement jIndexElement);
    }
}