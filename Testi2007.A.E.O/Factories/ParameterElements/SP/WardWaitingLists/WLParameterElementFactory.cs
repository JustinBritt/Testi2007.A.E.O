namespace Testi2007.A.E.O.Factories.ParameterElements.SP.WardWaitingLists
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Classes.ParameterElements.SP.WardWaitingLists;
    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.ParameterElements.SP.WardWaitingLists;
    using Testi2007.A.E.O.InterfacesFactories.ParameterElements.SP.WardWaitingLists;

    internal sealed class WLParameterElementFactory : IWLParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public WLParameterElementFactory()
        {
        }

        public IWLParameterElement Create(
            IjIndexElement jIndexElement,
            FhirDecimal value)
        {
            IWLParameterElement parameterElement = null;

            try
            {
                parameterElement = new WLParameterElement(
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