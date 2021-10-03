namespace Testi2007.A.E.O.Classes.Parameters.SP.DemandWeights
{
    using log4net;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.Parameters.SP.DemandWeights;

    internal sealed class β : Iβ
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public β(
            FhirDecimal value)
        {
            this.Value = value;
        }

        public FhirDecimal Value { get; }
    }
}