namespace Testi2007.A.E.O.Classes.CrossJoinElements.SP
{
    using log4net;

    using Testi2007.A.E.O.Interfaces.CrossJoinElements.SP;
    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.IndexElements.SP;

    internal sealed class jkCrossJoinElement : IjkCrossJoinElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public jkCrossJoinElement(
            IjIndexElement jIndexElement,
            IkIndexElement kIndexElement)
        {
            this.jIndexElement = jIndexElement;

            this.kIndexElement = kIndexElement;
        }

        public IjIndexElement jIndexElement { get; }

        public IkIndexElement kIndexElement { get; }
    }
}