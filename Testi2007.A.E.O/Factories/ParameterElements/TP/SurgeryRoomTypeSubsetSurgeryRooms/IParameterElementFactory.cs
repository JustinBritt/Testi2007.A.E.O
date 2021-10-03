namespace Testi2007.A.E.O.Factories.ParameterElements.TP.SurgeryRoomTypeSubsetSurgeryRooms
{
    using System;

    using log4net;

    using Testi2007.A.E.O.Classes.ParameterElements.TP.SurgeryRoomTypeSubsetSurgeryRooms;
    using Testi2007.A.E.O.Interfaces.IndexElements.TP;
    using Testi2007.A.E.O.Interfaces.ParameterElements.TP.SurgeryRoomTypeSubsetSurgeryRooms;
    using Testi2007.A.E.O.InterfacesFactories.ParameterElements.TP.SurgeryRoomTypeSubsetSurgeryRooms;

    internal sealed class IParameterElementFactory : IIParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public IParameterElementFactory()
        {
        }

        public IIParameterElement Create(
            IsIndexElement sIndexElement,
            IiIndexElement iIndexElement)
        {
            IIParameterElement parameterElement = null;

            try
            {
                parameterElement = new IParameterElement(
                    sIndexElement,
                    iIndexElement);
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