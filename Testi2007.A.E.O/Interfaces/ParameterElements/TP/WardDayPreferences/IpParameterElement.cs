namespace Testi2007.A.E.O.Interfaces.ParameterElements.TP.WardDayPreferences
{
    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.IndexElements.TP;

    public interface IpParameterElement
    {
        IjIndexElement jIndexElement { get; }

        IwIndexElement wIndexElement { get; }

        PositiveInt Value { get; }
    }
}