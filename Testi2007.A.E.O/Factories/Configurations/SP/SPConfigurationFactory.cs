﻿namespace Testi2007.A.E.O.Factories.Configurations.SP
{
    using System;

    using log4net;

    using OPTANO.Modeling.Optimization.Configuration;

    using Testi2007.A.E.O.Classes.Configurations.SP;
    using Testi2007.A.E.O.Interfaces.Configurations.SP;
    using Testi2007.A.E.O.InterfacesFactories.Configurations.SP;

    internal sealed class SPConfigurationFactory : ISPConfigurationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SPConfigurationFactory()
        {
        }

        public ISPConfiguration Create(
            Configuration configuration)
        {
            ISPConfiguration SPConfiguration = null;

            try
            {
                SPConfiguration = new SPConfiguration(
                    configuration);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return SPConfiguration;
        }
    }
}