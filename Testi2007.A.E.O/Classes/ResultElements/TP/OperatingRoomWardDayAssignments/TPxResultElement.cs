namespace Testi2007.A.E.O.Classes.ResultElements.TP.OperatingRoomWardDayAssignments
{
    using log4net;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.IndexElements.TP;
    using Testi2007.A.E.O.Interfaces.ResultElements.TP.OperatingRoomWardDayAssignments;

    internal sealed class TPxResultElement : ITPxResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TPxResultElement(
            IiIndexElement iIndexElement,
            IjIndexElement jIndexElement,
            IwIndexElement wIndexElement,
            bool value)
        {
            this.iIndexElement = iIndexElement;

            this.jIndexElement = jIndexElement;

            this.wIndexElement = wIndexElement;

            this.Value = value;
        }

        public IiIndexElement iIndexElement { get; }

        public IjIndexElement jIndexElement { get; }

        public IwIndexElement wIndexElement { get; }

        public bool Value { get; }
    }
}