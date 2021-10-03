namespace Testi2007.A.E.O.Classes.ParameterElements.TP.SurgeryRoomTypeSubsetSurgeryRooms
{
    using log4net;

    using Testi2007.A.E.O.Interfaces.IndexElements.TP;
    using Testi2007.A.E.O.Interfaces.ParameterElements.TP.SurgeryRoomTypeSubsetSurgeryRooms;

    internal sealed class IParameterElement : IIParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public IParameterElement(
            IsIndexElement sIndexElement,
            IiIndexElement iIndexElement)
        {
            this.sIndexElement = sIndexElement;

            this.iIndexElement = iIndexElement;
        }

        public IsIndexElement sIndexElement { get; }

        public IiIndexElement iIndexElement { get; }
    }
}