namespace Testi2007.A.E.O.InterfacesFactories.ParameterElements.TP.WardWaitingLists
{
    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.ParameterElements.TP.WardWaitingLists;

    public interface IWLSSParameterElementFactory
    {
        IWLSSParameterElement Create(
            IjIndexElement jIndexElement,
            FhirDecimal value);
    }
}