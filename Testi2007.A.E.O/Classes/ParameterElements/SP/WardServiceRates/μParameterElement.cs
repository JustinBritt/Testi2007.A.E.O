namespace Testi2007.A.E.O.Classes.ParameterElements.SP.WardServiceRates
{
    using log4net;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.ParameterElements.SP.WardServiceRates;

    internal sealed class μParameterElement : IμParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public μParameterElement(
            IjIndexElement jIndexElement,
            FhirDecimal value)
        {
            this.jIndexElement = jIndexElement;

            this.Value = value;
        }

        public IjIndexElement jIndexElement { get; }

        public FhirDecimal Value { get; }
    }
}