namespace Testi2007.A.E.O.Factories.ParameterElements.TP.WardSurgeryRoomNumberSessionBounds
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Classes.ParameterElements.TP.WardSurgeryRoomNumberSessionBounds;
    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.IndexElements.TP;
    using Testi2007.A.E.O.Interfaces.ParameterElements.TP.WardSurgeryRoomNumberSessionBounds;
    using Testi2007.A.E.O.InterfacesFactories.ParameterElements.TP.WardSurgeryRoomNumberSessionBounds;

    internal sealed class lParameterElementFactory : IlParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public lParameterElementFactory()
        {
        }

        public IlParameterElement Create(
            IjIndexElement jIndexElement,
            IsIndexElement sIndexElement,
            PositiveInt value)
        {
            IlParameterElement parameterElement = null;

            try
            {
                parameterElement = new lParameterElement(
                    jIndexElement,
                    sIndexElement,
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