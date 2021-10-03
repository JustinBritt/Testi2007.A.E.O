namespace Testi2007.A.E.O.InterfacesFactories.Parameters.SP.NumberSessionBounds
{
    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.Parameters.SP.NumberSessionBounds;

    public interface IqFactory
    {
        Iq Create(
            PositiveInt value);
    }
}