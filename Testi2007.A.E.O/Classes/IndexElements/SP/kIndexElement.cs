namespace Testi2007.A.E.O.Classes.IndexElements.SP
{
    using log4net;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.IndexElements.SP;

    internal sealed class kIndexElement : IkIndexElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public kIndexElement(
            PositiveInt value)
        {
            this.Value = value;
        }

        /// <inheritdoc/>
        public PositiveInt Value { get; }
    }
}