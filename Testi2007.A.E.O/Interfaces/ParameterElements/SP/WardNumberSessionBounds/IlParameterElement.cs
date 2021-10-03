namespace Testi2007.A.E.O.Interfaces.ParameterElements.SP.WardNumberSessionBounds
{
    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;

    public interface IlParameterElement
    {
        IjIndexElement jIndexElement { get; }

        PositiveInt Value { get; }
    }
}