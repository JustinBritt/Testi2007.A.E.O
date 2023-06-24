namespace Testi2007.A.E.O.Classes.IndexElements.TP
{
    using log4net;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.IndexElements.TP;

    internal sealed class iIndexElement : IiIndexElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public iIndexElement(
            Location value)
        {
            this.Value = value;
        }

        /// <inheritdoc/>
        public Location Value { get; }
    }
}