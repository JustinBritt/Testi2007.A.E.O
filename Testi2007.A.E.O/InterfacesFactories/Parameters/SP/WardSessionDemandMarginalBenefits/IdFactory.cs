namespace Testi2007.A.E.O.InterfacesFactories.Parameters.SP.WardSessionDemandMarginalBenefits
{
    using System.Collections.Immutable;

    using Testi2007.A.E.O.Interfaces.ParameterElements.SP.WardSessionDemandMarginalBenefits;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.WardSessionDemandMarginalBenefits;

    public interface IdFactory
    {
        Id Create(
            ImmutableList<IdParameterElement> value);
    }
}