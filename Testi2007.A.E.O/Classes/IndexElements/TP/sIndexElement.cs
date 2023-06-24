namespace Testi2007.A.E.O.Classes.IndexElements.TP
{
    using log4net;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.IndexElements.TP;

    internal sealed class sIndexElement : IsIndexElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public sIndexElement(
            PositiveInt value)
        {
            this.Value = value;
        }

        /// <inheritdoc/>
        public PositiveInt Value { get; }
    }
}