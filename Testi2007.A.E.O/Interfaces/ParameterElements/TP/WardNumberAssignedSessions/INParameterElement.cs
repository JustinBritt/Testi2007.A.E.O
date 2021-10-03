namespace Testi2007.A.E.O.Interfaces.ParameterElements.TP.WardNumberAssignedSessions
{
    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;

    public interface INParameterElement
    {
        IjIndexElement jIndexElement { get; }

        PositiveInt Value { get; }
    }
}