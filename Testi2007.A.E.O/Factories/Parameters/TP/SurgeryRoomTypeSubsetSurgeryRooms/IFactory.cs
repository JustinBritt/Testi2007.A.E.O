namespace Testi2007.A.E.O.Factories.Parameters.TP.SurgeryRoomTypeSubsetSurgeryRooms
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Testi2007.A.E.O.Classes.Parameters.TP.SurgeryRoomTypeSubsetSurgeryRooms;
    using Testi2007.A.E.O.Interfaces.ParameterElements.TP.SurgeryRoomTypeSubsetSurgeryRooms;
    using Testi2007.A.E.O.Interfaces.Parameters.TP.SurgeryRoomTypeSubsetSurgeryRooms;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.TP.SurgeryRoomTypeSubsetSurgeryRooms;

    internal sealed class IFactory : IIFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public IFactory()
        {
        }

        public II Create(
            ImmutableList<IIParameterElement> value)
        {
            II parameter = null;

            try
            {
                parameter = new I(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return parameter;
        }
    }
}