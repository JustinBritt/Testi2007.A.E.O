namespace Testi2007.A.E.O.Classes.ObjectiveFunctions.SP
{
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;
    using OPTANO.Modeling.Optimization.Enums;

    using Testi2007.A.E.O.Interfaces.CrossJoins.SP;
    using Testi2007.A.E.O.Interfaces.ObjectiveFunctions.SP;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.WardSessionDemandMarginalBenefits;
    using Testi2007.A.E.O.Interfaces.Variables.SP;
    using Testi2007.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;

    internal sealed class SPObjectiveFunction : ISPObjectiveFunction
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SPObjectiveFunction(
            IObjectiveFactory objectiveFactory,
            Ijk jk,
            Id d,
            ISPx x)
        {
            Expression expression = Expression.Sum(
                jk.Value
                .Select(
                    y => (double)d.GetElementAtAsdecimal(
                        y.jIndexElement,
                        y.kIndexElement)
                    *
                    x.Value[y.jIndexElement, y.kIndexElement]));

            Objective objective = objectiveFactory.Create(
                expression,
                ObjectiveSense.Maximize);

            this.Value = objective;
        }

        public Objective Value { get; }
    }
}