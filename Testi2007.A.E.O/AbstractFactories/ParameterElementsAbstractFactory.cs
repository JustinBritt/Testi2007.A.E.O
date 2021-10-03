namespace Testi2007.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Testi2007.A.E.O.Factories.ParameterElements.SP.WardDemands;
    using Testi2007.A.E.O.Factories.ParameterElements.SP.WardNumberSessionBounds;
    using Testi2007.A.E.O.Factories.ParameterElements.SP.WardOverrunTimes;
    using Testi2007.A.E.O.Factories.ParameterElements.SP.WardServiceRates;
    using Testi2007.A.E.O.Factories.ParameterElements.SP.WardSessionDemandMarginalBenefits;
    using Testi2007.A.E.O.Factories.ParameterElements.SP.WardWaitingLists;
    using Testi2007.A.E.O.Factories.ParameterElements.TP.SurgeryRoomTypeSubsetSurgeryRooms;
    using Testi2007.A.E.O.Factories.ParameterElements.TP.WardDayPreferences;
    using Testi2007.A.E.O.Factories.ParameterElements.TP.WardNumberAssignedSessions;
    using Testi2007.A.E.O.Factories.ParameterElements.TP.WardNumberOperatingTeams;
    using Testi2007.A.E.O.Factories.ParameterElements.TP.WardSurgeryRoomNumberSessionBounds;
    using Testi2007.A.E.O.Factories.ParameterElements.TP.WardWaitingLists;
    using Testi2007.A.E.O.InterfacesFactories.ParameterElements.SP.WardDemands;
    using Testi2007.A.E.O.InterfacesFactories.ParameterElements.SP.WardNumberSessionBounds;
    using Testi2007.A.E.O.InterfacesFactories.ParameterElements.SP.WardOverrunTimes;
    using Testi2007.A.E.O.InterfacesFactories.ParameterElements.SP.WardServiceRates;
    using Testi2007.A.E.O.InterfacesFactories.ParameterElements.SP.WardSessionDemandMarginalBenefits;
    using Testi2007.A.E.O.InterfacesFactories.ParameterElements.SP.WardWaitingLists;
    using Testi2007.A.E.O.InterfacesFactories.ParameterElements.TP.SurgeryRoomTypeSubsetSurgeryRooms;
    using Testi2007.A.E.O.InterfacesFactories.ParameterElements.TP.WardDayPreferences;
    using Testi2007.A.E.O.InterfacesFactories.ParameterElements.TP.WardNumberAssignedSessions;
    using Testi2007.A.E.O.InterfacesFactories.ParameterElements.TP.WardNumberOperatingTeams;
    using Testi2007.A.E.O.InterfacesFactories.ParameterElements.TP.WardSurgeryRoomNumberSessionBounds;
    using Testi2007.A.E.O.InterfacesFactories.ParameterElements.TP.WardWaitingLists;
    using Testi2007.A.E.O.InterfacesAbstractFactories;

    internal sealed class ParameterElementsAbstractFactory : IParameterElementsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ParameterElementsAbstractFactory()
        {
        }

        public IDParameterElementFactory CreateDParameterElementFactory()
        {
            IDParameterElementFactory factory = null;

            try
            {
                factory = new DParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IdParameterElementFactory CreatedParameterElementFactory()
        {
            IdParameterElementFactory factory = null;

            try
            {
                factory = new dParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IDLParameterElementFactory CreateDLParameterElementFactory()
        {
            IDLParameterElementFactory factory = null;

            try
            {
                factory = new DLParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IDSParameterElementFactory CreateDSParameterElementFactory()
        {
            IDSParameterElementFactory factory = null;

            try
            {
                factory = new DSParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IeParameterElementFactory CreateeParameterElementFactory()
        {
            IeParameterElementFactory factory = null;

            try
            {
                factory = new eParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IIParameterElementFactory CreateIParameterElementFactory()
        {
            IIParameterElementFactory factory = null;

            try
            {
                factory = new IParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public Testi2007.A.E.O.InterfacesFactories.ParameterElements.SP.WardNumberSessionBounds.IlParameterElementFactory CreateSPlParameterElementFactory()
        {
            Testi2007.A.E.O.InterfacesFactories.ParameterElements.SP.WardNumberSessionBounds.IlParameterElementFactory factory = null;

            try
            {
                factory = new Testi2007.A.E.O.Factories.ParameterElements.SP.WardNumberSessionBounds.lParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public Testi2007.A.E.O.InterfacesFactories.ParameterElements.TP.WardSurgeryRoomNumberSessionBounds.IlParameterElementFactory CreateTPlParameterElementFactory()
        {
            Testi2007.A.E.O.InterfacesFactories.ParameterElements.TP.WardSurgeryRoomNumberSessionBounds.IlParameterElementFactory factory = null;

            try
            {
                factory = new Testi2007.A.E.O.Factories.ParameterElements.TP.WardSurgeryRoomNumberSessionBounds.lParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public INParameterElementFactory CreateNParameterElementFactory()
        {
            INParameterElementFactory factory = null;

            try
            {
                factory = new nParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IoParameterElementFactory CreateoParameterElementFactory()
        {
            IoParameterElementFactory factory = null;

            try
            {
                factory = new oParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IpParameterElementFactory CreatepParameterElementFactory()
        {
            IpParameterElementFactory factory = null;

            try
            {
                factory = new pParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IWLParameterElementFactory CreateWLParameterElementFactory()
        {
            IWLParameterElementFactory factory = null;

            try
            {
                factory = new WLParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IWLLSParameterElementFactory CreateWLLSParameterElementFactory()
        {
            IWLLSParameterElementFactory factory = null;

            try
            {
                factory = new WLLSParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IWLSSParameterElementFactory CreateWLSSParameterElementFactory()
        {
            IWLSSParameterElementFactory factory = null;

            try
            {
                factory = new WLSSParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IμParameterElementFactory CreateμParameterElementFactory()
        {
            IμParameterElementFactory factory = null;

            try
            {
                factory = new μParameterElementFactory();
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