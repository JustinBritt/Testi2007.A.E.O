namespace Testi2007.A.E.O.Classes.Parameters.TP.SurgeryRoomTypeSubsetSurgeryRooms
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Testi2007.A.E.O.Interfaces.IndexElements.TP;
    using Testi2007.A.E.O.Interfaces.ParameterElements.TP.SurgeryRoomTypeSubsetSurgeryRooms;
    using Testi2007.A.E.O.Interfaces.Parameters.TP.SurgeryRoomTypeSubsetSurgeryRooms;

    internal sealed class I : II
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public I(
            ImmutableList<IIParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IIParameterElement> Value { get; }

        public bool IsThereElementAt(
            IsIndexElement sIndexElement,
            IiIndexElement iIndexElement)
        {
            int count = this.Value
                .Where(x => x.sIndexElement == sIndexElement && x.iIndexElement == iIndexElement)
                .Distinct()
                .Count();

            if (count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}