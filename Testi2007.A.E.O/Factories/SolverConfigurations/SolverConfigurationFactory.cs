﻿namespace Testi2007.A.E.O.Factories.SolverConfigurations
{
    using System;

    using log4net;

    using Testi2007.A.E.O.Classes.SolverConfigurations;
    using Testi2007.A.E.O.Interfaces.SolverConfigurations;
    using Testi2007.A.E.O.InterfacesFactories.SolverConfigurations;

    internal sealed class SolverConfigurationFactory : ISolverConfigurationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SolverConfigurationFactory()
        {
        }

        public ISolverConfiguration Create(
            OPTANO.Modeling.Optimization.SolverConfiguration solverConfiguration)
        {
            ISolverConfiguration instance = null;

            try
            {
                instance = new SolverConfiguration(
                    solverConfiguration);
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