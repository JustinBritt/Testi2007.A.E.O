namespace Testi2007.A.E.O.Classes.ParameterElements.SP.WardDemands
{
    using log4net;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.ParameterElements.SP.WardDemands;

    internal sealed class DLParameterElement : IDLParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DLParameterElement(
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