namespace Testi2007.A.E.O.Classes.ParameterElements.TP.WardDayPreferences
{
    using log4net;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.IndexElements.TP;
    using Testi2007.A.E.O.Interfaces.ParameterElements.TP.WardDayPreferences;

    internal sealed class pParameterElement : IpParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public pParameterElement(
            IjIndexElement jIndexElement,
            IwIndexElement wIndexElement,
            PositiveInt value)
        {
            this.jIndexElement = jIndexElement;

            this.wIndexElement = wIndexElement;

            this.Value = value;
        }

        public IjIndexElement jIndexElement { get; }

        public IwIndexElement wIndexElement { get; }

        public PositiveInt Value { get; }
    }
}