namespace Testi2007.A.E.O.Classes.Constraints.SP
{
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Testi2007.A.E.O.Interfaces.Constraints.SP;
    using Testi2007.A.E.O.Interfaces.CrossJoins.SP;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.OverrunTimes;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.WardOverrunTimes;
    using Testi2007.A.E.O.Interfaces.Variables.SP;

    internal sealed class Constraint5 : IConstraint5
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraint5(
            Ijk jk,
            IH H,
            Io o,
            ISPx x)
        {
            Expression LHS = Expression.Sum(
                jk.Value
                .Select(
                    y =>
                    (double)o.GetElementAtAsdecimal(
                        y.jIndexElement)
                    *
                    x.Value[y.jIndexElement, y.kIndexElement]));

            double RHS = (double)H.Value.Value.Value;

            this.Value = LHS <= RHS;
        }

        public Constraint Value { get; }
    }
}