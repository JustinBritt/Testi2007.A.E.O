﻿namespace Testi2007.A.E.O.Factories.Parameters.SP.WardDemands
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Testi2007.A.E.O.Classes.Parameters.SP.WardDemands;
    using Testi2007.A.E.O.Interfaces.ParameterElements.SP.WardDemands;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.WardDemands;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.SP.WardDemands;

    internal sealed class DSFactory : IDSFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DSFactory()
        {
        }

        public IDS Create(
            ImmutableList<IDSParameterElement> value)
        {
            IDS parameter = null;

            try
            {
                parameter = new DS(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return parameter;
        }
    }
}