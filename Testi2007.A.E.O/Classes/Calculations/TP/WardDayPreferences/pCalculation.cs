namespace Testi2007.A.E.O.Classes.Calculations.TP.WardDayPreferences
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.Calculations.TP.WardDayPreferences;
    using Testi2007.A.E.O.Interfaces.CrossJoins.TP;
    using Testi2007.A.E.O.Interfaces.Parameters.TP.WardDayPreferences;
    using Testi2007.A.E.O.Interfaces.Parameters.TP.WardWaitingLists;
    using Testi2007.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using Testi2007.A.E.O.InterfacesFactories.ParameterElements.TP.WardDayPreferences;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.TP.WardDayPreferences;

    internal sealed class pCalculation : IpCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public pCalculation()
        {
        }

        public Ip Calculatep(
            INullableValueFactory nullableValueFactory,
            IpParameterElementFactory pParameterElementFactory,
            IpFactory pFactory,
            Ijw jw,
            IWLSS WLSS)
        {
            return pFactory.Create(
                jw.Value
                .Select(y => pParameterElementFactory.Create(
                    y.jIndexElement,
                    y.wIndexElement,
                    (PositiveInt)nullableValueFactory.Create<int>(
                        (int)Math.Max(
                            Math.Floor(
                                WLSS.GetElementAtAsdecimal(
                                    y.jIndexElement)
                                /
                                WLSS.Value.Select(x => x.Value.Value.Value).Min())
                            -
                            y.wIndexElement.Key
                            -
                            1,
                            1))))
                .ToImmutableList());
        }
    }
}