namespace Testi2007.A.E.O.Interfaces.Calculations.TP.WardNumberOperatingTeams
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.Indices.Common;
    using Testi2007.A.E.O.Interfaces.Parameters.TP.WardNumberOperatingTeams;
    using Testi2007.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using Testi2007.A.E.O.InterfacesFactories.ParameterElements.TP.WardNumberOperatingTeams;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.TP.WardNumberOperatingTeams;

    public interface IeCalculation
    {
        Ie Calculatee(
            INullableValueFactory nullableValueFactory,
            IeParameterElementFactory eParameterElementFactory,
            IeFactory eFactory,
            Ij j,
            ImmutableList<Tuple<Organization, Organization>> wardOperatingTeams);
    }
}