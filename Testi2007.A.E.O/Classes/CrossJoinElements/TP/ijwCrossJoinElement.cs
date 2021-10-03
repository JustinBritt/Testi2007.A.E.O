namespace Testi2007.A.E.O.Classes.CrossJoinElements.TP
{
    using log4net;

    using Testi2007.A.E.O.Interfaces.CrossJoinElements.TP;
    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.IndexElements.TP;

    internal sealed class ijwCrossJoinElement : IijwCrossJoinElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ijwCrossJoinElement(
            IiIndexElement iIndexElement,
            IjIndexElement jIndexElement,
            IwIndexElement wIndexElement)
        {
            this.iIndexElement = iIndexElement;

            this.jIndexElement = jIndexElement;

            this.wIndexElement = wIndexElement;
        }

        public IiIndexElement iIndexElement { get; }

        public IjIndexElement jIndexElement { get; }

        public IwIndexElement wIndexElement { get; }
    }
}