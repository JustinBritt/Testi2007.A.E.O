namespace Testi2007.A.E.O.Classes.CrossJoinElements.TP
{
    using log4net;

    using Testi2007.A.E.O.Interfaces.CrossJoinElements.TP;
    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.IndexElements.TP;

    internal sealed class jsCrossJoinElement : IjsCrossJoinElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public jsCrossJoinElement(
            IjIndexElement jIndexElement,
            IsIndexElement sIndexElement)
        {
            this.jIndexElement = jIndexElement;

            this.sIndexElement = sIndexElement;
        }

        public IjIndexElement jIndexElement { get; }

        public IsIndexElement sIndexElement { get; }
    }
}