namespace Testi2007.A.E.O.Classes.Results.TP.OperatingRoomWardDayAssignments
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.ResultElements.TP.OperatingRoomWardDayAssignments;
    using Testi2007.A.E.O.Interfaces.Results.TP.OperatingRoomWardDayAssignments;
    using Testi2007.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class TPx : ITPx
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TPx(
            ImmutableList<ITPxResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<ITPxResultElement> Value { get; }

        public ImmutableList<Tuple<Location, Organization, FhirDateTime, INullableValue<bool>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            return this.Value
                .Select(
                i => Tuple.Create(
                    i.iIndexElement.Value,
                    i.jIndexElement.Value,
                    i.wIndexElement.Value,
                    nullableValueFactory.Create<bool>(
                        i.Value)))
                .ToImmutableList();
        }
    }
}