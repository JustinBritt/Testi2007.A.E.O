namespace Testi2007.A.E.O.InterfacesFactories.ParameterElements.TP.WardNumberAssignedSessions
{
    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.ParameterElements.TP.WardNumberAssignedSessions;

    public interface INParameterElementFactory
    {
        INParameterElement Create(
            IjIndexElement jIndexElement,
            PositiveInt value);
    }
}