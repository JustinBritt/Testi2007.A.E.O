namespace Testi2007.A.E.O.Factories.ParameterElements.TP.WardNumberOperatingTeams
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Classes.ParameterElements.TP.WardNumberOperatingTeams;
    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.ParameterElements.TP.WardNumberOperatingTeams;
    using Testi2007.A.E.O.InterfacesFactories.ParameterElements.TP.WardNumberOperatingTeams;

    internal sealed class eParameterElementFactory : IeParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public eParameterElementFactory()
        {
        }

        public IeParameterElement Create(
            IjIndexElement jIndexElement,
            PositiveInt value)
        {
            IeParameterElement parameterElement = null;

            try
            {
                parameterElement = new eParameterElement(
                    jIndexElement,
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