namespace Testi2007.A.E.O.Classes.Parameters.TP.WardSurgeryRoomNumberSessionBounds
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.IndexElements.TP;
    using Testi2007.A.E.O.Interfaces.ParameterElements.TP.WardSurgeryRoomNumberSessionBounds;
    using Testi2007.A.E.O.Interfaces.Parameters.TP.WardSurgeryRoomNumberSessionBounds;

    internal sealed class l : Il
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public l(
            ImmutableList<IlParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IlParameterElement> Value { get; }

        public int GetElementAtAsint(
            IjIndexElement jIndexElement,
            IsIndexElement sIndexElement)
        {
            return this.Value
                .Where(x => x.jIndexElement == jIndexElement && x.sIndexElement == sIndexElement)
                .Select(x => x.Value.Value.Value)
                .SingleOrDefault();
        }
    }
}