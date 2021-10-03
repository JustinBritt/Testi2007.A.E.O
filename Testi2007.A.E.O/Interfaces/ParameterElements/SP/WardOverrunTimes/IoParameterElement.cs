namespace Testi2007.A.E.O.Interfaces.ParameterElements.SP.WardOverrunTimes
{
    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;

    public interface IoParameterElement
    {
        IjIndexElement jIndexElement { get; }

        Duration Value { get; }
    }
}