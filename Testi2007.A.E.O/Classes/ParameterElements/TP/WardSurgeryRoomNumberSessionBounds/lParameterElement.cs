namespace Testi2007.A.E.O.Classes.ParameterElements.TP.WardSurgeryRoomNumberSessionBounds
{
    using log4net;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.IndexElements.TP;
    using Testi2007.A.E.O.Interfaces.ParameterElements.TP.WardSurgeryRoomNumberSessionBounds;

    internal sealed class lParameterElement : IlParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public lParameterElement(
            IjIndexElement jIndexElement,
            IsIndexElement sIndexElement,
            PositiveInt value)
        {
            this.jIndexElement = jIndexElement;

            this.sIndexElement = sIndexElement;

            this.Value = value;
        }

        public IjIndexElement jIndexElement { get; }

        public IsIndexElement sIndexElement { get; }

        public PositiveInt Value { get; }
    }
}