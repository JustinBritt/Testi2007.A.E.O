namespace Testi2007.A.E.O.Classes.CrossJoinElements.TP
{
    using log4net;

    using Testi2007.A.E.O.Interfaces.CrossJoinElements.TP;
    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.IndexElements.TP;

    internal sealed class ijCrossJoinElement : IijCrossJoinElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ijCrossJoinElement(
            IiIndexElement iIndexElement,
            IjIndexElement jIndexElement)
        {
            this.iIndexElement = iIndexElement;

            this.jIndexElement = jIndexElement;
        }

        public IiIndexElement iIndexElement { get; }

        public IjIndexElement jIndexElement { get; }
    }
}