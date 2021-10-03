namespace Testi2007.A.E.O.InterfacesFactories.ParameterElements.SP.WardNumberSessionBounds
{
    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.ParameterElements.SP.WardNumberSessionBounds;

    public interface IlParameterElementFactory
    {
        IlParameterElement Create(
            IjIndexElement jIndexElement,
            PositiveInt value);
    }
}