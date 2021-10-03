namespace Testi2007.A.E.O.Classes.ResultElements.SP.SurgeonSessionAssignments
{
    using log4net;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.IndexElements.SP;
    using Testi2007.A.E.O.Interfaces.ResultElements.SP.SurgeonSessionAssignments;

    internal sealed class SPxResultElement : ISPxResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SPxResultElement(
            IjIndexElement jIndexElement,
            IkIndexElement kIndexElement,
            bool value)
        {
            this.jIndexElement = jIndexElement;

            this.kIndexElement = kIndexElement;

            this.Value = value;
        }

        public IjIndexElement jIndexElement { get; }

        public IkIndexElement kIndexElement { get; }

        public bool Value { get; }
    }
}