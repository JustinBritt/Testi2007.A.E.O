namespace Testi2007.A.E.O.InterfacesFactories.ParameterElements.TP.WardNumberOperatingTeams
{
    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.ParameterElements.TP.WardNumberOperatingTeams;

    public interface IeParameterElementFactory
    {
        IeParameterElement Create(
            IjIndexElement jIndexElement,
            PositiveInt value);
    }
}