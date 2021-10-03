namespace Testi2007.A.E.O.Interfaces.ParameterElements.TP.WardSurgeryRoomNumberSessionBounds
{
    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.IndexElements.TP;

    public interface IlParameterElement
    {
        IjIndexElement jIndexElement { get; }

        IsIndexElement sIndexElement { get; }

        PositiveInt Value { get; }
    }
}