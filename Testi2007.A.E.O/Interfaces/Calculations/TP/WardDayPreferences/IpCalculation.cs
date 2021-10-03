namespace Testi2007.A.E.O.Interfaces.Calculations.TP.WardDayPreferences
{
    using Testi2007.A.E.O.Interfaces.CrossJoins.TP;
    using Testi2007.A.E.O.Interfaces.Parameters.TP.WardDayPreferences;
    using Testi2007.A.E.O.Interfaces.Parameters.TP.WardWaitingLists;
    using Testi2007.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using Testi2007.A.E.O.InterfacesFactories.ParameterElements.TP.WardDayPreferences;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.TP.WardDayPreferences;

    public interface IpCalculation
    {
        Ip Calculatep(
            INullableValueFactory nullableValueFactory,
            IpParameterElementFactory pParameterElementFactory,
            IpFactory pFactory,
            Ijw jw,
            IWLSS WLSS);
    }
}