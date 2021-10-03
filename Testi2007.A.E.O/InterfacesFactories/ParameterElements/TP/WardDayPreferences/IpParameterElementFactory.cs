namespace Testi2007.A.E.O.InterfacesFactories.ParameterElements.TP.WardDayPreferences
{
    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.IndexElements.TP;
    using Testi2007.A.E.O.Interfaces.ParameterElements.TP.WardDayPreferences;

    public interface IpParameterElementFactory
    {
        IpParameterElement Create(
            IjIndexElement jIndexElement,
            IwIndexElement wIndexElement,
            PositiveInt value);
    }
}