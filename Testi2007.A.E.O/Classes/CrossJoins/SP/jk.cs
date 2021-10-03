namespace Testi2007.A.E.O.Classes.CrossJoins.SP
{
    using System.Collections.Immutable;

    using log4net;

    using Testi2007.A.E.O.Interfaces.CrossJoinElements.SP;
    using Testi2007.A.E.O.Interfaces.CrossJoins.SP;

    internal sealed class jk : Ijk
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public jk(
            ImmutableList<IjkCrossJoinElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IjkCrossJoinElement> Value { get; }
    }
}