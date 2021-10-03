namespace Testi2007.A.E.O.Classes.IndexElements.TP
{
    using log4net;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.IndexElements.TP;

    internal sealed class wIndexElement : IwIndexElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public wIndexElement(
            int key,
            FhirDateTime value)
        {
            this.Key = key;

            this.Value = value;
        }

        /// <summary>
        /// Gets the key of the day.
        /// </summary>
        public int Key { get; }

        /// <summary>
        /// Gets the value of the day.
        /// </summary>
        public FhirDateTime Value { get; }
    }
}