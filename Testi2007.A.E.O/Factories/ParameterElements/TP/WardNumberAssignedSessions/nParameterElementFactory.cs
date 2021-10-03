namespace Testi2007.A.E.O.Factories.ParameterElements.TP.WardNumberAssignedSessions
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Classes.ParameterElements.TP.WardNumberAssignedSessions;
    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.ParameterElements.TP.WardNumberAssignedSessions;
    using Testi2007.A.E.O.InterfacesFactories.ParameterElements.TP.WardNumberAssignedSessions;

    internal sealed class nParameterElementFactory : INParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public nParameterElementFactory()
        {
        }

        public INParameterElement Create(
            IjIndexElement jIndexElement,
            PositiveInt value)
        {
            INParameterElement parameterElement = null;

            try
            {
                parameterElement = new NParameterElement(
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