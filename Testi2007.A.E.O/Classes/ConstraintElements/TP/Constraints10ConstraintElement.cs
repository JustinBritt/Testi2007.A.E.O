namespace Testi2007.A.E.O.Classes.ConstraintElements.TP
{
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Testi2007.A.E.O.Interfaces.ConstraintElements.TP;
    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.IndexElements.TP;
    using Testi2007.A.E.O.Interfaces.Indices.TP;
    using Testi2007.A.E.O.Interfaces.Parameters.TP.WardNumberOperatingTeams;
    using Testi2007.A.E.O.Interfaces.Variables.TP;

    internal sealed class Constraints10ConstraintElement : IConstraints10ConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints10ConstraintElement(
            IjIndexElement jIndexElement,
            IwIndexElement wIndexElement,
            Ii i,
            Ie e,
            ITPx x)
        {
            Expression LHS = Expression.Sum(
                i.Value
                .Select(
                    y => x.Value[y, jIndexElement, wIndexElement]));

            int RHS = e.GetElementAtAsint(
                jIndexElement);

            this.Value = LHS <= RHS;
        }

        public Constraint Value { get; }
    }
}