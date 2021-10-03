namespace Testi2007.A.E.O.Factories.ConstraintElements.TP
{
    using System;

    using log4net;

    using Testi2007.A.E.O.Classes.ConstraintElements.TP;
    using Testi2007.A.E.O.Interfaces.ConstraintElements.TP;
    using Testi2007.A.E.O.Interfaces.CrossJoins.TP;
    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.IndexElements.TP;
    using Testi2007.A.E.O.Interfaces.Parameters.TP.SurgeryRoomTypeSubsetSurgeryRooms;
    using Testi2007.A.E.O.Interfaces.Parameters.TP.WardSurgeryRoomNumberSessionBounds;
    using Testi2007.A.E.O.Interfaces.Variables.TP;
    using Testi2007.A.E.O.InterfacesFactories.ConstraintElements.TP;

    internal sealed class Constraints12ConstraintElementFactory : IConstraints12ConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints12ConstraintElementFactory()
        {
        }

        public IConstraints12ConstraintElement Create(
            IjIndexElement jIndexElement,
            IsIndexElement sIndexElement,
            Iiw iw,
            II I,
            Il l,
            ITPx x)
        {
            IConstraints12ConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints12ConstraintElement(
                    jIndexElement,
                    sIndexElement,
                    iw,
                    I,
                    l,
                    x);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return constraintElement;
        }
    }
}