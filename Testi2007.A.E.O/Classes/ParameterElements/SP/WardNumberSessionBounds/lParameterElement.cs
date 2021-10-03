namespace Testi2007.A.E.O.Classes.ParameterElements.SP.WardNumberSessionBounds
{
    using log4net;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.ParameterElements.SP.WardNumberSessionBounds;

    internal sealed class lParameterElement : IlParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public lParameterElement(
            IjIndexElement jIndexElement,
            PositiveInt value)
        {
            this.jIndexElement = jIndexElement;

            this.Value = value;
        }

        public IjIndexElement jIndexElement { get; }

        public PositiveInt Value { get; }
    }
}