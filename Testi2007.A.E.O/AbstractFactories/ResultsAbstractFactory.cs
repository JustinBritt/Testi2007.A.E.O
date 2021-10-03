namespace Testi2007.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Testi2007.A.E.O.Factories.Results.Common.BestBound;
    using Testi2007.A.E.O.Factories.Results.Common.Gap;
    using Testi2007.A.E.O.Factories.Results.Common.NumberOfExploredNodes;
    using Testi2007.A.E.O.Factories.Results.Common.ObjectiveValue;
    using Testi2007.A.E.O.Factories.Results.Common.OverallWallTime;
    using Testi2007.A.E.O.Factories.Results.SP.SurgeonSessionAssignments;
    using Testi2007.A.E.O.Factories.Results.TP.OperatingRoomWardDayAssignments;
    using Testi2007.A.E.O.InterfacesAbstractFactories;
    using Testi2007.A.E.O.InterfacesFactories.Results.Common.BestBound;
    using Testi2007.A.E.O.InterfacesFactories.Results.Common.Gap;
    using Testi2007.A.E.O.InterfacesFactories.Results.Common.NumberOfExploredNodes;
    using Testi2007.A.E.O.InterfacesFactories.Results.Common.ObjectiveValue;
    using Testi2007.A.E.O.InterfacesFactories.Results.Common.OverallWallTime;
    using Testi2007.A.E.O.InterfacesFactories.Results.SP.SurgeonSessionAssignments;
    using Testi2007.A.E.O.InterfacesFactories.Results.TP.OperatingRoomWardDayAssignments;

    internal sealed class ResultsAbstractFactory : IResultsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ResultsAbstractFactory()
        {
        }

        public IBestBoundFactory CreateBestBoundFactory()
        {
            IBestBoundFactory factory = null;

            try
            {
                factory = new BestBoundFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IGapFactory CreateGapFactory()
        {
            IGapFactory factory = null;

            try
            {
                factory = new GapFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public INumberOfExploredNodesFactory CreateNumberOfExploredNodesFactory()
        {
            INumberOfExploredNodesFactory factory = null;

            try
            {
                factory = new NumberOfExploredNodesFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IObjectiveValueFactory CreateObjectiveValueFactory()
        {
            IObjectiveValueFactory factory = null;

            try
            {
                factory = new ObjectiveValueFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IOverallWallTimeFactory CreateOverallWallTimeFactory()
        {
            IOverallWallTimeFactory factory = null;

            try
            {
                factory = new OverallWallTimeFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISPxFactory CreateSPxFactory()
        {
            ISPxFactory factory = null;

            try
            {
                factory = new SPxFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ITPxFactory CreateTPxFactory()
        {
            ITPxFactory factory = null;

            try
            {
                factory = new TPxFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }
    }
}