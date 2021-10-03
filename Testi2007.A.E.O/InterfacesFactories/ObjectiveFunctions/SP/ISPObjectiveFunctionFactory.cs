namespace Testi2007.A.E.O.InterfacesFactories.ObjectiveFunctions.SP
{
    using Testi2007.A.E.O.Interfaces.CrossJoins.SP;
    using Testi2007.A.E.O.Interfaces.ObjectiveFunctions.SP;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.WardSessionDemandMarginalBenefits;
    using Testi2007.A.E.O.Interfaces.Variables.SP;
    using Testi2007.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;

    public interface ISPObjectiveFunctionFactory
    {
        ISPObjectiveFunction Create(
            IObjectiveFactory objectiveFactory,
            Ijk jk,
            Id d,
            ISPx x);
    }
}