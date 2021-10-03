namespace Testi2007.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Testi2007.A.E.O.Factories.Parameters.SP.DemandWeights;
    using Testi2007.A.E.O.Factories.Parameters.SP.NumberSessionBounds;
    using Testi2007.A.E.O.Factories.Parameters.SP.OverrunTimes;
    using Testi2007.A.E.O.Factories.Parameters.SP.WardDemands;
    using Testi2007.A.E.O.Factories.Parameters.SP.WardNumberSessionBounds;
    using Testi2007.A.E.O.Factories.Parameters.SP.WardOverrunTimes;
    using Testi2007.A.E.O.Factories.Parameters.SP.WardServiceRates;
    using Testi2007.A.E.O.Factories.Parameters.SP.WardSessionDemandMarginalBenefits;
    using Testi2007.A.E.O.Factories.Parameters.SP.WardWaitingLists;
    using Testi2007.A.E.O.Factories.Parameters.TP.SurgeryRoomTypeSubsetSurgeryRooms;
    using Testi2007.A.E.O.Factories.Parameters.TP.WardDayPreferences;
    using Testi2007.A.E.O.Factories.Parameters.TP.WardNumberAssignedSessions;
    using Testi2007.A.E.O.Factories.Parameters.TP.WardNumberOperatingTeams;
    using Testi2007.A.E.O.Factories.Parameters.TP.WardSurgeryRoomNumberSessionBounds;
    using Testi2007.A.E.O.Factories.Parameters.TP.WardWaitingLists;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.SP.DemandWeights;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.SP.NumberSessionBounds;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.SP.OverrunTimes;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.SP.WardDemands;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.SP.WardNumberSessionBounds;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.SP.WardOverrunTimes;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.SP.WardServiceRates;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.SP.WardSessionDemandMarginalBenefits;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.SP.WardWaitingLists;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.TP.SurgeryRoomTypeSubsetSurgeryRooms;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.TP.WardDayPreferences;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.TP.WardNumberAssignedSessions;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.TP.WardNumberOperatingTeams;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.TP.WardSurgeryRoomNumberSessionBounds;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.TP.WardWaitingLists;
    using Testi2007.A.E.O.InterfacesAbstractFactories;

    internal sealed class ParametersAbstractFactory : IParametersAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ParametersAbstractFactory()
        {
        }

        public IDFactory CreateDFactory()
        {
            IDFactory factory = null;

            try
            {
                factory = new DFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IdFactory CreatedFactory()
        {
            IdFactory factory = null;

            try
            {
                factory = new dFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IDLFactory CreateDLFactory()
        {
            IDLFactory factory = null;

            try
            {
                factory = new DLFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IDSFactory CreateDSFactory()
        {
            IDSFactory factory = null;

            try
            {
                factory = new DSFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IeFactory CreateeFactory()
        {
            IeFactory factory = null;

            try
            {
                factory = new eFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IHFactory CreateHFactory()
        {
            IHFactory factory = null;

            try
            {
                factory = new HFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IIFactory CreateIFactory()
        {
            IIFactory factory = null;

            try
            {
                factory = new IFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public Testi2007.A.E.O.InterfacesFactories.Parameters.SP.WardNumberSessionBounds.IlFactory CreateSPlFactory()
        {
            Testi2007.A.E.O.InterfacesFactories.Parameters.SP.WardNumberSessionBounds.IlFactory factory = null;

            try
            {
                factory = new Testi2007.A.E.O.Factories.Parameters.SP.WardNumberSessionBounds.lFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public Testi2007.A.E.O.InterfacesFactories.Parameters.TP.WardSurgeryRoomNumberSessionBounds.IlFactory CreateTPlFactory()
        {
            Testi2007.A.E.O.InterfacesFactories.Parameters.TP.WardSurgeryRoomNumberSessionBounds.IlFactory factory = null;

            try
            {
                factory = new Testi2007.A.E.O.Factories.Parameters.TP.WardSurgeryRoomNumberSessionBounds.lFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public INFactory CreateNFactory()
        {
            INFactory factory = null;

            try
            {
                factory = new NFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IoFactory CreateoFactory()
        {
            IoFactory factory = null;

            try
            {
                factory = new oFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IpFactory CreatepFactory()
        {
            IpFactory factory = null;

            try
            {
                factory = new pFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IqFactory CreateqFactory()
        {
            IqFactory factory = null;

            try
            {
                factory = new qFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IWLFactory CreateWLFactory()
        {
            IWLFactory factory = null;

            try
            {
                factory = new WLFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IWLLSFactory CreateWLLSFactory()
        {
            IWLLSFactory factory = null;

            try
            {
                factory = new WLLSFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IWLSSFactory CreateWLSSFactory()
        {
            IWLSSFactory factory = null;

            try
            {
                factory = new WLSSFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IαFactory CreateαFactory()
        {
            IαFactory factory = null;

            try
            {
                factory = new αFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IβFactory CreateβFactory()
        {
            IβFactory factory = null;

            try
            {
                factory = new βFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IμFactory CreateμFactory()
        {
            IμFactory factory = null;

            try
            {
                factory = new μFactory();
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