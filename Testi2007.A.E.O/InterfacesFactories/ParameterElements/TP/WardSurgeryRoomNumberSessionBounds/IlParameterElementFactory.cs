namespace Testi2007.A.E.O.InterfacesFactories.ParameterElements.TP.WardSurgeryRoomNumberSessionBounds
{
    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.IndexElements.TP;
    using Testi2007.A.E.O.Interfaces.ParameterElements.TP.WardSurgeryRoomNumberSessionBounds;

    public interface IlParameterElementFactory
    {
        IlParameterElement Create(
            IjIndexElement jIndexElement,
            IsIndexElement sIndexElement,
            PositiveInt value);
    }
}