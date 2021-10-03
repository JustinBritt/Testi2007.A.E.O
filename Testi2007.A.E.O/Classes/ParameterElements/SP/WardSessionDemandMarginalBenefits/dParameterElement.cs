namespace Testi2007.A.E.O.Classes.ParameterElements.SP.WardSessionDemandMarginalBenefits
{
    using log4net;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.IndexElements.SP;
    using Testi2007.A.E.O.Interfaces.ParameterElements.SP.WardSessionDemandMarginalBenefits;

    internal sealed class dParameterElement : IdParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public dParameterElement(
            IjIndexElement jIndexElement,
            IkIndexElement kIndexElement,
            FhirDecimal value)
        {
            this.jIndexElement = jIndexElement;

            this.kIndexElement = kIndexElement;

            this.Value = value;
        }

        public IjIndexElement jIndexElement { get; }

        public IkIndexElement kIndexElement { get; }

        public FhirDecimal Value { get; }
    }
}