namespace Testi2007.A.E.O.InterfacesFactories.IndexElements.Common
{
    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;

    public interface IjIndexElementFactory
    {
        IjIndexElement Create(
            Organization value);
    }
}