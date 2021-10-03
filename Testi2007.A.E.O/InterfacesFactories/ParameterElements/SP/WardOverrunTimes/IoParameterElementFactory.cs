namespace Testi2007.A.E.O.InterfacesFactories.ParameterElements.SP.WardOverrunTimes
{
    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.ParameterElements.SP.WardOverrunTimes;

    public interface IoParameterElementFactory
    {
        IoParameterElement Create(
            IjIndexElement jIndexElement,
            Duration value);
    }
}