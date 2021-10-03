namespace Testi2007.A.E.O.Classes.ConstraintElements.TP
{
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Testi2007.A.E.O.Interfaces.ConstraintElements.TP;
    using Testi2007.A.E.O.Interfaces.IndexElements.TP;
    using Testi2007.A.E.O.Interfaces.Indices.Common;
    using Testi2007.A.E.O.Interfaces.Variables.TP;

    internal sealed class Constraints9ConstraintElement : IConstraints9ConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints9ConstraintElement(
            IiIndexElement iIndexElement,
            IwIndexElement wIndexElement,
            Ij j,
            ITPx x)
        {
            Expression LHS = Expression.Sum(
                j.Value
                .Select(
                    y => x.Value[iIndexElement, y, wIndexElement]));

            int RHS = 1;

            this.Value = LHS <= RHS;
        }

        public Constraint Value { get; }
    }
}