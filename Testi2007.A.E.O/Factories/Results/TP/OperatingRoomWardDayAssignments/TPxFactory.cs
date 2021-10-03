namespace Testi2007.A.E.O.Factories.Results.TP.OperatingRoomWardDayAssignments
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Testi2007.A.E.O.Classes.Results.TP.OperatingRoomWardDayAssignments;
    using Testi2007.A.E.O.Interfaces.ResultElements.TP.OperatingRoomWardDayAssignments;
    using Testi2007.A.E.O.Interfaces.Results.TP.OperatingRoomWardDayAssignments;
    using Testi2007.A.E.O.InterfacesFactories.Results.TP.OperatingRoomWardDayAssignments;

    internal sealed class TPxFactory : ITPxFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TPxFactory()
        {
        }

        public ITPx Create(
            ImmutableList<ITPxResultElement> value)
        {
            ITPx solution = null;

            try
            {
                solution = new TPx(
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