namespace Testi2007.A.E.O.Classes.CrossJoins.TP
{
    using System.Collections.Immutable;
 
    using log4net;

    using Testi2007.A.E.O.Interfaces.CrossJoinElements.TP;
    using Testi2007.A.E.O.Interfaces.CrossJoins.TP;

    internal sealed class ij : Iij
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ij(
            ImmutableList<IijCrossJoinElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IijCrossJoinElement> Value { get; }
    }
}