namespace Testi2007.A.E.O.InterfacesFactories.Parameters.TP.WardSurgeryRoomNumberSessionBounds
{
    using System.Collections.Immutable;

    using Testi2007.A.E.O.Interfaces.ParameterElements.TP.WardSurgeryRoomNumberSessionBounds;
    using Testi2007.A.E.O.Interfaces.Parameters.TP.WardSurgeryRoomNumberSessionBounds;

    public interface IlFactory
    {
        Il Create(
            ImmutableList<IlParameterElement> value);
    }
}