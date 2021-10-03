namespace Testi2007.A.E.O.Classes.CrossJoinElements.TP
{
    using log4net;

    using Testi2007.A.E.O.Interfaces.CrossJoinElements.TP;
    using Testi2007.A.E.O.Interfaces.IndexElements.TP;

    internal sealed class iwCrossJoinElement : IiwCrossJoinElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public iwCrossJoinElement(
            IiIndexElement iIndexElement,
            IwIndexElement wIndexElement)
        {
            this.iIndexElement = iIndexElement;

            this.wIndexElement = wIndexElement;
        }

        public IiIndexElement iIndexElement { get; }

        public IwIndexElement wIndexElement { get; }
    }
}