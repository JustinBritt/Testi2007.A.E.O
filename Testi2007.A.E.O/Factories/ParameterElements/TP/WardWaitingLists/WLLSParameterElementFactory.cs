namespace Testi2007.A.E.O.Factories.ParameterElements.TP.WardWaitingLists
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Classes.ParameterElements.TP.WardWaitingLists;
    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.ParameterElements.TP.WardWaitingLists;
    using Testi2007.A.E.O.InterfacesFactories.ParameterElements.TP.WardWaitingLists;

    internal sealed class WLLSParameterElementFactory : IWLLSParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public WLLSParameterElementFactory()
        {
        }

        public IWLLSParameterElement Create(
            IjIndexElement jIndexElement,
            FhirDecimal value)
        {
            IWLLSParameterElement parameterElement = null;

            try
            {
                parameterElement = new WLLSParameterElement(
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