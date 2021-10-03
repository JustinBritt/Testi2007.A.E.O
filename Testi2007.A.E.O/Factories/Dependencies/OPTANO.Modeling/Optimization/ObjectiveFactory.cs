﻿namespace Testi2007.A.E.O.Factories.Dependencies.OPTANO.Modeling.Optimization
{
    using System;

    using log4net;

    using global::OPTANO.Modeling.Optimization;
    using global::OPTANO.Modeling.Optimization.Enums;

    using Testi2007.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;

    internal sealed class ObjectiveFactory : IObjectiveFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ObjectiveFactory()
        {
        }

        public Objective Create(
            Expression expression,
            ObjectiveSense objectiveSense)
        {
            Objective objective = null;

            try
            {
                objective = new Objective(
                    expression: expression,
                    sense: objectiveSense);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return objective;
        }
    }
}