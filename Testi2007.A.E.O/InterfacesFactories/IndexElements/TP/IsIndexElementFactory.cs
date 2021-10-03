namespace Testi2007.A.E.O.InterfacesFactories.IndexElements.TP
{
    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.IndexElements.TP;

    public interface IsIndexElementFactory
    {
        IsIndexElement Create(
            PositiveInt value);
    }
}