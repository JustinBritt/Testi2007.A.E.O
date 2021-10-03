namespace Testi2007.A.E.O.Interfaces.Parameters.SP.WardSessionDemandMarginalBenefits
{
    using System.Collections.Immutable;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.IndexElements.SP;
    using Testi2007.A.E.O.Interfaces.ParameterElements.SP.WardSessionDemandMarginalBenefits;

    public interface Id
    {
        ImmutableList<IdParameterElement> Value { get; }

        decimal GetElementAtAsdecimal(
            IjIndexElement jIndexElement,
            IkIndexElement kIndexElement);
    }
}