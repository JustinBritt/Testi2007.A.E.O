namespace Testi2007.A.E.O.Classes.Constraints.TP
{
    using System.Collections.Immutable;

    using log4net;

    using Testi2007.A.E.O.Interfaces.ConstraintElements.TP;
    using Testi2007.A.E.O.Interfaces.Constraints.TP;

    internal sealed class Constraints10 : IConstraints10
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints10(
            ImmutableList<IConstraints10ConstraintElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IConstraints10ConstraintElement> Value { get; }
    }
}