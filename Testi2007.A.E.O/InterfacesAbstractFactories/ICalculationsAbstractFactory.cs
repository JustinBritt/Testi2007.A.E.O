namespace Testi2007.A.E.O.InterfacesAbstractFactories
{
    using Testi2007.A.E.O.InterfacesFactories.Calculations.SP.WardDemands;
    using Testi2007.A.E.O.InterfacesFactories.Calculations.SP.WardSessionDemandMarginalBenefits;
    using Testi2007.A.E.O.InterfacesFactories.Calculations.TP.WardDayPreferences;
    using Testi2007.A.E.O.InterfacesFactories.Calculations.TP.WardNumberOperatingTeams;

    public interface ICalculationsAbstractFactory
    {
        IDCalculationFactory CreateDCalculationFactory();

        IdCalculationFactory CreatedCalculationFactory();

        IDLCalculationFactory CreateDLCalculationFactory();

        IeCalculationFactory CreateeCalculationFactory();

        IpCalculationFactory CreatepCalculationFactory();
    }
}