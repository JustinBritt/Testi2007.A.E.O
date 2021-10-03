namespace Testi2007.A.E.O.Classes.ObjectiveFunctions.TP
{
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;
    using OPTANO.Modeling.Optimization.Enums;

    using Testi2007.A.E.O.Interfaces.CrossJoins.TP;
    using Testi2007.A.E.O.Interfaces.ObjectiveFunctions.TP;
    using Testi2007.A.E.O.Interfaces.Parameters.TP.WardDayPreferences;
    using Testi2007.A.E.O.Interfaces.Variables.TP;
    using Testi2007.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;

    internal sealed class TPObjectiveFunction : ITPObjectiveFunction
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TPObjectiveFunction(
            IObjectiveFactory objectiveFactory,
            Iijw ijw,
            Ip p,
            ITPx x)
        {
            Expression expression = Expression.Sum(
                ijw.Value
                .Select(
                    y => (double)p.GetElementAtAsint(
                        y.jIndexElement,
                        y.wIndexElement)
                    *
                    x.Value[y.iIndexElement, y.jIndexElement, y.wIndexElement]));

            Objective objective = objectiveFactory.Create(
                expression,
                ObjectiveSense.Maximize);

            this.Value = objective;
        }

        public Objective Value { get; }
    }
}