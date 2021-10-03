﻿namespace Testi2007.A.E.O.Factories.Results.Common.OverallWallTime
{
    using System;

    using log4net;

    using Testi2007.A.E.O.Classes.Results.Common.OverallWallTime;
    using Testi2007.A.E.O.Interfaces.Results.Common.OverallWallTime;
    using Testi2007.A.E.O.InterfacesFactories.Results.Common.OverallWallTime;

    internal sealed class OverallWallTimeFactory : IOverallWallTimeFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public OverallWallTimeFactory()
        {
        }

        public IOverallWallTime Create(
            TimeSpan value)
        {
            IOverallWallTime result = null;

            try
            {
                result = new OverallWallTime(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return result;
        }
    }
}