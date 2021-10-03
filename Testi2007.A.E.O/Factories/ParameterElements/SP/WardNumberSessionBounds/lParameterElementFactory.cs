namespace Testi2007.A.E.O.Factories.ParameterElements.SP.WardNumberSessionBounds
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Classes.ParameterElements.SP.WardNumberSessionBounds;
    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.ParameterElements.SP.WardNumberSessionBounds;
    using Testi2007.A.E.O.InterfacesFactories.ParameterElements.SP.WardNumberSessionBounds;

    internal sealed class lParameterElementFactory : IlParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public lParameterElementFactory()
        {
        }

        public IlParameterElement Create(
            IjIndexElement jIndexElement,
            PositiveInt value)
        {
            IlParameterElement parameterElement = null;

            try
            {
                parameterElement = new lParameterElement(
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