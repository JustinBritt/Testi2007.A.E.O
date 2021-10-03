namespace Testi2007.A.E.O.InterfacesFactories.IndexElements.SP
{
    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.IndexElements.SP;

    public interface IkIndexElementFactory
    {
        IkIndexElement Create(
            PositiveInt value);
    }
}