namespace Testi2007.A.E.O.Classes.Constraints.SP
{
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Testi2007.A.E.O.Interfaces.Constraints.SP;
    using Testi2007.A.E.O.Interfaces.CrossJoins.SP;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.NumberSessionBounds;
    using Testi2007.A.E.O.Interfaces.Variables.SP;

    internal sealed class Constraint3 : IConstraint3
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraint3(
            Ijk jk,
            Iq q,
            ISPx x)
        {
            Expression LHS = Expression.Sum(
                jk.Value
                .Select(
                    y => x.Value[y.jIndexElement, y.kIndexElement]));

            int RHS = q.Value.Value.Value;

            this.Value = LHS <= RHS;
        }

        public Constraint Value { get; }
    }
}