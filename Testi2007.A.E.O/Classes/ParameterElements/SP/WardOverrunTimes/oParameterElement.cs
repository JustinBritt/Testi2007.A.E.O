namespace Testi2007.A.E.O.Classes.ParameterElements.SP.WardOverrunTimes
{
    using log4net;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.ParameterElements.SP.WardOverrunTimes;

    internal sealed class oParameterElement : IoParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public oParameterElement(
            IjIndexElement jIndexElement,
            Duration value)
        {
            this.jIndexElement = jIndexElement;

            this.Value = value;
        }

        public IjIndexElement jIndexElement { get; }

        public Duration Value { get; }
    }
}