namespace Testi2007.A.E.O.Classes.ConstraintElements.SP
{
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Testi2007.A.E.O.Interfaces.ConstraintElements.SP;
    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.Indices.SP;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.WardNumberSessionBounds;
    using Testi2007.A.E.O.Interfaces.Variables.SP;

    internal sealed class Constraints4ConstraintElement : IConstraints4ConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints4ConstraintElement(
            IjIndexElement jIndexElement,
            Ik k,
            Il l,
            ISPx x)
        {
            Expression LHS = Expression.Sum(
                k.Value
                .Select(
                    y => x.Value[jIndexElement, y]));

            int RHS = l.GetElementAtAsint(
                jIndexElement);

            this.Value = LHS >= RHS;
        }

        public Constraint Value { get; }
    }
}