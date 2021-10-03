namespace Testi2007.A.E.O.Classes.ConstraintElements.TP
{
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Testi2007.A.E.O.Interfaces.ConstraintElements.TP;
    using Testi2007.A.E.O.Interfaces.CrossJoins.TP;
    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.Parameters.TP.WardNumberAssignedSessions;
    using Testi2007.A.E.O.Interfaces.Variables.TP;

    internal sealed class Constraints11ConstraintElement : IConstraints11ConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints11ConstraintElement(
            IjIndexElement jIndexElement,
            Iiw iw,
            IN N,
            ITPx x)
        {
            Expression LHS = Expression.Sum(
                iw.Value
                .Select(
                    y => x.Value[y.iIndexElement, jIndexElement, y.wIndexElement]));
            
            int RHS = N.GetElementAtAsint(
                jIndexElement);
            
            this.Value = LHS == RHS;
        }

        public Constraint Value { get; }
    }
}