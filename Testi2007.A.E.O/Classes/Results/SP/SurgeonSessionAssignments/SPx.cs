namespace Testi2007.A.E.O.Classes.Results.SP.SurgeonSessionAssignments
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.ResultElements.SP.SurgeonSessionAssignments;
    using Testi2007.A.E.O.Interfaces.Results.SP.SurgeonSessionAssignments;
    using Testi2007.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class SPx : ISPx
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SPx(
            ImmutableList<ISPxResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<ISPxResultElement> Value { get; }

        public ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<bool>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            return this.Value
                .Select(
                i => Tuple.Create(
                    i.jIndexElement.Value,
                    (INullableValue<int>)i.kIndexElement.Value,
                    nullableValueFactory.Create<bool>(
                        i.Value)))
                .ToImmutableList();
        }
    }
}