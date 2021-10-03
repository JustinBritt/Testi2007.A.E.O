﻿namespace Testi2007.A.E.O.Factories.Dependencies.Hl7.Fhir.R4.Model
{
    using System;

    using log4net;

    using global::Hl7.Fhir.Model;

    using Testi2007.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class NullableValueFactory : INullableValueFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public NullableValueFactory()
        {
        }

        public INullableValue<T> Create<T>(
            T? value)
            where T : struct
        {
            INullableValue<T> instance = null;

            try
            {
                PrimitiveType primitiveType = value switch
                {
                    bool b => new FhirBoolean(
                        b),

                    decimal d => new FhirDecimal(
                        d),

                    int i => new PositiveInt(
                        i),

                    { } => throw new ArgumentNullException(nameof(value)),

                    _ => null
                };

                instance = (INullableValue<T>)primitiveType;
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return instance;
        }
    }
}