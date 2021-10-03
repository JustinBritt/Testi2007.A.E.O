namespace Testi2007.A.E.O.Factories.ResultElements.TP.OperatingRoomWardDayAssignments
{
    using System;

    using log4net;

    using Testi2007.A.E.O.Classes.ResultElements.TP.OperatingRoomWardDayAssignments;
    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.IndexElements.TP;
    using Testi2007.A.E.O.Interfaces.ResultElements.TP.OperatingRoomWardDayAssignments;
    using Testi2007.A.E.O.InterfacesFactories.ResultElements.TP.OperatingRoomWardDayAssignments;

    internal sealed class TPxResultElementFactory : ITPxResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TPxResultElementFactory()
        {
        }

        public ITPxResultElement Create(
            IiIndexElement iIndexElement,
            IjIndexElement jIndexElement,
            IwIndexElement wIndexElement,
            bool value)
        {
            ITPxResultElement solution = null;

            try
            {
                solution = new TPxResultElement(
                    iIndexElement,
                    jIndexElement,
                    wIndexElement,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return solution;
        }
    }
}