namespace Testi2007.A.E.O.Factories.ParameterElements.SP.WardDemands
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Classes.ParameterElements.SP.WardDemands;
    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.ParameterElements.SP.WardDemands;
    using Testi2007.A.E.O.InterfacesFactories.ParameterElements.SP.WardDemands;

    internal sealed class DLParameterElementFactory : IDLParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DLParameterElementFactory()
        {
        }

        public IDLParameterElement Create(
            IjIndexElement jIndexElement,
            FhirDecimal value)
        {
            IDLParameterElement parameterElement = null;

            try
            {
                parameterElement = new DLParameterElement(
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