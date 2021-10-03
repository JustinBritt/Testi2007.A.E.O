namespace Testi2007.A.E.O.Classes.IndexElements.Common
{
    using log4net;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;

    internal sealed class jIndexElement : IjIndexElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public jIndexElement(
            Organization value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Gets the ward.
        /// </summary>
        public Organization Value { get; }
    }
}