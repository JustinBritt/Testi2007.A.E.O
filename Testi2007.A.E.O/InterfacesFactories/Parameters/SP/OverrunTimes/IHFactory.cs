namespace Testi2007.A.E.O.InterfacesFactories.Parameters.SP.OverrunTimes
{
    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.Parameters.SP.OverrunTimes;

    public interface IHFactory
    {
        IH Create(
            Duration value);
    }
}