namespace Testi2007.A.E.O.Classes.ConstraintElements.TP
{
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Testi2007.A.E.O.Interfaces.ConstraintElements.TP;
    using Testi2007.A.E.O.Interfaces.CrossJoins.TP;
    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.IndexElements.TP;
    using Testi2007.A.E.O.Interfaces.Parameters.TP.SurgeryRoomTypeSubsetSurgeryRooms;
    using Testi2007.A.E.O.Interfaces.Parameters.TP.WardSurgeryRoomNumberSessionBounds;
    using Testi2007.A.E.O.Interfaces.Variables.TP;

    internal sealed class Constraints12ConstraintElement : IConstraints12ConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints12ConstraintElement(
            IjIndexElement jIndexElement,
            IsIndexElement sIndexElement,
            Iiw iw,
            II I,
            Il l,
            ITPx x)
        {
            Expression LHS = Expression.Sum(
                iw.Value
                .Where(y => I.IsThereElementAt(
                    sIndexElement,
                    y.iIndexElement))
                .Select(
                    y => x.Value[y.iIndexElement, jIndexElement, y.wIndexElement]));

            int RHS = l.GetElementAtAsint(
                jIndexElement,
                sIndexElement);

            this.Value = LHS >= RHS;
        }

        public Constraint Value { get; }
    }
}