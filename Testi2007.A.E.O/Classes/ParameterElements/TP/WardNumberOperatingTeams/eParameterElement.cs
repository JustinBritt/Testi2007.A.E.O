namespace Testi2007.A.E.O.Classes.ParameterElements.TP.WardNumberOperatingTeams
{
    using log4net;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.ParameterElements.TP.WardNumberOperatingTeams;

    internal sealed class eParameterElement : IeParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public eParameterElement(
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