namespace Testi2007.A.E.O.Interfaces.Parameters.TP.WardSurgeryRoomNumberSessionBounds
{
    using System.Collections.Immutable;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.IndexElements.TP;
    using Testi2007.A.E.O.Interfaces.ParameterElements.TP.WardSurgeryRoomNumberSessionBounds;

    public interface Il
    {
        ImmutableList<IlParameterElement> Value { get; }

        int GetElementAtAsint(
            IjIndexElement jIndexElement,
            IsIndexElement sIndexElement);
    }
}