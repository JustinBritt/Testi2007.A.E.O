namespace Testi2007.A.E.O.Factories.ParameterElements.TP.WardDayPreferences
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Classes.ParameterElements.TP.WardDayPreferences;
    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.IndexElements.TP;
    using Testi2007.A.E.O.Interfaces.ParameterElements.TP.WardDayPreferences;
    using Testi2007.A.E.O.InterfacesFactories.ParameterElements.TP.WardDayPreferences;

    internal sealed class pParameterElementFactory : IpParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public pParameterElementFactory()
        {
        }

        public IpParameterElement Create(
            IjIndexElement jIndexElement,
            IwIndexElement wIndexElement,
            PositiveInt value)
        {
            IpParameterElement parameterElement = null;

            try
            {
                parameterElement = new pParameterElement(
                    jIndexElement,
                    wIndexElement,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return parameterElement;
        }
    }
}