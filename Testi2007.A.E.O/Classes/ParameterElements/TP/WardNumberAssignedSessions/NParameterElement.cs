namespace Testi2007.A.E.O.Classes.ParameterElements.TP.WardNumberAssignedSessions
{
    using log4net;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.ParameterElements.TP.WardNumberAssignedSessions;

    internal sealed class NParameterElement : INParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public NParameterElement(
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