namespace Testi2007.A.E.O.Interfaces.ParameterElements.TP.WardNumberOperatingTeams
{
    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;

    public interface IeParameterElement
    {
        IjIndexElement jIndexElement { get; }

        PositiveInt Value { get; }
    }
}