﻿namespace Testi2007.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model
{
    using global::Hl7.Fhir.Model;

    public interface INullableValueFactory
    {
        INullableValue<T> Create<T>(
            T? value)
            where T : struct;
    }
}